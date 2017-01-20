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
    public partial class ViewTransactionType : Form
    {
        public ViewTransactionType()
        {
            InitializeComponent();
        }

        //#region Helper Methods
        //private void FillGrid()
        //{ 
        //    //InventoryStoreDataSet.tblTransactionTypeDataTable
        //}
        //#endregion

        //#region Form Events
        //private void ViewTransactionType_Load(object sender, EventArgs e)
        //{
        //    FillGrid();
        //}
        //#endregion

        private void ViewTransactionType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryStoreDataSet.tblTransactionType' table. You can move, or remove it, as needed.
            this.tblTransactionTypeTableAdapter.Fill(this.inventoryStoreDataSet.tblTransactionType);
        }

        private void dgvTransactionType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (dgvTransactionType.Columns[e.ColumnIndex].Name)
            {
                case "hasClientOrderInformationColumn":
                    Boolean boolVal;
                    if(e.Value !=null && Boolean.TryParse(e.Value.ToString(), out boolVal))
                    {
                        if (boolVal == true)
                        {
                            e.Value = "Yes";
                        }
                        else
                        {
                            e.Value = "No";
                        }
                    }
                    break;
            }
        }

        private void dgvTransactionType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransactionType.Columns[e.ColumnIndex].Name == "EditColumn" && e.RowIndex >= 0)
            {
                AddEditTransactionType frm = new AddEditTransactionType(dgvTransactionType.Rows[e.RowIndex].Cells["transactionTypeIDColumn"].Value.ToString());
                frm.ShowDialog();
                this.tblTransactionTypeTableAdapter.Fill(this.inventoryStoreDataSet.tblTransactionType);
                //dgvTransactionType.Refresh();
            }
        }
    }
}
