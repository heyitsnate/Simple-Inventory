using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhistlingPalms
{
    public partial class ViewTransferredStockChangeInformation : Form
    {
        public ViewTransferredStockChangeInformation()
        {
            InitializeComponent();
        }

        #region Global variables

        public TransactionDataSet.TransactionStockInformationDataTable dt;
        public int TransactionDetailID = 0;
        public string ActionType = "";
        public string FromWareHouseName = "";
        public string ToWareHouseName = "";
        public string FullProductName = "";

        #endregion

        #region Form Events

        private void ViewTransferredStockChangeInformation_Load(object sender, EventArgs e)
        {
            dgvFromWareHouseStockInfo.AutoGenerateColumns = false;
            dgvToWareHouseStockInfo.AutoGenerateColumns = false;

            string strFromWareHouseFilter = "TransactionDetailID=" + TransactionDetailID.ToString() + " AND IsFromWareHouse=1";
            string strToWareHouseFilter = "TransactionDetailID=" + TransactionDetailID.ToString() + " AND IsFromWareHouse=0";
            DataView dvFromWareHouse = dt.AsDataView();
            DataView dvToWareHouse = dt.AsDataView();
            dvFromWareHouse.RowFilter = strFromWareHouseFilter;
            dvToWareHouse.RowFilter = strToWareHouseFilter;
            dgvFromWareHouseStockInfo.DataSource = dvFromWareHouse;
            dgvToWareHouseStockInfo.DataSource = dvToWareHouse;

            lblProduct.Text = FullProductName;
            lblFromWareHouse.Text = FromWareHouseName;
            lblToWareHouse.Text = ToWareHouseName;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                switch (e.KeyChar)
                {
                    case '.':
                        if (tb.Text.Contains('.'))
                            e.Handled = true;
                        else
                            e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
            else
                e.Handled = false;
        }

        private void dgvFromWareHouseStockInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvFromWareHouseStockInfo.Columns[e.ColumnIndex].Name == "TransactQuantity" && e.RowIndex >= 0)
            {
                bool HasError = false;
                Decimal dummy = 0;

                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    MessageBox.Show("Transact Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HasError = true;
                }
                else
                {
                    if (Decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
                    {
                        if (dummy < 0)
                        {
                            MessageBox.Show("Transact Quantity should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HasError = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transact Quantity should be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HasError = true;
                    }
                }

                //Restrict over quantity transactions only if quantity is valid
                if (!HasError)
                {
                    Decimal OldQty = Convert.ToDecimal(dgvFromWareHouseStockInfo.Rows[e.RowIndex].Cells["OldQuantity"].FormattedValue);

                    if (dummy > OldQty)
                    {
                        MessageBox.Show("Transaction Quantity for this row cannot be more than " + OldQty.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HasError = true;
                    }
                }

                e.Cancel = HasError;
            }
        }

        private void dgvFromWareHouseStockInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the cell error in case the user presses ESC.   
            dgvFromWareHouseStockInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Empty;
        }

        private void dgvFromWareHouseStockInfo_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFromWareHouseStockInfo.Columns[e.ColumnIndex].Name == "TransactQuantity" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionStockInformationRow trsFromWareHouse = (TransactionDataSet.TransactionStockInformationRow)((DataRowView)(dgvFromWareHouseStockInfo.Rows[e.RowIndex].DataBoundItem)).Row;
                TransactionDataSet.TransactionStockInformationRow trsToWareHouse = (TransactionDataSet.TransactionStockInformationRow)((DataRowView)(dgvToWareHouseStockInfo.Rows[e.RowIndex].DataBoundItem)).Row;
                trsFromWareHouse.NewQuantity = trsFromWareHouse.OldQuantity - trsFromWareHouse.TransactQuantity;
                trsToWareHouse.NewQuantity = trsToWareHouse.OldQuantity + trsFromWareHouse.TransactQuantity;
                trsToWareHouse.TransactQuantity = trsFromWareHouse.TransactQuantity;
                dgvFromWareHouseStockInfo.Refresh();
                dgvToWareHouseStockInfo.Refresh();
            }
        }

        private void dgvFromWareHouseStockInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvFromWareHouseStockInfo.CurrentCell.OwningColumn.Name == "TransactQuantity")
            {
                if (e.Control is TextBox)
                {
                    TextBox tb = e.Control as TextBox;
                    tb.KeyPress -= new KeyPressEventHandler(NumericTextBox_KeyPress);
                    tb.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal TotalTransactQty = 0;
            foreach (TransactionDataSet.TransactionStockInformationRow dr in dt.Rows)
            {
                if (dr.TransactionDetailID == TransactionDetailID)
                    TotalTransactQty += dr.TransactQuantity;
            }
            if (TotalTransactQty == 0)
            {
                MessageBox.Show("Total Transaction Quantity should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        #endregion

    }
}
