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
    public partial class CurrentInventory : Form
    {
        public CurrentInventory()
        {
            InitializeComponent();
        }

        #region HelperMethods

        private void FillReport(bool forceReload)
        {
            if (this.ReportsDataSet.CurrentInventory.Rows.Count <= 0 || forceReload)
            {
                this.CurrentInventoryTableAdapter.Fill(this.ReportsDataSet.CurrentInventory);
            }
            this.CurrentInventoryBindingSource.Filter = GetFilterString();
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

        #endregion

        private void ReportCurrentInventory_Load(object sender, EventArgs e)
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
