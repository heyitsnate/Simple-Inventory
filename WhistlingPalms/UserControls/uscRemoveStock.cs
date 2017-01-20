using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WhistlingPalms.InventoryStoreDataSetTableAdapters;

namespace WhistlingPalms
{
    public partial class uscRemoveStock : UserControl
    {
        public uscRemoveStock()
        {
            InitializeComponent();
        }

        #region HelperMethods

        private bool ValidateTransactionDetails()
        {
            var blnResult = true;
            var errMsg = "";

            DataRowView dr;

            if (cmbProducts.SelectedItem != null)
            {
                dr = cmbProducts.SelectedItem as DataRowView;
                if (dr == null || dr.Row["ProductID"].ToString() == "0")
                {
                    errMsg = errMsg + Environment.NewLine + "Product is required.";
                    blnResult = false;
                }
            }
            else
            {
                errMsg = errMsg + Environment.NewLine + "Product is required.";
                blnResult = false;
            }

            if (cmbWareHouse.SelectedItem != null)
            {
                dr = cmbWareHouse.SelectedItem as DataRowView;
                if (dr == null || dr.Row["WareHouseID"].ToString() == "0")
                {
                    errMsg = errMsg + Environment.NewLine + "WareHouse is required.";
                    blnResult = false;
                }
            }
            else
            {
                errMsg = errMsg + Environment.NewLine + "WareHouse is required.";
                blnResult = false;
            }

            if (txtCost.Text.Trim() == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Transact Cost is required.";
                blnResult = false;
            }
            else
            {
                decimal dummy = 0;
                if (decimal.TryParse(txtCost.Text.Trim(), out dummy))
                {
                    if (dummy < 0)
                    {
                        errMsg = errMsg + Environment.NewLine + "Transact Cost cannot be less than zero.";
                        blnResult = false;
                    }
                }
                else
                {
                    errMsg = errMsg + Environment.NewLine + "Transact Cost should be a valid decimal.";
                    blnResult = false;
                }
            }

            if (txtQuantity.Text.Trim() == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Transact Quantity is required.";
                blnResult = false;
            }
            else
            {
                decimal dummy = 0;
                if (decimal.TryParse(txtQuantity.Text.Trim(), out dummy))
                {
                    if (dummy <= 0)
                    {
                        errMsg = errMsg + Environment.NewLine + "Transact Quantity should be more than zero.";
                        blnResult = false;
                    }
                }
                else
                {
                    errMsg = errMsg + Environment.NewLine + "Transact Quantity should be a valid decimal.";
                    blnResult = false;
                }
            }

            // Restrict duplicate detail entries only when above all entries are valid
            if (blnResult)
            {
                foreach (TransactionDataSet.TransactionDetailsRow tr in dtTransactionDetails.Rows)
                    if (tr.ProductID.ToString() == cmbProducts.SelectedValue.ToString() &&
                        tr.FromWareHouseID.ToString() == cmbWareHouse.SelectedValue.ToString())
                    {
                        errMsg = "The record has already been added to Transaction Details." + Environment.NewLine +
                                 "Duplicate entries are not allowed in transaction details" + Environment.NewLine +
                                 "You can modify quantity as well as cost directly in the transaction details grid below.";
                        blnResult = false;
                        break;
                    }

                // Restrict over quantity transactions only if not duplicate
                if (blnResult)
                {
                    var adp =
                        new tblInventoryTableAdapter();
                    var TotalStock =
                        Convert.ToDecimal(adp.GetQuantity(Convert.ToInt32(cmbProducts.SelectedValue),
                            Convert.ToInt32(cmbWareHouse.SelectedValue), null));
                    var TransactQuantity = Convert.ToDecimal(txtQuantity.Text.Trim());

                    if (TotalStock == 0)
                    {
                        errMsg = "There is no Stock for the selected Product in selected WareHouse.";
                        blnResult = false;
                    }
                    else if (TransactQuantity > TotalStock)
                    {
                        errMsg = "Total Stock for the selected Product in selected WareHouse is:" +
                                 TotalStock + Environment.NewLine +
                                 "Transaction Quantity cannot be more than " + TotalStock;
                        blnResult = false;
                    }
                }
            }

            if (!blnResult)
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return blnResult;
        }

        #endregion

        #region Global Variables

        public TransactionDataSet dsTransaction;
        public TransactionDataSet.TransactionDetailsDataTable dtTransactionDetails;
        public TransactionDataSet.TransactionStockInformationDataTable dtTransactionStockInformation;

        #endregion

        #region Form Events

