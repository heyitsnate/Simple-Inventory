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
    public partial class AddNewWareHouse : Form
    {
        private int WareHouseID = 0;
        private bool IsUpdateMode = false;

        public AddNewWareHouse()
        {
            InitializeComponent();
            WareHouseID = 0;
            IsUpdateMode = false;
        }

        public AddNewWareHouse(int iWareHouseID)
        {
            InitializeComponent();
            WareHouseID = iWareHouseID;
            IsUpdateMode = true;
        }

        private void TrimTextBoxes()
        {
            wareHouseNameTextBox.Text = wareHouseNameTextBox.Text.Trim();
            descriptionTextBox.Text = descriptionTextBox.Text.Trim();
            addressTextBox.Text = addressTextBox.Text.Trim();
            telephoneNoTextBox.Text = telephoneNoTextBox.Text.Trim();
        }

        private bool IsWareHouseValid()
        {
            if (wareHouseNameTextBox.Text == null || wareHouseNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ware House Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (wareHouseNameTextBox.Text.Length > 200)
            {
                MessageBox.Show("WareHouse Name cannot be more than 200 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (descriptionTextBox.Text.Length > 1000)
            {
                MessageBox.Show("Description cannot be more than 1000 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addressTextBox.Text.Length > 1000)
            {
                MessageBox.Show("Address cannot be more than 1000 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (telephoneNoTextBox.Text.Length > 20)
            {
                MessageBox.Show("Telephone cannot be more than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SaveWareHouse()
        {
            try
            {
                TrimTextBoxes();
                if (IsWareHouseValid())
                {
                    this.Validate();
                    this.tblWareHouseBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.inventoryStoreDataSet);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("WareHouse insertion failed due to following error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AddNewWareHouse_Load(object sender, EventArgs e)
        {
            this.tblWareHouseTableAdapter.Fill(this.inventoryStoreDataSet.tblWareHouse);
            if (IsUpdateMode)
            {
                this.Text = "Update WareHouse";
                btnSaveAndNew.Visible = false;
                btnSaveAndClose.Text = "&Update";

                int WareHouseIndex = -1;
                if ((WareHouseIndex = this.tblWareHouseBindingSource.Find("WareHouseID", WareHouseID)) >= 0)
                {
                    this.tblWareHouseBindingSource.Position = WareHouseIndex;
                }
            }
            else
            {
                this.Text = "Add New WareHouse";
                this.tblWareHouseBindingSource.AddNew();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (SaveWareHouse())
                this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if(SaveWareHouse())
                this.tblWareHouseBindingSource.AddNew();
        }
    }
}
