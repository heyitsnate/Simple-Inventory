namespace WhistlingPalms
{
    partial class CustomerList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.inventoryStoreDataSet = new WhistlingPalms.InventoryStoreDataSet();
            this.tblClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClientTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.tblClientTableAdapter();
            this.tableAdapterManager = new WhistlingPalms.InventoryStoreDataSetTableAdapters.TableAdapterManager();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblClientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tpTransactions = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKtblClientClientTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTransactionsTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.ClientTransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpAddress.SuspendLayout();
            this.tpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblClientClientTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryStoreDataSet
            // 
            this.inventoryStoreDataSet.DataSetName = "InventoryStoreDataSet";
            this.inventoryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClientBindingSource
            // 
            this.tblClientBindingSource.DataMember = "tblClient";
            this.tblClientBindingSource.DataSource = this.inventoryStoreDataSet;
            // 
            // tblClientTableAdapter
            // 
            this.tblClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblClientTableAdapter = this.tblClientTableAdapter;
            this.tableAdapterManager.tblInventoryTableAdapter = null;
            this.tableAdapterManager.tblProductsTableAdapter = null;
            this.tableAdapterManager.tblTransactionDetailsTableAdapter = null;
            this.tableAdapterManager.tblTransactionStockInformationTableAdapter = null;
            this.tableAdapterManager.tblTransactionTableAdapter = null;
            this.tableAdapterManager.tblTransactionTypeTableAdapter = null;
            this.tableAdapterManager.tblWareHouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WhistlingPalms.InventoryStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tblClientDataGridView);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(846, 437);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // tblClientDataGridView
            // 
            this.tblClientDataGridView.AllowUserToAddRows = false;
            this.tblClientDataGridView.AllowUserToDeleteRows = false;
            this.tblClientDataGridView.AllowUserToOrderColumns = true;
            this.tblClientDataGridView.AutoGenerateColumns = false;
            this.tblClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.EditColumn});
            this.tblClientDataGridView.DataSource = this.tblClientBindingSource;
            this.tblClientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblClientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tblClientDataGridView.Name = "tblClientDataGridView";
            this.tblClientDataGridView.ReadOnly = true;
            this.tblClientDataGridView.RowHeadersVisible = false;
            this.tblClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblClientDataGridView.Size = new System.Drawing.Size(846, 250);
            this.tblClientDataGridView.TabIndex = 0;
            this.tblClientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblClientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Client Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactPerson";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contact Person";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmailID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit/Modify";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditColumn.Text = "Edit";
            this.EditColumn.ToolTipText = "Modify this Customer";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAddress);
            this.tabControl1.Controls.Add(this.tpTransactions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 183);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpAddress
            // 
            this.tpAddress.Controls.Add(this.txtAddress);
            this.tpAddress.Location = new System.Drawing.Point(4, 22);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddress.Size = new System.Drawing.Size(838, 157);
            this.tpAddress.TabIndex = 0;
            this.tpAddress.Text = "Address";
            this.tpAddress.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblClientBindingSource, "Address", true));
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(3, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(832, 151);
            this.txtAddress.TabIndex = 0;
            // 
            // tpTransactions
            // 
            this.tpTransactions.Controls.Add(this.dataGridView1);
            this.tpTransactions.Location = new System.Drawing.Point(4, 22);
            this.tpTransactions.Name = "tpTransactions";
            this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransactions.Size = new System.Drawing.Size(838, 157);
            this.tpTransactions.TabIndex = 1;
            this.tpTransactions.Text = "Transactions";
            this.tpTransactions.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.transactionDetailsDataGridViewTextBoxColumn,
            this.TransactionType,
            this.transactionDateDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKtblClientClientTransactionsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "Order No";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDetailsDataGridViewTextBoxColumn
            // 
            this.transactionDetailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionDetailsDataGridViewTextBoxColumn.DataPropertyName = "TransactionDetails";
            this.transactionDetailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.transactionDetailsDataGridViewTextBoxColumn.Name = "transactionDetailsDataGridViewTextBoxColumn";
            this.transactionDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Width = 120;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Transaction Date";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKtblClientClientTransactionsBindingSource
            // 
            this.fKtblClientClientTransactionsBindingSource.DataMember = "FK_tblClient_ClientTransactions";
            this.fKtblClientClientTransactionsBindingSource.DataSource = this.tblClientBindingSource;
            // 
            // clientTransactionsTableAdapter
            // 
            this.clientTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 437);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerList";
            this.Text = "Customers Listing";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpAddress.ResumeLayout(false);
            this.tpAddress.PerformLayout();
            this.tpTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblClientClientTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventoryStoreDataSet inventoryStoreDataSet;
        private System.Windows.Forms.BindingSource tblClientBindingSource;
        private InventoryStoreDataSetTableAdapters.tblClientTableAdapter tblClientTableAdapter;
        private InventoryStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tblClientDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TabPage tpTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKtblClientClientTransactionsBindingSource;
        private InventoryStoreDataSetTableAdapters.ClientTransactionsTableAdapter clientTransactionsTableAdapter;
    }
}
