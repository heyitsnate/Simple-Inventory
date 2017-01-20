namespace WhistlingPalms
{
    partial class ViewTransactions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label wareHouseIDLabel;
            System.Windows.Forms.Label lblClient;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactions));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.transactionDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDataSet = new WhistlingPalms.TransactionDataSet();
            this.dtpToTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromTransactionDate = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWareHouse = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTransactionDetails = new System.Windows.Forms.GroupBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromWareHouseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toWareHouseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTransactionTransactionDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableAdapter = new WhistlingPalms.TransactionDataSetTableAdapters.TransactionTableAdapter();
            this.transactionDetailsTableAdapter = new WhistlingPalms.TransactionDataSetTableAdapters.TransactionDetailsTableAdapter();
            productIDLabel = new System.Windows.Forms.Label();
            wareHouseIDLabel = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).BeginInit();
            this.grpTransactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransactionTransactionDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(77, 23);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(47, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product:";
            // 
            // wareHouseIDLabel
            // 
            wareHouseIDLabel.AutoSize = true;
            wareHouseIDLabel.Location = new System.Drawing.Point(54, 56);
            wareHouseIDLabel.Name = "wareHouseIDLabel";
            wareHouseIDLabel.Size = new System.Drawing.Size(70, 13);
            wareHouseIDLabel.TabIndex = 2;
            wareHouseIDLabel.Text = "Ware House:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new System.Drawing.Point(85, 89);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(39, 13);
            lblClient.TabIndex = 8;
            lblClient.Text = "Client: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTransactions);
            this.groupBox2.Controls.Add(this.dtpToTransactionDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFromTransactionDate);
            this.groupBox2.Controls.Add(this.lblFromTransactionDate);
            this.groupBox2.Controls.Add(this.cmbTransactionType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbWareHouse);
            this.groupBox2.Controls.Add(lblClient);
            this.groupBox2.Controls.Add(productIDLabel);
            this.groupBox2.Controls.Add(this.cmbClient);
            this.groupBox2.Controls.Add(this.cmbProducts);
            this.groupBox2.Controls.Add(wareHouseIDLabel);
            this.groupBox2.Location = new System.Drawing.Point(14, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 327);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoGenerateColumns = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionDetailsDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn});
            this.dgvTransactions.DataSource = this.transactionBindingSource;
            this.dgvTransactions.Location = new System.Drawing.Point(29, 159);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(852, 150);
            this.dgvTransactions.TabIndex = 14;
            this.dgvTransactions.SelectionChanged += new System.EventHandler(this.dgvTransactions_SelectionChanged);
            // 
            // transactionDetailsDataGridViewTextBoxColumn
            // 
            this.transactionDetailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionDetailsDataGridViewTextBoxColumn.DataPropertyName = "TransactionDetails";
            this.transactionDetailsDataGridViewTextBoxColumn.HeaderText = "Transaction Details";
            this.transactionDetailsDataGridViewTextBoxColumn.Name = "transactionDetailsDataGridViewTextBoxColumn";
            this.transactionDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Transaction Date";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "Order No";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.transactionDataSet;
            // 
            // transactionDataSet
            // 
            this.transactionDataSet.DataSetName = "TransactionDataSet";
            this.transactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpToTransactionDate
            // 
            this.dtpToTransactionDate.Checked = false;
            this.dtpToTransactionDate.Location = new System.Drawing.Point(455, 116);
            this.dtpToTransactionDate.Name = "dtpToTransactionDate";
            this.dtpToTransactionDate.ShowCheckBox = true;
            this.dtpToTransactionDate.Size = new System.Drawing.Size(138, 20);
            this.dtpToTransactionDate.TabIndex = 13;
            this.dtpToTransactionDate.ValueChanged += new System.EventHandler(this.UpdateGrid);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To Transaction Date:";
            // 
            // dtpFromTransactionDate
            // 
            this.dtpFromTransactionDate.Checked = false;
            this.dtpFromTransactionDate.Location = new System.Drawing.Point(130, 116);
            this.dtpFromTransactionDate.Name = "dtpFromTransactionDate";
            this.dtpFromTransactionDate.ShowCheckBox = true;
            this.dtpFromTransactionDate.Size = new System.Drawing.Size(132, 20);
            this.dtpFromTransactionDate.TabIndex = 11;
            this.dtpFromTransactionDate.ValueChanged += new System.EventHandler(this.UpdateGrid);
            // 
            // lblFromTransactionDate
            // 
            this.lblFromTransactionDate.AutoSize = true;
            this.lblFromTransactionDate.Location = new System.Drawing.Point(6, 122);
            this.lblFromTransactionDate.Name = "lblFromTransactionDate";
            this.lblFromTransactionDate.Size = new System.Drawing.Size(118, 13);
            this.lblFromTransactionDate.TabIndex = 10;
            this.lblFromTransactionDate.Text = "From Transaction Date:";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(599, 53);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(282, 21);
            this.cmbTransactionType.TabIndex = 5;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.UpdateGrid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transaction Type:";
            // 
            // cmbWareHouse
            // 
            this.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWareHouse.FormattingEnabled = true;
            this.cmbWareHouse.Location = new System.Drawing.Point(130, 53);
            this.cmbWareHouse.Name = "cmbWareHouse";
            this.cmbWareHouse.Size = new System.Drawing.Size(319, 21);
            this.cmbWareHouse.TabIndex = 3;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(130, 86);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(751, 21);
            this.cmbClient.TabIndex = 9;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.UpdateGrid);
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(130, 20);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(751, 21);
            this.cmbProducts.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(820, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpTransactionDetails
            // 
            this.grpTransactionDetails.Controls.Add(this.dgvTransactionDetails);
            this.grpTransactionDetails.Location = new System.Drawing.Point(14, 343);
            this.grpTransactionDetails.Name = "grpTransactionDetails";
            this.grpTransactionDetails.Size = new System.Drawing.Size(897, 193);
            this.grpTransactionDetails.TabIndex = 1;
            this.grpTransactionDetails.TabStop = false;
            this.grpTransactionDetails.Text = "Transaction Details";
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.AllowUserToAddRows = false;
            this.dgvTransactionDetails.AllowUserToDeleteRows = false;
            this.dgvTransactionDetails.AllowUserToOrderColumns = true;
            this.dgvTransactionDetails.AutoGenerateColumns = false;
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.fromWareHouseNameDataGridViewTextBoxColumn,
            this.toWareHouseNameDataGridViewTextBoxColumn,
            this.transactQuantityDataGridViewTextBoxColumn,
            this.transactCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dgvTransactionDetails.DataSource = this.fKTransactionTransactionDetailsBindingSource;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(29, 21);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.ReadOnly = true;
            this.dgvTransactionDetails.RowHeadersVisible = false;
            this.dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(852, 166);
            this.dgvTransactionDetails.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromWareHouseNameDataGridViewTextBoxColumn
            // 
            this.fromWareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "FromWareHouseName";
            this.fromWareHouseNameDataGridViewTextBoxColumn.HeaderText = "From WareHouse";
            this.fromWareHouseNameDataGridViewTextBoxColumn.Name = "fromWareHouseNameDataGridViewTextBoxColumn";
            this.fromWareHouseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromWareHouseNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // toWareHouseNameDataGridViewTextBoxColumn
            // 
            this.toWareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "ToWareHouseName";
            this.toWareHouseNameDataGridViewTextBoxColumn.HeaderText = "To WareHouse";
            this.toWareHouseNameDataGridViewTextBoxColumn.Name = "toWareHouseNameDataGridViewTextBoxColumn";
            this.toWareHouseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.toWareHouseNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // transactQuantityDataGridViewTextBoxColumn
            // 
            this.transactQuantityDataGridViewTextBoxColumn.DataPropertyName = "TransactQuantity";
            this.transactQuantityDataGridViewTextBoxColumn.HeaderText = "Transact Qty";
            this.transactQuantityDataGridViewTextBoxColumn.Name = "transactQuantityDataGridViewTextBoxColumn";
            this.transactQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactCostDataGridViewTextBoxColumn
            // 
            this.transactCostDataGridViewTextBoxColumn.DataPropertyName = "TransactCost";
            this.transactCostDataGridViewTextBoxColumn.HeaderText = "Transact Cost";
            this.transactCostDataGridViewTextBoxColumn.Name = "transactCostDataGridViewTextBoxColumn";
            this.transactCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKTransactionTransactionDetailsBindingSource
            // 
            this.fKTransactionTransactionDetailsBindingSource.DataMember = "FK_Transaction_TransactionDetails";
            this.fKTransactionTransactionDetailsBindingSource.DataSource = this.transactionBindingSource;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // transactionDetailsTableAdapter
            // 
            this.transactionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 572);
            this.Controls.Add(this.grpTransactionDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Load += new System.EventHandler(this.ViewTransactions_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).EndInit();
            this.grpTransactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransactionTransactionDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWareHouse;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFromTransactionDate;
        private System.Windows.Forms.DateTimePicker dtpFromTransactionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToTransactionDate;
        private System.Windows.Forms.GroupBox grpTransactionDetails;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.ComboBox cmbClient;        
        private System.Windows.Forms.DataGridView dgvTransactions;
        private TransactionDataSet transactionDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private TransactionDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKTransactionTransactionDetailsBindingSource;
        private TransactionDataSetTableAdapters.TransactionDetailsTableAdapter transactionDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromWareHouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toWareHouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;

    }
}