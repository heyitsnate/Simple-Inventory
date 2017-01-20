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
    public partial class uscTransferStock : UserControl
    {
        public uscTransferStock()
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

            if (cmbFromWareHouse.SelectedItem != null)
            {
                dr = cmbFromWareHouse.SelectedItem as DataRowView;
                if (dr == null || dr.Row["WareHouseID"].ToString() == "0")
                {
                    errMsg = errMsg + Environment.NewLine + "From WareHouse is required.";
                    blnResult = false;
                }
            }
            else
            {
                errMsg = errMsg + Environment.NewLine + "From WareHouse is required.";
                blnResult = false;
            }

            if (cmbToWareHouse.SelectedItem != null)
            {
                dr = cmbToWareHouse.SelectedItem as DataRowView;
                if (dr == null || dr.Row["WareHouseID"].ToString() == "0")
                {
                    errMsg = errMsg + Environment.NewLine + "To WareHouse is required.";
                    blnResult = false;
                }
            }
            else
            {
                errMsg = errMsg + Environment.NewLine + "To WareHouse is required.";
                blnResult = false;
            }

            if (cmbFromWareHouse.SelectedValue.Equals(cmbToWareHouse.SelectedValue))
            {
                errMsg = errMsg + Environment.NewLine + "Transferring From WareHouse and To WareHouse cannot be same.";
                blnResult = false;
            }

            if (txtQuantity.Text.Trim() == String.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Transfer Quantity is required.";
                blnResult = false;
            }
            else
            {
                Decimal dummy = 0;
                if (Decimal.TryParse(txtQuantity.Text.Trim(), out dummy))
                {
                    if (dummy <= 0)
                    {
                        errMsg = errMsg + Environment.NewLine + "Transfer Quantity should be more than zero.";
                        blnResult = false;
                    }
                }
                else
                {
                    errMsg = errMsg + Environment.NewLine + "Transfer Quantity should be a valid decimal.";
                    blnResult = false;
                }
            }

            // Restrict duplicate detail entries only when above all entries are valid
            if (blnResult)
            {
                foreach (TransactionDataSet.TransactionDetailsRow tr in dtTransactionDetails.Rows)
                {
                    if (tr.ProductID.ToString() == cmbProducts.SelectedValue.ToString() &&
                        tr.FromWareHouseID.ToString() == cmbFromWareHouse.SelectedValue.ToString() &&
                        tr.ToWareHouseID.ToString() == cmbToWareHouse.SelectedValue.ToString())
                    {
                        errMsg = "The record has already been added to Transaction Details." + Environment.NewLine +
                                 "Duplicate entries are not allowed in transaction details" + Environment.NewLine +
                                 "You can modify quantity directly in the transaction details grid below.";
                        blnResult = false;
                        break;
                    }
                }

                // Restrict over quantity transactions only if not duplicate
                if (blnResult)
                {
                    InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp =
                        new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
                    Decimal TotalStock =
                        Convert.ToDecimal(adp.GetQuantity(Convert.ToInt32(cmbProducts.SelectedValue),
                            Convert.ToInt32(cmbFromWareHouse.SelectedValue), null));
                    Decimal TransactQuantity = Convert.ToDecimal(txtQuantity.Text.Trim());

                    if (TotalStock == 0)
                    {
                        errMsg = "There is no Stock for the selected Product in selected From WareHouse.";
                        blnResult = false;
                    }
                    else if (TransactQuantity > TotalStock)
                    {
                        errMsg = "Total Stock for the selected Product in selected WareHouse is:" +
                                 TotalStock.ToString() + Environment.NewLine +
                                 "Transfer Quantity cannot be more than " + TotalStock.ToString();
                        blnResult = false;
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

        #region From Events

        private void uscTransferStock_Load(object sender, EventArgs e)
        {
            Common.FillProducts(cmbProducts, true, "Select");
            Common.FillWareHouses(cmbFromWareHouse, true, "Select");
            Common.FillWareHouses(cmbToWareHouse, true, "Select");

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
                DataRowView drFromWareHouse;
                DataRowView drToWareHouse;

                drProduct = cmbProducts.SelectedItem as DataRowView;
                int ProductID = Convert.ToInt32(drProduct.Row["ProductID"]);

                drFromWareHouse = cmbFromWareHouse.SelectedItem as DataRowView;
                int FromWareHouseID = Convert.ToInt32(drFromWareHouse.Row["WareHouseID"]);

                drToWareHouse = cmbToWareHouse.SelectedItem as DataRowView;
                int ToWareHouseID = Convert.ToInt32(drToWareHouse.Row["WareHouseID"]);

                Decimal TransferQuantity = Convert.ToDecimal(txtQuantity.Text.Trim());

                InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adp =
                    new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
                InventoryStoreDataSet.tblInventoryDataTable dtInventory = adp.GetDataByProductAndWareHouse(ProductID,
                    FromWareHouseID);

                TransactionDataSet.TransactionDetailsRow drTransactionDetail =
                    dtTransactionDetails.NewTransactionDetailsRow();
                drTransactionDetail.ProductID = ProductID;
                drTransactionDetail.ProductName = drProduct.Row["ProductName"].ToString();
                drTransactionDetail.Manufacturer = drProduct.Row["Manufacturer"].ToString();
                drTransactionDetail.FromWareHouseID = FromWareHouseID;
                drTransactionDetail.FromWareHouseName = drFromWareHouse.Row["WareHouseName"].ToString();
                drTransactionDetail.ToWareHouseID = ToWareHouseID;
                drTransactionDetail.ToWareHouseName = drToWareHouse.Row["WareHouseName"].ToString();
                drTransactionDetail.TransactQuantity = TransferQuantity;
                drTransactionDetail.SetTransactCostNull();
                drTransactionDetail.SetTotalCostNull();
                drTransactionDetail.TransactionID = 0;
                dtTransactionDetails.AddTransactionDetailsRow(drTransactionDetail);

                foreach (InventoryStoreDataSet.tblInventoryRow drInventory in dtInventory.Rows)
                {
                    Decimal FromWareHouseOldQty = drInventory.Quantity;
                    Decimal ToWareHouseOldQty =
                        Convert.ToDecimal(adp.GetQuantity(ProductID, ToWareHouseID, drInventory.Cost));

                    TransactionDataSet.TransactionStockInformationRow drFromWareHouseTransactionStockInformation =
                        dtTransactionStockInformation.NewTransactionStockInformationRow();
                    drFromWareHouseTransactionStockInformation.Cost = drInventory.Cost;
                    drFromWareHouseTransactionStockInformation.OldQuantity = FromWareHouseOldQty;
                    drFromWareHouseTransactionStockInformation.NewQuantity = (TransferQuantity > FromWareHouseOldQty)
                        ? 0
                        : FromWareHouseOldQty - TransferQuantity;
                    drFromWareHouseTransactionStockInformation.TransactionDetailID =
                        drTransactionDetail.TransactionDetailID;
                    drFromWareHouseTransactionStockInformation.TransactQuantity = (TransferQuantity >
                                                                                   FromWareHouseOldQty)
                        ? FromWareHouseOldQty
                        : TransferQuantity;
                    drFromWareHouseTransactionStockInformation.IsFromWareHouse = true;
                    dtTransactionStockInformation.AddTransactionStockInformationRow(
                        drFromWareHouseTransactionStockInformation);

                    TransactionDataSet.TransactionStockInformationRow drToWareHouseTransactionStockInformation =
                        dtTransactionStockInformation.NewTransactionStockInformationRow();
                    drToWareHouseTransactionStockInformation.Cost = drInventory.Cost;
                    drToWareHouseTransactionStockInformation.OldQuantity = ToWareHouseOldQty;
                    drToWareHouseTransactionStockInformation.NewQuantity = (TransferQuantity > FromWareHouseOldQty)
                        ? ToWareHouseOldQty + FromWareHouseOldQty
                        : ToWareHouseOldQty + TransferQuantity;
                    drToWareHouseTransactionStockInformation.TransactionDetailID =
                        drTransactionDetail.TransactionDetailID;
                    drToWareHouseTransactionStockInformation.TransactQuantity = (TransferQuantity > FromWareHouseOldQty)
                        ? FromWareHouseOldQty
                        : TransferQuantity;
                    drToWareHouseTransactionStockInformation.IsFromWareHouse = false;
                    dtTransactionStockInformation.AddTransactionStockInformationRow(
                        drToWareHouseTransactionStockInformation);

                    if (TransferQuantity > FromWareHouseOldQty)
                    {
                        TransferQuantity = TransferQuantity - FromWareHouseOldQty;
                    }
                    else
                    {
                        TransferQuantity = 0;
                    }
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
                    TransactionDataSet.TransactionDetailsRow tr =
                        (TransactionDataSet.TransactionDetailsRow)
                        ((DataRowView) (dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;

                    DataRow[] drs =
                        dtTransactionStockInformation.Select("TransactionDetailID=" + tr.TransactionDetailID.ToString());
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
                TransactionDataSet.TransactionDetailsRow tr =
                    (TransactionDataSet.TransactionDetailsRow)
                    ((DataRowView) (dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
                ViewTransferredStockChangeInformation frmStock = new ViewTransferredStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = WhistlingPalms.ActionType.Transfer.ToString();
                frmStock.FromWareHouseName = tr.FromWareHouseName;
                frmStock.ToWareHouseName = tr.ToWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;

                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                    {
                        if (tsr.TransactionDetailID == tr.TransactionDetailID && tsr.IsFromWareHouse == true)
                            TotalTransactQty += tsr.TransactQuantity;
                    }
                    tr.TransactQuantity = TotalTransactQty;

                    dgvTransactionDetails.Refresh();
                }
            }
        }

        private void dgvTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionDetails.Columns[e.ColumnIndex].Name == "TransactQuantityColumn" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionDetailsRow tr =
                    (TransactionDataSet.TransactionDetailsRow)
                    ((DataRowView) (dgvTransactionDetails.Rows[e.RowIndex].DataBoundItem)).Row;
                ViewTransferredStockChangeInformation frmStock = new ViewTransferredStockChangeInformation();
                frmStock.dt = dtTransactionStockInformation;
                frmStock.TransactionDetailID = tr.TransactionDetailID;
                frmStock.ActionType = WhistlingPalms.ActionType.Transfer.ToString();
                frmStock.FromWareHouseName = tr.FromWareHouseName;
                frmStock.ToWareHouseName = tr.ToWareHouseName;
                frmStock.FullProductName = tr.ProductName + ", " + tr.Manufacturer;

                if (frmStock.ShowDialog() == DialogResult.OK)
                {
                    decimal TotalTransactQty = 0;
                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in frmStock.dt.Rows)
                    {
                        if (tsr.TransactionDetailID == tr.TransactionDetailID && tsr.IsFromWareHouse == true)
                            TotalTransactQty += tsr.TransactQuantity;
                    }
                    tr.TransactQuantity = TotalTransactQty;

                    dgvTransactionDetails.Refresh();
                }
            }
        }

        #endregion
    }
}