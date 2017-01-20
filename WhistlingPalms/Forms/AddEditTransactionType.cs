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
    public partial class AddEditTransactionType : Form
    {
        InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter();
        InventoryStoreDataSet.tblTransactionTypeRow dr;
        Int32 transactionTypeID;
        string errorMsg = string.Empty;
        bool Flag = true, IsUpdateMode = false;

        public AddEditTransactionType()
        {
            InitializeComponent();
        }

        public AddEditTransactionType(string transTypeID)
        {
            InitializeComponent();
            transactionTypeID = Convert.ToInt32(transTypeID);
        }

        #region Helper Methods

        private void LoadData()
        {
            InventoryStoreDataSet.tblTransactionTypeDataTable dt = adp.GetDataByTransactionTypeID(transactionTypeID);
            if (dt.Rows.Count > 0)
            {
                dr = (InventoryStoreDataSet.tblTransactionTypeRow)dt.Rows[0];
                txtTransactionType.Text = dr.TransactionType;
                cmbActionType.SelectedItem = (WhistlingPalms.ActionType)Enum.Parse(typeof(WhistlingPalms.ActionType), dr.ActionType);
                chkHasCustomerInformation.Checked = dr.HasClientOrderInformation;
            }
            btnAdd.Text = "Update";
        }

        private void FillActionTypeCheckBox()
        {
            //foreach (WhistlingPalms.ActionType at in WhistlingPalms.ActionType)
            //{
            //    cmbActionType.Items.Add(at.ToString());
            //}
            cmbActionType.DataSource = Enum.GetValues(typeof(WhistlingPalms.ActionType));
        }

        private bool IsDataValid()
        {
            if (txtTransactionType.Text == string.Empty || txtTransactionType.Text == null)
            {
                errorMsg += "Transaction Type Is Required." + Environment.NewLine;
                Flag = false;
            }

            if (Flag == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool SaveTransactionType()
        {
            try
            {
                if (IsDataValid())
                {
                    
                    if (IsUpdateMode == true)
                    {
                        dr.TransactionType = txtTransactionType.Text.Trim();
                        dr.ActionType = cmbActionType.SelectedItem.ToString();
                        dr.HasClientOrderInformation = chkHasCustomerInformation.Checked;
                        if (adp.Update(dr) > 0)
                        {
                            MessageBox.Show("Transaction Type updated successfully", "Transaction Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Transaction Type Updation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        if (adp.Insert(txtTransactionType.Text.Trim(), cmbActionType.SelectedItem.ToString(), chkHasCustomerInformation.Checked) > 0)
                        {

                            MessageBox.Show("TransactionType inserted successfully", "Transaction Type Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Transaction Type insertion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Form Events

        private void AddEditTransactionType_Load(object sender, EventArgs e)
        {
            FillActionTypeCheckBox();
            if (transactionTypeID > 0)
            {
                IsUpdateMode = true;
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SaveTransactionType())
            {
                this.Close();
            }
        }

        #endregion
    }
}
