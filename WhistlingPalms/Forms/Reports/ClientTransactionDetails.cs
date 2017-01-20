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
    public partial class ClientTransactionDetails : Form
    {
        public ClientTransactionDetails()
        {
            InitializeComponent();
        }

        #region Helper Methods

        private void FillReport(bool forceReload)
        {
            if (this.ReportsDataSet.ClientTransactionDetails.Rows.Count <= 0 || forceReload)
            {
                this.ClientTransactionDetailsTableAdapter.Fill(this.ReportsDataSet.ClientTransactionDetails);
            }
            this.ClientTransactionDetailsBindingSource.Filter = GetFilterString();
            this.reportViewer1.RefreshReport();
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

        private void ClientTransactionDetails_Load(object sender, EventArgs e)
        {
            Common.FillClients(cmbClient, true, "Select");
            Common.FillTransactionType(cmbTransactionType, true, "Select");
            FillReport(false);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FillReport(false);
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            FillReport(true);
        }
    }
}
