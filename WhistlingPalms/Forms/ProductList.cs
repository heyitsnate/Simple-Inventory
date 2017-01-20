using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhistlingPalms
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            this.tblProductsTableAdapter.FillActiveProducts(this.inventoryStoreDataSet.tblProducts);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tpInventory":
                    if (!(this.inventoryStoreDataSet.InventoryDetails.Rows.Count > 0))
                    {
                        this.inventoryDetailsTableAdapter.Fill(this.inventoryStoreDataSet.InventoryDetails);
                    }
                    break;
            }
        }

        private void tblProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tblProductsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                DataRowView drv = tblProductsDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView;
                AddNewProduct frm = new AddNewProduct(Convert.ToInt32(drv.Row["ProductID"]));
                frm.StartPosition = FormStartPosition.CenterParent;
                switch (frm.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        this.tblProductsTableAdapter.FillActiveProducts(this.inventoryStoreDataSet.tblProducts);
                        break;
                    //if (this.inventoryStoreDataSet.tblProducts.Rows.Count > 0)
                    //{
                    //    tblProductsDataGridView.CurrentCell = tblProductsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //}
                }
            }
        }        
    }
}
