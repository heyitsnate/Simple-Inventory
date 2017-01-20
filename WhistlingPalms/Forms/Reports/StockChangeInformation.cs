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
    public partial class StockChangeInformation : Form
    {
        public StockChangeInformation()
        {
            InitializeComponent();
        }

        #region HelperMethods

        private void FillReport(bool forceReload)
        {
            if (this.reportsDataSet.StockChangeInformation.Rows.Count <= 0 || forceReload)
            {
                this.stockChangeInformationTableAdapter.Fill(this.reportsDataSet.StockChangeInformation);
            }
            this.stockChangeInformationBindingSource.Filter = GetFilterString();
            this.reportViewer1.RefreshReport();
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
                        strFilter = ("(FromWareHouseID = '" + dr.Row["WareHouseID"].ToString() + "' OR ToWareHouseID = '" + dr.Row["WareHouseID"].ToString() + "')");
                    }
                    else
                    {
                        strFilter += (" AND (FromWareHouseID = '" + dr.Row["WareHouseID"].ToString() + "' OR ToWareHouseID = '" + dr.Row["WareHouseID"].ToString() + "')");
                    }
                }
            }

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

        private void StockChangeInformation_Load(object sender, EventArgs e)
        {
            Common.FillProducts(cmbProducts, true, "Select");
            Common.FillWareHouses(cmbWareHouse, true, "Select");
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
