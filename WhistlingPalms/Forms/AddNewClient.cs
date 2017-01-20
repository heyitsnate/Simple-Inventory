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
    public partial class AddNewClient : Form
    {
        private int ClientID = 0;
        private bool IsUpdateMode = false;
        InventoryStoreDataSetTableAdapters.tblClientTableAdapter taClients = new InventoryStoreDataSetTableAdapters.tblClientTableAdapter();
        InventoryStoreDataSet.tblClientRow trClientsRow;

        public AddNewClient()
        {
            InitializeComponent();
            ClientID = 0;
            IsUpdateMode = false;
        }

        public AddNewClient(int iClientID)
        {
            InitializeComponent();
            ClientID = iClientID;
            IsUpdateMode = true;

            InventoryStoreDataSet.tblClientDataTable dt = taClients.GetClientByID(ClientID);
            if (dt.Rows.Count > 0)
            {
                trClientsRow = dt.Rows[0] as InventoryStoreDataSet.tblClientRow;
            }
        }

        #region "Helper Methods"

        private bool IsClientValid()
        {
            if (clientNameTextBox.Text == string.Empty || clientNameTextBox.Text == null)
            {
                MessageBox.Show("Client Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clientNameTextBox.Text.Length > 200)
            {
                MessageBox.Show("Client Name cannot be more than 200 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contactPersonTextBox.Text.Length > 200)
            {
                MessageBox.Show("Contact Person Name cannot be more than 200 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contactNoTextBox.Text.Length > 20)
            {
                MessageBox.Show("Contact Number cannot be more than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addressTextBox.Text.Length > 1000)
            {
                MessageBox.Show("Address cannot be more than 1000 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (emailIDTextBox.Text.Length > 200)
            {
                MessageBox.Show("Email ID cannot be more than 200 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
 
            if(emailIDTextBox.Text != String.Empty)
            {
                if(!System.Text.RegularExpressions.Regex.IsMatch(emailIDTextBox.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    MessageBox.Show("Email ID is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            

            if (isCustomerCheckBox.Checked == false && isVendorCheckBox.Checked == false)
            {
                MessageBox.Show("Client needs to be either customer or vendor." + Environment.NewLine +
                    "Please select appropriate tick box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void TrimTextBoxes()
        {
            clientNameTextBox.Text = clientNameTextBox.Text.Trim();
            contactPersonTextBox.Text = contactPersonTextBox.Text.Trim();
            contactNoTextBox.Text = contactNoTextBox.Text.Trim();
            addressTextBox.Text = addressTextBox.Text.Trim();
            emailIDTextBox.Text = emailIDTextBox.Text.Trim();
        }

        private void ResetForm()
        {
            clientNameTextBox.Text = "";
            contactPersonTextBox.Text = "";
            contactNoTextBox.Text = "";
            addressTextBox.Text = "";
            emailIDTextBox.Text = "";
            isVendorCheckBox.Checked = false;
            isCustomerCheckBox.Checked = false;
        }

        private bool SaveClient()
        {
            try
            {
                TrimTextBoxes();
                if (IsClientValid())
                {
                    if (IsUpdateMode)
                    {
                        if (taClients.Update(trClientsRow) > 0)
                        {
                            MessageBox.Show("Client updated successfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Client Updation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        if (taClients.Insert(clientNameTextBox.Text, contactNoTextBox.Text, contactPersonTextBox.Text,
                            addressTextBox.Text, emailIDTextBox.Text, isVendorCheckBox.Checked, isCustomerCheckBox.Checked) > 0)
                        {
                            MessageBox.Show("Client inserted successfully", "Client Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Client insertion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client insertion failed due to following error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        private void AddNewClient_Load(object sender, EventArgs e)
        {
            if (IsUpdateMode)
            {
                this.Text = "Update Client";
                btnSaveAndNew.Visible = false;
                btnSaveAndClose.Text = "&Update";

                clientNameTextBox.DataBindings.Add("Text", trClientsRow, "ClientName");
                contactPersonTextBox.DataBindings.Add("Text", trClientsRow, "ContactPerson");
                contactNoTextBox.DataBindings.Add("Text", trClientsRow, "ContactNo");
                addressTextBox.DataBindings.Add("Text", trClientsRow, "Address");
                emailIDTextBox.DataBindings.Add("Text", trClientsRow, "EmailID");
                isVendorCheckBox.DataBindings.Add("Checked", trClientsRow, "IsVendor");
                isCustomerCheckBox.DataBindings.Add("Checked", trClientsRow, "IsCustomer");
            }
            else
            {
                this.Text = "Add New Product";
            }
            clientNameTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (SaveClient())
                this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (SaveClient())
                ResetForm();
        }        
    }
}
