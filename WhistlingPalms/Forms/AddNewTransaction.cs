using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;

namespace WhistlingPalms
{
    public partial class AddNewTransaction : Form
    {
        public AddNewTransaction()
        {
            InitializeComponent();
        }

        #region Global Variables

        string errorMsg = "";
        string ActionType = "";
        bool HasClientOrderInformation = false;
        UserControl uscTransactionDetails = null;        

        #endregion

        #region Helper Methods

        private bool ValidateTransactionInfo()
        {
            DataRowView dr;
            errorMsg = string.Empty;

            txtTransactionDetails.Text = txtTransactionDetails.Text.Trim();
            txtOrderNo.Text = txtOrderNo.Text.Trim();

            if (txtTransactionDetails.Text == string.Empty)
            {
                errorMsg += "Transaction Details is Required" + Environment.NewLine;
            }
            if (txtTransactionDetails.Text.Length > 1000)
            {
                errorMsg += "Transaction Details cannot be more than 1000 characters" + Environment.NewLine;
            }

            if (cmbTransactionType.SelectedItem != null)
            {
                dr = cmbTransactionType.SelectedItem as DataRowView;
                if (dr != null && dr.Row["TransactionTypeID"].ToString() != "0")
                {
                    HasClientOrderInformation = Convert.ToBoolean(dr.Row["HasClientOrderInformation"]);
                    this.ActionType = dr.Row["ActionType"].ToString();
                }
                else
                {
                    errorMsg += "Transaction Type is Required" + Environment.NewLine;
                }
            }
            else
            {
                errorMsg += "Transaction Type is Required" + Environment.NewLine;
            }

            if (HasClientOrderInformation)
            {
                if (txtOrderNo.Text == string.Empty)
                {
                    errorMsg += "Order No is Required" + Environment.NewLine;
                }
                if (txtOrderNo.Text.Length > 50)
                {
                    errorMsg += "Order No cannot be more than 50 characters" + Environment.NewLine;
                }

                if (cmbClient.SelectedItem != null)
                {
                    dr = cmbClient.SelectedItem as DataRowView;
                    if (!(dr != null && dr.Row["ClientID"].ToString() != "0"))
                    {
                        errorMsg += "Client is Required" + Environment.NewLine;
                    }
                }
                else
                {
                    errorMsg += "Client is Required" + Environment.NewLine;
                }
            }

            if (errorMsg != string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Form Events

        private void AddNewTransaction_Load(object sender, EventArgs e)
        {
            this.Width = 860;
            this.Height = 540;
            flpTransactionInfo.DataBindings.Add("Height", flpContainer, "Height");
            flpTransactionInfo.DataBindings.Add("Width", flpContainer, "Width");
            flpTransactionItemDetails.DataBindings.Add("Height", flpContainer, "Height");
            flpTransactionItemDetails.DataBindings.Add("Width", flpContainer, "Width"); 
            flpTransactionItemDetails.Visible = false;
            flpTransactionInfo.Visible = true;

            Common.FillClients(cmbClient, true, "Select");
            Common.FillTransactionType(cmbTransactionType, true, "Select");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            HasClientOrderInformation = false;
            DataRowView dr;

            if (cmbTransactionType.SelectedItem != null)
            {
                dr = cmbTransactionType.SelectedItem as DataRowView;
                if (dr != null && dr.Row["TransactionTypeID"].ToString() != "0")
                {
                    HasClientOrderInformation = Convert.ToBoolean(dr.Row["HasClientOrderInformation"]);
                    this.ActionType = dr.Row["ActionType"].ToString();
                }
            }

            grpClientInfo.Visible = HasClientOrderInformation;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateTransactionInfo())
            {
                flpTransactionItemDetails.Visible = true;
                flpTransactionInfo.Visible = false;

                if (this.ActionType == WhistlingPalms.ActionType.Addition.ToString())
                {
                    if (uscTransactionDetails == null)
                    {
                        uscTransactionDetails = new uscAddStock();                        
                    }
                }
                else if (this.ActionType == WhistlingPalms.ActionType.Deduction.ToString())
                {
                    if (uscTransactionDetails == null)
                    {
                        uscTransactionDetails = new uscRemoveStock();
                    }
                }
                else if (this.ActionType == WhistlingPalms.ActionType.Transfer.ToString())
                {
                    if (uscTransactionDetails == null)
                    {
                        uscTransactionDetails = new uscTransferStock();
                    }
                }

                pnlTransactionItemDetails.Controls.Clear();
                pnlTransactionItemDetails.Controls.Add(uscTransactionDetails);
                uscTransactionDetails.Focus();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            flpTransactionItemDetails.Visible = false;
            flpTransactionInfo.Visible = true;
            cmbTransactionType.Enabled = false;
        }
        
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (ActionType == WhistlingPalms.ActionType.Addition.ToString())
            {
                try
                {
                    TransactionDataSet ds = ((uscAddStock)uscTransactionDetails).dsTransaction;
                    if (ds.TransactionDetails.Rows.Count <= 0)
                    {
                        MessageBox.Show("Please add atleast one item details for the transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var transactionOptions = new TransactionOptions();
                    transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                    transactionOptions.Timeout = TimeSpan.MaxValue;

                    using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
                    {
                        InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter adpTransaction = new InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter adpTransactionDetails = new InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter adpTransactionStock = new InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adpInventory = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();

                        int? ClientID = null;
                        if((int)cmbClient.SelectedValue > 0) ClientID=(int)cmbClient.SelectedValue;
                        int TransactionID = Convert.ToInt32(adpTransaction.InsertTransaction(txtTransactionDetails.Text.Trim(), dtpTransactionDate.Value, (int)cmbTransactionType.SelectedValue, txtRemarks.Text.Trim(), txtOrderNo.Text.Trim(), ClientID));
                        
                        if (TransactionID > 0)
                        {
                            foreach (TransactionDataSet.TransactionDetailsRow dr in ds.TransactionDetails.Rows)
                            {
                                int? ToWareHouseID = null;
                                if(!dr.IsToWareHouseIDNull()) ToWareHouseID = dr.ToWareHouseID;
                                int TransactionDetailID = Convert.ToInt32(adpTransactionDetails.InsertTransactionDetails(TransactionID, dr.ProductID, dr.FromWareHouseID, ToWareHouseID, dr.TransactQuantity,
                                    dr.TransactCost, dr.TotalCost));
                                
                                if (TransactionDetailID > 0)
                                {
                                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in ds.TransactionStockInformation.Rows)
                                    {
                                        if (tsr.TransactionDetailID == dr.TransactionDetailID)
                                        {
                                            int TransactionStockID = adpTransactionStock.Insert(TransactionDetailID, tsr.Cost, tsr.OldQuantity, tsr.NewQuantity, tsr.IsFromWareHouse);

                                            if (TransactionStockID > 0)
                                            {
                                                int retval;
                                                if (tsr.OldQuantity == 0)
                                                {
                                                    retval = adpInventory.Insert(dr.ProductID, dr.FromWareHouseID, tsr.Cost, tsr.NewQuantity);
                                                }
                                                else
                                                {
                                                    retval = adpInventory.UpdateQuantity(tsr.NewQuantity, dr.ProductID, dr.FromWareHouseID, tsr.Cost);
                                                }

                                                if (retval <= 0)
                                                {
                                                    throw new Exception("Unable to update into Inventory Table");
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to insert into Transaction Stock Change Information");
                                            }
                                        }
                                    }                                  
                                }
                                else
                                {
                                    throw new Exception("Unable to insert into Transaction Details");
                                }
                            }                            
                        }
                        else
                        {
                            throw new Exception("Unable to insert into Transaction Master");
                        }

                        ts.Complete();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Insert Transaction. Error Details:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ActionType == WhistlingPalms.ActionType.Deduction.ToString())
            {
                try
                {
                    TransactionDataSet ds = ((uscRemoveStock)uscTransactionDetails).dsTransaction;
                    if (ds.TransactionDetails.Rows.Count <= 0)
                    {
                        MessageBox.Show("Please add atleast one item details for the transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var transactionOptions = new TransactionOptions();
                    transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                    transactionOptions.Timeout = TimeSpan.MaxValue;

                    using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
                    {
                        InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter adpTransaction = new InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter adpTransactionDetails = new InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter adpTransactionStock = new InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adpInventory = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();

                        int? ClientID = null;
                        if ((int)cmbClient.SelectedValue > 0) ClientID = (int)cmbClient.SelectedValue;
                        int TransactionID = Convert.ToInt32(adpTransaction.InsertTransaction(txtTransactionDetails.Text.Trim(), dtpTransactionDate.Value, (int)cmbTransactionType.SelectedValue, txtRemarks.Text.Trim(), txtOrderNo.Text.Trim(), ClientID));

                        if (TransactionID > 0)
                        {
                            foreach (TransactionDataSet.TransactionDetailsRow dr in ds.TransactionDetails.Rows)
                            {
                                int? ToWareHouseID = null;
                                if (!dr.IsToWareHouseIDNull()) ToWareHouseID = dr.ToWareHouseID;
                                int TransactionDetailID = Convert.ToInt32(adpTransactionDetails.InsertTransactionDetails(TransactionID, dr.ProductID, dr.FromWareHouseID, ToWareHouseID, dr.TransactQuantity,
                                    dr.TransactCost, dr.TotalCost));

                                if (TransactionDetailID > 0)
                                {
                                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in ds.TransactionStockInformation.Rows)
                                    {
                                        if (tsr.TransactionDetailID == dr.TransactionDetailID && tsr.TransactQuantity > 0)
                                        {
                                            int TransactionStockID = adpTransactionStock.Insert(TransactionDetailID, tsr.Cost, tsr.OldQuantity, tsr.NewQuantity, tsr.IsFromWareHouse);

                                            if (TransactionStockID > 0)
                                            {
                                                int retval;
                                                if (tsr.NewQuantity == 0)
                                                {
                                                    retval = adpInventory.DeleteInventoryEntry(dr.ProductID, dr.FromWareHouseID, tsr.Cost);
                                                }
                                                else
                                                {
                                                    retval = adpInventory.UpdateQuantity(tsr.NewQuantity, dr.ProductID, dr.FromWareHouseID, tsr.Cost);
                                                }

                                                if (retval <= 0)
                                                {
                                                    throw new Exception("Unable to update into Inventory Table");
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to insert into Transaction Stock Change Information");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to insert into Transaction Details");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to insert into Transaction Master");
                        }

                        ts.Complete();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Insert Transaction. Error Details:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ActionType == WhistlingPalms.ActionType.Transfer.ToString())
            {
                try
                {
                    TransactionDataSet ds = ((uscTransferStock)uscTransactionDetails).dsTransaction;
                    if (ds.TransactionDetails.Rows.Count <= 0)
                    {
                        MessageBox.Show("Please add atleast one item details for the transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var transactionOptions = new TransactionOptions();
                    transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                    transactionOptions.Timeout = TimeSpan.MaxValue;

                    using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
                    {
                        InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter adpTransaction = new InventoryStoreDataSetTableAdapters.tblTransactionTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter adpTransactionDetails = new InventoryStoreDataSetTableAdapters.tblTransactionDetailsTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter adpTransactionStock = new InventoryStoreDataSetTableAdapters.tblTransactionStockInformationTableAdapter();
                        InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter adpInventory = new InventoryStoreDataSetTableAdapters.tblInventoryTableAdapter();

                        int? ClientID = null;
                        if ((int)cmbClient.SelectedValue > 0) ClientID = (int)cmbClient.SelectedValue;
                        int TransactionID = Convert.ToInt32(adpTransaction.InsertTransaction(txtTransactionDetails.Text.Trim(), dtpTransactionDate.Value, (int)cmbTransactionType.SelectedValue, txtRemarks.Text.Trim(), txtOrderNo.Text.Trim(), ClientID));

                        if (TransactionID > 0)
                        {
                            foreach (TransactionDataSet.TransactionDetailsRow dr in ds.TransactionDetails.Rows)
                            {
                                int? ToWareHouseID = null;
                                decimal? TransactCost = null;
                                decimal? TotalCost = null;

                                if (!dr.IsToWareHouseIDNull()) ToWareHouseID = dr.ToWareHouseID;
                                if (!dr.IsTotalCostNull()) TotalCost = dr.TotalCost;
                                if (!dr.IsTransactCostNull()) TransactCost = dr.TransactCost;

                                int TransactionDetailID = Convert.ToInt32(adpTransactionDetails.InsertTransactionDetails(TransactionID, dr.ProductID, dr.FromWareHouseID, ToWareHouseID, dr.TransactQuantity,
                                    TransactCost, TotalCost));

                                if (TransactionDetailID > 0)
                                {
                                    foreach (TransactionDataSet.TransactionStockInformationRow tsr in ds.TransactionStockInformation.Rows)
                                    {
                                        if (tsr.TransactionDetailID == dr.TransactionDetailID && tsr.TransactQuantity > 0 && tsr.IsFromWareHouse == true)
                                        {
                                            int TransactionStockID = adpTransactionStock.Insert(TransactionDetailID, tsr.Cost, tsr.OldQuantity, tsr.NewQuantity, tsr.IsFromWareHouse);

                                            if (TransactionStockID > 0)
                                            {
                                                int retval;
                                                if (tsr.NewQuantity == 0)
                                                {
                                                    retval = adpInventory.DeleteInventoryEntry(dr.ProductID, dr.FromWareHouseID, tsr.Cost);
                                                }
                                                else
                                                {
                                                    retval = adpInventory.UpdateQuantity(tsr.NewQuantity, dr.ProductID, dr.FromWareHouseID, tsr.Cost);
                                                }

                                                if (retval <= 0)
                                                {
                                                    throw new Exception("Unable to update into Inventory Table");
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to insert into Transaction Stock Change Information");
                                            }
                                        }
                                        else if (tsr.TransactionDetailID == dr.TransactionDetailID && tsr.TransactQuantity > 0 && tsr.IsFromWareHouse == false)
                                        {
                                            int TransactionStockID = adpTransactionStock.Insert(TransactionDetailID, tsr.Cost, tsr.OldQuantity, tsr.NewQuantity, tsr.IsFromWareHouse);

                                            if (TransactionStockID > 0)
                                            {
                                                int retval;
                                                if (tsr.OldQuantity == 0)
                                                {
                                                    retval = adpInventory.Insert(dr.ProductID, dr.ToWareHouseID, tsr.Cost, tsr.NewQuantity);
                                                }
                                                else
                                                {
                                                    retval = adpInventory.UpdateQuantity(tsr.NewQuantity, dr.ProductID, dr.ToWareHouseID, tsr.Cost);
                                                }

                                                if (retval <= 0)
                                                {
                                                    throw new Exception("Unable to update into Inventory Table");
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to insert into Transaction Stock Change Information");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to insert into Transaction Details");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to insert into Transaction Master");
                        }

                        ts.Complete();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Insert Transaction. Error Details:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
