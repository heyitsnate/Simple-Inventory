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
    public partial class ViewStockChangeInformation : Form
    {
        public ViewStockChangeInformation()
        {
            InitializeComponent();
        }

        #region Global variables

        public TransactionDataSet.TransactionStockInformationDataTable dt;
        public int TransactionDetailID = 0;
        public string ActionType = "";
        public string WareHouseName = "";
        public string FullProductName = "";
        
        #endregion

        #region Form Events

        private void ViewStockChangeInformation_Load(object sender, EventArgs e)
        {
            dgvStockInfo.AutoGenerateColumns = false;
            string strFilter = "TransactionDetailID=" + TransactionDetailID.ToString();
            DataView dv = dt.AsDataView();
            dv.RowFilter = strFilter;
            dgvStockInfo.DataSource = dv;

            lblProduct.Text = FullProductName;
            lblWareHouse.Text = WareHouseName;
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

        private void dgvStockInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (ActionType == WhistlingPalms.ActionType.Addition.ToString())
            {
                if (dgvStockInfo.Columns[e.ColumnIndex].Name == "TransactQuantity" && e.RowIndex >= 0)
                {

                    if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                    {
                        MessageBox.Show("Transact Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        Decimal dummy = 0;
                        if (Decimal.TryParse(e.FormattedValue.ToString().Trim(), out dummy))
                        {
                            if (dummy < 0)
                            {
                                MessageBox.Show("Transact Quantity should be more than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Transact Quantity should be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                }
            }
            else if (ActionType == WhistlingPalms.ActionType.Deduction.ToString())
            {
                if (dgvStockInfo.Columns[e.ColumnIndex].Name == "TransactQuantity" && e.RowIndex >= 0)
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
                        Decimal OldQty = Convert.ToDecimal(dgvStockInfo.Rows[e.RowIndex].Cells["OldQuantity"].FormattedValue);

                        if (dummy > OldQty)
                        {
                            MessageBox.Show("Transaction Quantity for this row cannot be more than " + OldQty.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HasError = true;
                        }
                    }

                    e.Cancel = HasError;
                }
            }
        }

        private void dgvStockInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the cell error in case the user presses ESC.   
            dgvStockInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Empty;
        }

        private void dgvStockInfo_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockInfo.Columns[e.ColumnIndex].Name == "TransactQuantity" && e.RowIndex >= 0)
            {
                TransactionDataSet.TransactionStockInformationRow trs = (TransactionDataSet.TransactionStockInformationRow)((DataRowView)(dgvStockInfo.Rows[e.RowIndex].DataBoundItem)).Row;

                if (ActionType == WhistlingPalms.ActionType.Addition.ToString())
                    trs.NewQuantity = trs.OldQuantity + trs.TransactQuantity;
                else if (ActionType == WhistlingPalms.ActionType.Deduction.ToString())
                    trs.NewQuantity = trs.OldQuantity - trs.TransactQuantity;

                dgvStockInfo.Refresh();
            }
        }

        private void dgvStockInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvStockInfo.CurrentCell.OwningColumn.Name == "TransactQuantity")
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
