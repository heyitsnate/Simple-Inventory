using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhistlingPalms
{
    public partial class uscAddStock : UserControl
    {
        public uscAddStock()
        {
            InitializeComponent();
        }

        #region Global Variables

        public TransactionDataSet dsTransaction;
        public TransactionDataSet.TransactionDetailsDataTable dtTransactionDetails;
        public TransactionDataSet.TransactionStockInformationDataTable dtTransactionStockInformation;
        
        #endregion

        #region HelperMethods

        private bool ValidateTransactionDetails()
        {
            bool blnResult = true;
            string errMsg = "";

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

            if (txtCost.Text.Trim() == String.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Transact Cost is required.";
                blnResult = false;
            }
            else
            {
                Decimal dummy = 0;
                if (Decimal.TryParse(txtCost.Text.Trim(), out dummy))
                {
                    if (dummy <= 0)
                    {
                        errMsg = errMsg + Environment.NewLine + "Transact Cost should be more than zero.";
                        blnResult = false;
                    }
                }
                else
                {
                    errMsg = errMsg + Environment.NewLine + "Transact Cost should be a valid decimal.";
                    blnResult = false;
                }
            }

            if (txtQuantity.Text.Trim() == String.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Transact Quantity is required.";
                blnResult = false;
            }
            else
            {
                Decimal dummy = 0;
                if (Decimal.TryParse(txtQuantity.Text.Trim(), out dummy))
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
                {
                    if (tr.ProductID.ToString() == cmbProducts.SelectedValue.ToString() &&
                        tr.FromWareHouseID.ToString() == cmbWareHouse.SelectedValue.ToString() &&
                        tr.TransactCost == Convert.ToDecimal(txtCost.Text.Trim()))
                    {
                        errMsg = "The record has already been added to Transaction Details." + Environment.NewLine +
                            "Duplicate entries are not allowed in transaction details" + Environment.NewLine +
                            "You can modify quantity as well as cost directly in the transaction details grid below.";
                        blnResult = false;
                        break;
                    }
                }
            }

            if (!blnResult)
            {
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return blnResult;
        }

        #endregion

        #region Form Events

        private void uscAddStock_Load(object sender, EventArgs e)
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
            TextBox tb = sender as TextBox;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                if (e.KeyChar == '.')
                {
                    if (tb.Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
                else
                    e.Handled = true;
            }
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
                int ProductID = Convert.ToInt32(drProduct.Row["ProductID"]);
                
                drWareHouse = cmbWareHouse.SelectedItem as DataRowView;
                int WareHouseID = Convert.ToInt32(drWareHouse.Row["WareHouseID"]);
                
                Decimal TransactCost = Convert.ToDecimal(txtCost.Text.Trim());
                Decimal TransactQuantity = Convert.ToDecimal(txtQuantity.Text.Trim());

                InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
                Decimal OldQty = Convert.ToDecimal(adp.GetQuantity(ProductID, WareHouseID, TransactCost));

                TransactionDataSet.TransactionDetailsRow drTransactionDetail = dtTransactionDetails.NewTransactionDetailsRow();
                TransactionDataSet.TransactionStockInformationRow drTransactionStockInformation = dtTransactionStockInformation.NewTransactionStockInformationRow();
                
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
                //Object objTrID = dt.Compute("MAX(TransactionDetailID)", "");
                //tr.TransactionDetailID = Convert.ToInt32(objTrID == DBNull.Value ? 0 : objTrID) + 1;
                dtTransactionDetails.AddTransactionDetailsRow(drTransactionDetail);

                drTransactionStockInformation.Cost = TransactCost;
                drTransactionStockInformation.OldQuantity = OldQty;
                drTransactionStockInformation.NewQuantity = OldQty + TransactQuantity;
                drTransactionStockInformation.TransactionDetailID = drTransactionDetail.TransactionDetailID;
                drTransactionStockInformation.TransactQuantity = TransactQuantity;
                drTransactionStockInformation.IsFromWareHouse = true;
                dtTransactionStockInformation.AddTransactionStockInformationRow(drTransactionStockInformation);

                dgvTransactionDetails.Refresh();
            }
        }

        private void dgvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "DeleteColumn" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this transaction record?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;

                    DataRow[] drs = dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID.ToString());
                    foreach (DataRow r in drs)
                    {
                        r.Delete();
                    }
                    dtTransactionDetails.Rows.Find(tr.TransactionDetailID).Delete();

                    dgvTransactionDetails.Refresh();
                }
            }
            else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "StockInformationButtonColumn" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;

                ViewStockChangeInformation frmStock = new ViewStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = WhistlingPalms.ActionType.Addition.ToString();
                frmStock.WareHouseName = tr.FromWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;
                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                    {
                        if(tsr.TransactionDetailID == tr.TransactionDetailID)
                            TotalTransactQty += tsr.TransactQuantity;
                    }
                    tr.TransactQuantity = TotalTransactQty;
                    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;
                    
                    dgvTransactionDetails.Refresh();
                }
            }
        }

        private void dgvTransactionDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the cell error in case the user presses ESC.   
            dgvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Empty;
        }

        private void dgvTransactionDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactCostColumn" && e.RowIndex >= 0)
            {
                bool HasError = false;
                Decimal dummy = 0;

                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    MessageBox.Show("Transact Cost is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HasError = true;
                }
                else
                {
                    if (Decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
                    {
                        if (dummy <= 0)
                        {
                            MessageBox.Show("Transact Cost should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HasError = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transact Cost should be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HasError = true;
                    }
                }

                //Restrict duplicate entries only if Product Cost is a valid decimal greater than zero
                if (!HasError)
                {
                    TransactionDataSet.TransactionDetailsRow editedRow = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
                    foreach (TransactionDataSet.TransactionDetailsRow tr in dtTransactionDetails.Rows)
                    {
                        if (tr.ProductID == editedRow.ProductID &&
                            tr.FromWareHouseID == editedRow.FromWareHouseID &&
                            tr.TransactCost == dummy &&
                            tr.TransactionDetailID != editedRow.TransactionDetailID)
                        {
                            MessageBox.Show("The record has already been added to Transaction Details." + Environment.NewLine +
                                "Duplicate entries are not allowed in transaction details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HasError = true;
                            break;
                        }
                    }
                }
                
                e.Cancel = HasError;
            }
            //else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            //{

            //    if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
            //    {
            //        MessageBox.Show("Transact Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        Decimal dummy = 0;
            //        if (Decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
            //        {
            //            if (dummy <= 0)
            //            {
            //                MessageBox.Show("Transact Quantity should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                e.Cancel = true;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Transact Quantity should be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            e.Cancel = true;
            //        }
            //    }
            //}
        }

        private void dgvTransactionDetails_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactCostColumn" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
                tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

                InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
                Decimal OldQty = Convert.ToDecimal(adp.GetQuantity(tr.ProductID, tr.FromWareHouseID, tr.TransactCost));
                TransactionDataSet.TransactionStockInformationRow trs = (TransactionDataSet.TransactionStockInformationRow)dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID)[0];
                trs.Cost = tr.TransactCost;
                trs.OldQuantity = OldQty;
                trs.NewQuantity = OldQty + tr.TransactQuantity;
                
                dgvTransactionDetails.Refresh();                
            }
            //else if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            //{
            //    TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
            //    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

            //    TransactionDataSet.TransactionStockInformationRow trs = (TransactionDataSet.TransactionStockInformationRow)dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID)[0];
            //    trs.TransactQuantity = tr.TransactQuantity;
            //    trs.NewQuantity = trs.OldQuantity + tr.TransactQuantity;
                
            //    dgvTransactionDetails.Refresh();
            //}
        }

        private void dgvTransactionDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTransactionDetails.CurrentCell.OwningColumn.Name == "TransactCostColumn")
            {
                if (e.Control is TextBox)
                {
                    TextBox tb = e.Control as TextBox;
                    tb.KeyPress -= new KeyPressEventHandler(NumericTextBox_KeyPress);
                    tb.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
                }
            }
        }

        private void dgvTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionDetailsRow tr = (TransactionDataSet.TransactionDetailsRow)((DataRowView)(dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;

                ViewStockChangeInformation frmStock = new ViewStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = WhistlingPalms.ActionType.Addition.ToString();
                frmStock.WareHouseName = tr.FromWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;
                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                    {
                        if (tsr.TransactionDetailID == tr.TransactionDetailID)
                            TotalTransactQty += tsr.TransactQuantity;
                    }
                    tr.TransactQuantity = TotalTransactQty;
                    tr.TotalCost = tr.TransactCost * tr.TransactQuantity;

                    dgvTransactionDetails.Refresh();
                }
            }
        }                       
        #endregion
    }
}