        private void uscRemoveStock_Load(object sender, EventArgs e)
        {
            Common.FillProducts(cmbProducts, true, "Select");
            Common.FillWareHouses(cmbWareHouse, true, "Select");

            dsTransaction = new TransactionDataSet();
            dtTransactionDetails = dsTransaction.TransactionDetails;
            dtTransactionStockInformation = dsTransaction.TransactionStockInformation;

            dgvTransactionDetails.AutoGenerateColumns = false;
            dgvTransactionDetails.DataSource = dtTransactionDetails;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
                if (e.KeyChar == '.')
                    if (tb.Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                else
                    e.Handled = true;
            else
                e.Handled = false;
        }

        private void btnAddToTransaction_Click(object sender, EventArgs e)
        {
            if (ValidateTransactionDetails())
            {
                DataRowView drProduct;
                DataRowView drWareHouse;
                drProduct = cmbProducts.SelectedItem as DataRowView;
                var ProductID = Convert.ToInt32(drProduct.Row["ProductID"]);

                drWareHouse = cmbWareHouse.SelectedItem as DataRowView;
                var WareHouseID = Convert.ToInt32(drWareHouse.Row["WareHouseID"]);

                var TransactCost = Convert.ToDecimal(txtCost.Text.Trim());
                var TransactQuantity = Convert.ToDecimal(txtQuantity.Text.Trim());

                var adp =
                    new tblInventoryTableAdapter();
                var dtInventory = adp.GetDataByProductAndWareHouse(ProductID,
                    WareHouseID);

                var drTransactionDetail =
                    dtTransactionDetails.NewTransactionDetailsRow();
                drTransactionDetail.ProductID = ProductID;
                drTransactionDetail.ProductName = drProduct.Row["ProductName"].ToString();
                drTransactionDetail.Manufacturer = drProduct.Row["Manufacturer"].ToString();
                drTransactionDetail.FromWareHouseID = WareHouseID;
                drTransactionDetail.FromWareHouseName = drWareHouse.Row["WareHouseName"].ToString();
                drTransactionDetail.SetToWareHouseIDNull();
                drTransactionDetail.SetToWareHouseNameNull();
                drTransactionDetail.TransactQuantity = TransactQuantity;
                drTransactionDetail.TransactCost = TransactCost;
                drTransactionDetail.TotalCost = TransactCost * TransactQuantity;
                drTransactionDetail.TransactionID = 0;
                dtTransactionDetails.AddTransactionDetailsRow(drTransactionDetail);

                foreach (InventoryStoreDataSet.tblInventoryRow drInventory in dtInventory.Rows)
                {
                    var OldQty = drInventory.Quantity;
                    var drTransactionStockInformation =
                        dtTransactionStockInformation.NewTransactionStockInformationRow();
                    drTransactionStockInformation.Cost = drInventory.Cost;
                    drTransactionStockInformation.OldQuantity = OldQty;
                    drTransactionStockInformation.NewQuantity = TransactQuantity > OldQty
                        ? 0
                        : OldQty - TransactQuantity;
                    drTransactionStockInformation.TransactionDetailID = drTransactionDetail.TransactionDetailID;
                    drTransactionStockInformation.TransactQuantity = TransactQuantity > OldQty
                        ? OldQty
                        : TransactQuantity;
                    drTransactionStockInformation.IsFromWareHouse = true;
                    dtTransactionStockInformation.AddTransactionStockInformationRow(drTransactionStockInformation);

                    if (TransactQuantity > OldQty)
                        TransactQuantity = TransactQuantity - OldQty;
                    else
                        TransactQuantity = 0;
                }

                dgvTransactionDetails.Refresh();
            }
        }

        private void dgvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "DeleteColumn" && e.RowIndex >= 0)
            {
                if (
                    MessageBox.Show("Are you sure you want to delete this transaction record?", "Confirm Delete",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var tr =
                        (TransactionDataSet.TransactionDetailsRow)
                        ((DataRowView) dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem).Row;

                    var drs =
                        dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID);
                    foreach (var r in drs)
                        r.Delete();
                    dtTransactionDetails.Rows.Find(tr.TransactionDetailID).Delete();

                    dgvTransactionDetails.Refresh();
                }
            }
            else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "StockInformationButtonColumn" && e.RowIndex >= 0)
            {
                var tr =
                    (TransactionDataSet.TransactionDetailsRow)
                    ((DataRowView) dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem).Row;
                var frmStock = new ViewStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = ActionType.Deduction.ToString();
                frmStock.WareHouseName = tr.FromWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;
                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                        if (tsr.TransactionDetailID == tr.TransactionDetailID)
                            TotalTransactQty += tsr.TransactQuantity;
                    tr.TransactQuantity = TotalTransactQty;
                    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

                    dgvTransactionDetails.Refresh();
                }
            }
        }

        private void dgvTransactionDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the cell error in case the user presses ESC.   
            dgvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void dgvTransactionDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var HasError = false;
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactCostColumn" && e.RowIndex >= 0)
            {
                decimal dummy = 0;

                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    MessageBox.Show("Transact Cost is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HasError = true;
                }
                else
                {
                    if (decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
                    {
                        if (dummy <= 0)
                        {
                            MessageBox.Show("Transact Cost should be more than zero.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            HasError = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transact Cost should be a valid decimal.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        HasError = true;
                    }
                }

                e.Cancel = HasError;
            }
            //else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            //{
            //    Decimal dummy = 0;
            //    if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
            //    {
            //        MessageBox.Show("Transact Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        HasError = true;
            //    }
            //    else
            //    {
            //        if (Decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
            //        {
            //            if (dummy <= 0)
            //            {
            //                MessageBox.Show("Transact Quantity should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                HasError = true;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Transact Quantity should be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            HasError = true;
            //        }
            //    }

            //    // Restrict over quantity transactions only if quantity is valid
            //    if (!HasError)
            //    {
            //        InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
            //        Decimal TotalStock = Convert.ToDecimal(adp.GetQuantity(Convert.ToInt32(cmbProducts.SelectedValue), Convert.ToInt32(cmbWareHouse.SelectedValue), null));

            //        if (TotalStock == 0)
            //        {
            //            MessageBox.Show("There is no Stock for the selected Product in selected WareHouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            HasError = true;
            //        }
            //        else if (dummy > TotalStock)
            //        {
            //            MessageBox.Show("Total Stock for the selected Product in selected WareHouse is:" + TotalStock.ToString() + Environment.NewLine +
            //                "Transaction Quantity cannot be more than " + TotalStock.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            HasError = true;
            //        }
            //    }

            //    e.Cancel = HasError;
            //}
        }

        private void dgvTransactionDetails_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactCostColumn" && e.RowIndex >= 0)
            {
                var tr =
                    (TransactionDataSet.TransactionDetailsRow)
                    ((DataRowView) dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem).Row;
                tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

                dgvTransactionDetails.Refresh();
            }
            //else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            //{
            //    TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
            //    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

            //    DataRow[] trs = dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID);
            //    foreach (DataRow r in trs)
            //    {
            //        r.Delete();
            //    }

            //    InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
            //    InventoryStoreDataSet.tblInventoryDataTable dtInventory = adp.GetDataByProductAndWareHouse(tr.ProductID, tr.FromWareHouseID);
            //    Decimal TransactQuantity = tr.TransactQuantity;

            //    foreach (InventoryStoreDataSet.tblInventoryRow drInventory in dtInventory.Rows)
            //    {
            //        Decimal OldQty = drInventory.Quantity;
            //        TransactionDataSet.TransactionStockInformationRow drTransactionStockInformation = dtTransactionStockInformation.NewTransactionStockInformationRow();
            //        drTransactionStockInformation.Cost = drInventory.Cost;
            //        drTransactionStockInformation.OldQuantity = OldQty;
            //        drTransactionStockInformation.NewQuantity = (TransactQuantity > OldQty) ? 0 : OldQty - TransactQuantity;
            //        drTransactionStockInformation.TransactionDetailID = tr.TransactionDetailID;
            //        drTransactionStockInformation.ProductName = tr.ProductName;
            //        drTransactionStockInformation.FromWareHouseName = tr.FromWareHouseName;
            //        drTransactionStockInformation.SetToWareHouseNameNull();
            //        drTransactionStockInformation.TransactQuantity = (TransactQuantity > OldQty) ? OldQty : TransactQuantity;
            //        dtTransactionStockInformation.AddTransactionStockInformationRow(drTransactionStockInformation);

            //        if (TransactQuantity > OldQty)
            //        {
            //            TransactQuantity = TransactQuantity - OldQty;
            //        }
            //        else
            //        {
            //            TransactQuantity = 0;
            //        }
            //    }

            //    dgvTransactionDetails.Refresh();
            //}
        }

        private void dgvTransactionDetails_EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTransactionDetails.CurrentCell.OwningColumn.Name == "TransactCostColumn")
                if (e.Control is TextBox)
                {
                    var tb = e.Control as TextBox;
                    tb.KeyPress -= NumericTextBox_KeyPress;
                    tb.KeyPress += NumericTextBox_KeyPress;
                }
        }

        private void dgvTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            {
                var tr =
                    (TransactionDataSet.TransactionDetailsRow)
                    ((DataRowView) dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem).Row;
                var frmStock = new ViewStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = ActionType.Deduction.ToString();
                frmStock.WareHouseName = tr.FromWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;
                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                        if (tsr.TransactionDetailID == tr.TransactionDetailID)
                            TotalTransactQty += tsr.TransactQuantity;
                    tr.TransactQuantity = TotalTransactQty;
                    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

                    dgvTransactionDetails.Refresh();
                }
            }
        }

        #endregion
    }
}