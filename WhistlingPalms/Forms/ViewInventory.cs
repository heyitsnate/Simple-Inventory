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
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        #region HelperMethods

        private void FillGrid(bool forceReload)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.DataSource == null || forceReload)
            {
                InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter adp = new InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter();

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

        #endregion

        #region FormEvents

        private void ViewInventory_Load(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
