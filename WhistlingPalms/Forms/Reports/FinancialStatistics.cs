using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace WhistlingPalms
{
    public partial class FinancialStatistics : Form
    {
        public FinancialStatistics()
        {
            InitializeComponent();
        }

        #region Helper Methods

        private void FillReport(bool forceReload)
        {
            if (this.ReportsDataSet.TransactionSummary.Rows.Count <= 0 || 
                this.ReportsDataSet.CurrentInventory.Rows.Count <= 0 || forceReload)
            {
                this.TransactionSummaryTableAdapter.Fill(this.ReportsDataSet.TransactionSummary);
                this.CurrentInventoryTableAdapter.Fill(this.ReportsDataSet.CurrentInventory);
            }
            this.TransactionSummaryBindingSource.Filter = GetFilterString();
            this.reportViewer1.RefreshReport();
        }

        private string GetFilterString()
        {
            string strFilter = string.Empty;
                        
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

            return strFilter;
        }

        #endregion

        private void GrossProfit_Load(object sender, EventArgs e)
        {
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
