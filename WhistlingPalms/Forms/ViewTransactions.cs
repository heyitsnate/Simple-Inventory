using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WhistlingPalms
{
    public partial class ViewTransactions : Form
    {
        public ViewTransactions()
        {
            InitializeComponent();
        }

        #region Helper Methods

        private void FillDataSet()
        {
            int? productID = null;
            int? wareHouseID = null;
            DataRowView dr;

            if (cmbProducts.SelectedItem != null)
            {
                dr = cmbProducts.SelectedItem as DataRowView;
                if (dr != null && dr.Row["ProductID"].ToString() != "0")
                {
                    productID = Int32.Parse(dr.Row["ProductID"].ToString());
                }
            }

            if (cmbWareHouse.SelectedItem != null)
            {
                dr = cmbWareHouse.SelectedItem as DataRowView;
                if (dr != null && dr.Row["WareHouseID"].ToString() != "0")
                {
                    wareHouseID = Int32.Parse(dr.Row["WareHouseID"].ToString());
                }
            }

            this.transactionTableAdapter.FillTransactionsFilteredByProductWareHouse(this.transactionDataSet.Transaction, productID, wareHouseID);
            this.transactionDetailsTableAdapter.Fill(this.transactionDataSet.TransactionDetails);
        }

        private void FillGrid(bool ReloadDataSet)
        {
            if (ReloadDataSet)
                FillDataSet();

            String strFilter = GetFilterString();
            this.transactionBindingSource.Filter = strFilter;
            dgvTransactions.Sort(dgvTransactions.Columns["transactionDateDataGridViewTextBoxColumn"], ListSortDirection.Descending);
        }

        private string GetFilterString()
        {
            string strFilter = string.Empty;
            DataRowView dr;
            
            #region cmbTransactionType
            if (cmbTransactionType.SelectedItem != null)
            {
                dr = cmbTransactionType.SelectedItem as DataRowView;
                if (dr != null && dr.Row["TransactionTypeID"].ToString() != "0")
                {
                    if (strFilter == string.Empty)
                    {
                        strFilter = ("TransactionTypeID = '" + dr.Row["TransactionTypeID"].ToString() + "'");
                    }
                    else
                    {
                        strFilter += (" AND TransactionTypeID = '" + dr.Row["TransactionTypeID"].ToString() + "'");
                    }
                }                
            }
            #endregion

            #region DeadCode to filter based on dates
            //if (dtpFromTransactionDate.Checked)
            //{
            //    if (strFilter == "")
            //        strFilter = "TransactionDate > CONVERT(DateTime, '" + dtpFromTransactionDate.Value.Date.ToString("dd/MM/yyyy") + "', 103)";
            //    else
            //        strFilter += " AND TransactionDate > CONVERT(DateTime, '" + dtpFromTransactionDate.Value.Date.ToString("dd/MM/yyyy") + "', 103)";
            //}

            //if (dtpToTransactionDate.Checked)
            //{
            //    if (strFilter == "")
            //        strFilter = "TransactionDate < CONVERT(DateTime, '" + dtpToTransactionDate.Value.Date.AddDays(1).ToString("dd/MM/yyyy") + "', 103)";
            //    else
            //        strFilter += " AND TransactionDate < CONVERT(DateTime, '" + dtpToTransactionDate.Value.Date.AddDays(1).ToString("dd/MM/yyyy") + "', 103)";
            //}
            //if (dtpFromTransactionDate.Checked)
            //{
            //    if (strFilter == "")
            //        strFilter = "TransactionDate > #" + dtpFromTransactionDate.Value.Date.ToShortDateString() + "#";
            //    else
            //        strFilter += " AND TransactionDate > #" + dtpFromTransactionDate.Value.Date.ToShortDateString() + "#";
            //}

            //if (dtpToTransactionDate.Checked)
            //{
            //    if (strFilter == "")
            //        strFilter = "TransactionDate < #" + dtpToTransactionDate.Value.Date.AddDays(1).ToShortDateString() + "#";
            //    else
            //        strFilter += " AND TransactionDate < #" + dtpToTransactionDate.Value.Date.AddDays(1).ToShortDateString() + "#";
            //}
            #endregion

            #region dtpFromTransactionDate and dtpToTransactionDate

            if (dtpFromTransactionDate.Checked)
            {
                if (strFilter == "")
                    strFilter = String.Format(CultureInfo.InvariantCulture.DateTimeFormat,
                     "TransactionDate >= #{0}#", dtpFromTransactionDate.Value.Date);
                else
                    strFilter += String.Format(CultureInfo.InvariantCulture.DateTimeFormat,
                     " AND TransactionDate >= #{0}#", dtpFromTransactionDate.Value.Date);
            }

            if (dtpToTransactionDate.Checked)
            {
                if (strFilter == "")
                    strFilter = String.Format(CultureInfo.InvariantCulture.DateTimeFormat,
                     "TransactionDate < #{0}#", dtpToTransactionDate.Value.Date.AddDays(1));
                else
                    strFilter += String.Format(CultureInfo.InvariantCulture.DateTimeFormat,
                     " AND TransactionDate < #{0}#", dtpToTransactionDate.Value.Date.AddDays(1));
            }
            #endregion

            #region cmbClient
            
            if (cmbClient.SelectedItem != null)
            {
                dr = cmbClient.SelectedItem as DataRowView;
                if (dr != null && dr.Row["ClientID"].ToString() != "0")
                {
                    if (strFilter == string.Empty)
                    {
                        strFilter = ("ClientID = '" + dr.Row["ClientID"].ToString() + "'");
                    }
                    else
                    {
                        strFilter += (" AND ClientID = '" + dr.Row["ClientID"].ToString() + "'");
                    }
                }
            }

            #endregion

            return strFilter;
        }

        #endregion

        #region FormEvents

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            Common.FillProducts(cmbProducts, true, "Select");
            Common.FillWareHouses(cmbWareHouse, true, "Select");
            Common.FillClients(cmbClient, true, "Select");
            Common.FillTransactionType(cmbTransactionType, true, "Select");

            FillGrid(true);
            
            cmbProducts.SelectedIndexChanged += new EventHandler(ReloadGrid);
            cmbWareHouse.SelectedIndexChanged += new EventHandler(ReloadGrid);
            cmbClient.SelectedIndexChanged +=new EventHandler(UpdateGrid);
            cmbTransactionType.SelectedIndexChanged += new EventHandler(UpdateGrid);
            dtpFromTransactionDate.ValueChanged += new EventHandler(UpdateGrid);
            dtpToTransactionDate.ValueChanged += new EventHandler(UpdateGrid);
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            FillGrid(false);
        }

        private void ReloadGrid(object sender, EventArgs e)
        {
            FillGrid(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow != null && dgvTransactions.CurrentRow.DataBoundItem != null)
            {
                TransactionDataSet.TransactionRow tr = (TransactionDataSet.TransactionRow)((dgvTransactions.CurrentRow.DataBoundItem as DataRowView).Row);
                if (tr.ActionType == WhistlingPalms.ActionType.Addition.ToString() ||
                    tr.ActionType == WhistlingPalms.ActionType.Deduction.ToString())
                {
                    fromWareHouseNameDataGridViewTextBoxColumn.HeaderText = "WareHouse Name";
                    toWareHouseNameDataGridViewTextBoxColumn.Visible = false;
                    transactCostDataGridViewTextBoxColumn.Visible = true;
                    totalCostDataGridViewTextBoxColumn.Visible = true;
                }
                else if (tr.ActionType == WhistlingPalms.ActionType.Transfer.ToString())
                {
                    fromWareHouseNameDataGridViewTextBoxColumn.HeaderText = "From WareHouse";
                    toWareHouseNameDataGridViewTextBoxColumn.Visible = true;
                    transactCostDataGridViewTextBoxColumn.Visible = false;
                    totalCostDataGridViewTextBoxColumn.Visible = false;
                }
            }
        }

        #endregion
    }
}