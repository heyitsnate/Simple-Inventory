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
    public partial class VendorList : Form
    {
        public VendorList()
        {
            InitializeComponent();
        }
        
        private void VendorList_Load(object sender, EventArgs e)
        {
            this.tblClientTableAdapter.FillVendors(this.inventoryStoreDataSet.tblClient);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tpTransactions":
                    if (!(this.inventoryStoreDataSet.ClientTransactions.Rows.Count > 0))
                    {
                        this.clientTransactionsTableAdapter.Fill(this.inventoryStoreDataSet.ClientTransactions);
                    }
                    break;
            }
        }

        private void tblClientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tblClientDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                DataRowView drv = tblClientDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView;
                AddNewClient frm = new AddNewClient(Convert.ToInt32(drv.Row["ClientID"]));
                frm.StartPosition = FormStartPosition.CenterParent;
                switch (frm.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        this.tblClientTableAdapter.FillVendors(this.inventoryStoreDataSet.tblClient);
                        break;
                    //tblClientDataGridView.CurrentCell = tblClientDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }
    }
}
