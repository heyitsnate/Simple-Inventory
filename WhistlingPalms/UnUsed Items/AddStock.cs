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
    public partial class AddStock : Form
    {
        InventoryStoreDataSetTableAdapters.tblInventoryTransactionTableAdapter taInventoryTransaction = new InventoryStoreDataSetTableAdapters.tblInventoryTransactionTableAdapter();
        InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter taInventory = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();
        string errorMsg = string.Empty;

        public AddStock()
        {
            InitializeComponent();
        }

        #region HelperMethods

        private void FillGrid(bool forceReload)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.DataSource == null || forceReload)
            {
                InventoryStoreDataSetTableAdapters.ProductsInventoryTableAdapter adp = new InventoryStoreDataSetTableAdapters.ProductsInventoryTableAdapter();

                string strFilter = GetFilterString();

                DataView dv = adp.GetData().AsDataView();
                dv.RowFilter = strFilter;

                dataGridView1.DataSource = dv;
            }
            else
            {
                string strFilter = GetFilterString();

                DataView dv = dataGridView1.DataSource as DataView;
                dv.RowFilter = strFilter;

                dataGridView1.DataSource = dv;
            }
        }

        private string GetFilterString()
        {
            string strFilter = string.Empty;
            DataRowView dr;

            if (cmbProducts.SelectedItem != null)
            {
                dr = cmbProducts.SelectedItem as DataRowView;
                if (dr != null && dr.Row["ProductID"].ToString() != "0")
                {
                    if (strFilter == string.Empty)
                    {
                        strFilter = ("ProductID = '" + dr.Row["ProductID"].ToString() + "'");
                    }
                    else
                    {
                        strFilter += (" AND ProductID = '" + dr.Row["ProductID"].ToString() + "'");
                    }
                }
            }

            if (cmbWareHouse.SelectedItem != null)
            {
                dr = cmbWareHouse.SelectedItem as DataRowView;
                if (dr != null && dr.Row["WareHouseID"].ToString() != "0")
                {
                    if (strFilter == string.Empty)
                    {
                        strFilter = ("WareHouseID = '" + dr.Row["WareHouseID"].ToString() + "'");
                    }
                    else
                    {
                        strFilter += (" AND WareHouseID = '" + dr.Row["WareHouseID"].ToString() + "'");
                    }
                }
            }
            return strFilter;
        }

        private void ReloadControl()
        {
            transactionDetailsTextBox.Text = string.Empty;
            transactionDateDateTimePicker.Value = DateTime.Now;
            cmbProducts.SelectedIndex = 0;
            cmbWareHouse.SelectedIndex = 0;
            costTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            commentsTextBox.Text = string.Empty;
            FillGrid(true);
        }

        private bool ValidateForm()
        {
            errorMsg = string.Empty;
            if (transactionDetailsTextBox.Text == string.Empty)
            {
                errorMsg += "Transaction Details is Required" + Environment.NewLine;
            }
            if (cmbProducts.SelectedValue.ToString() == "0")
            {
                errorMsg += "Product Selection is Required" + Environment.NewLine;
            }
            if (cmbWareHouse.SelectedValue.ToString() == "0")
            {
                errorMsg += "WareHouse Selection is Required" + Environment.NewLine;
            }
            if (costTextBox.Text == string.Empty)
            {
                errorMsg += "Cost is Required" + Environment.NewLine;
            }
            if (quantityTextBox.Text == string.Empty)
            {
                errorMsg += "Quantity is Required" + Environment.NewLine;
            }

            if (costTextBox.Text != string.Empty)
            {
                if (Convert.ToDecimal(costTextBox.Text) <= 0)
                    errorMsg += "Cost should be greater than 0" + Environment.NewLine;
            }

            if (quantityTextBox.Text != string.Empty)
            {
                if (Convert.ToDecimal(quantityTextBox.Text) <= 0)
                    errorMsg += "Quantity should be greater than 0" + Environment.NewLine;
            }

            if (errorMsg != string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool SaveStock()
        {
            if (ValidateForm() == true)
            {
                try
                {
                    string transactionDetails = transactionDetailsTextBox.Text;
                    DateTime dateTime = transactionDateDateTimePicker.Value;
                    int productId = Convert.ToInt32(cmbProducts.SelectedValue.ToString());
                    int wareHouseID = Convert.ToInt32(cmbWareHouse.SelectedValue.ToString());
                    decimal cost = Convert.ToDecimal(costTextBox.Text);
                    decimal transactQuantity = Convert.ToDecimal(quantityTextBox.Text);
                    decimal oldQuantity = 0;
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        if (Convert.ToDecimal(dr.Cells["Cost"].Value.ToString()) == cost)
                        {
                            oldQuantity = Convert.ToDecimal(dr.Cells["Quantity"].Value);
                        }
                    }
                    decimal newQuantity = oldQuantity + transactQuantity;
                    string transactionType = "Addition";
                    string comments = commentsTextBox.Text;
                    if (Convert.ToInt32(taInventoryTransaction.AddStock(transactionDetails, dateTime, productId, wareHouseID, cost, null, oldQuantity, transactQuantity, newQuantity, transactionType, comments)) > 0)
                    {
                        MessageBox.Show("Stock Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region FormEvents

        private void AddStock_Load(object sender, EventArgs e)
        {
            Common.FillProducts(cmbProducts, true, "Select");
            Common.FillWareHouses(cmbWareHouse, true, "Select");
            FillGrid(false);
            cmbProducts.SelectedIndexChanged += new EventHandler(cmbProducts_SelectedIndexChanged);
            cmbWareHouse.SelectedIndexChanged += new EventHandler(cmbWareHouse_SelectedIndexChanged);
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid(false);
        }

        private void cmbWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid(false);
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                if (e.KeyChar == '.')
                {
                    if (costTextBox.Text.Contains('.'))
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

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                if (e.KeyChar == '.')
                {
                    if (costTextBox.Text.Contains('.'))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (SaveStock())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (SaveStock())
            {
                ReloadControl();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
