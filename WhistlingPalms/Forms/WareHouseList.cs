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
    public partial class WareHouseList : Form
    {
        public WareHouseList()
        {
            InitializeComponent();
        }

        private void WareHouseList_Load(object sender, EventArgs e)
        {
            this.tblWareHouseTableAdapter.Fill(this.inventoryStoreDataSet.tblWareHouse);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tpInventory")
            {
                if (!(this.inventoryStoreDataSet.InventoryDetails.Rows.Count > 0))
                {
                    this.inventoryDetailsTableAdapter.Fill(this.inventoryStoreDataSet.InventoryDetails);
                }
            }            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                DataRowView drv = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
                AddNewWareHouse frm = new AddNewWareHouse(Convert.ToInt32(drv.Row["WareHouseID"]));
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.tblWareHouseTableAdapter.Fill(this.inventoryStoreDataSet.tblWareHouse);
                    //if (this.inventoryStoreDataSet.tblWareHouse.Rows.Count > 0)
                    //{
                    //    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //}
                }
            }
        }
    }
}
