namespace WhistlingPalms
{
    partial class ViewTransactionType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactionType));
            this.dgvTransactionType = new System.Windows.Forms.DataGridView();
            this.transactionTypeIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasClientOrderInformationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblTransactionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryStoreDataSet = new WhistlingPalms.InventoryStoreDataSet();
            this.tblTransactionTypeTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionType
            // 
            this.dgvTransactionType.AllowUserToAddRows = false;
            this.dgvTransactionType.AllowUserToDeleteRows = false;
            this.dgvTransactionType.AutoGenerateColumns = false;
            this.dgvTransactionType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionTypeIDColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.actionTypeDataGridViewTextBoxColumn,
            this.hasClientOrderInformationColumn,
            this.EditColumn});
            this.dgvTransactionType.DataSource = this.tblTransactionTypeBindingSource;
            this.dgvTransactionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactionType.Location = new System.Drawing.Point(0, 0);
            this.dgvTransactionType.Name = "dgvTransactionType";
            this.dgvTransactionType.ReadOnly = true;
            this.dgvTransactionType.Size = new System.Drawing.Size(655, 196);
            this.dgvTransactionType.TabIndex = 0;
            this.dgvTransactionType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionType_CellContentClick);
            this.dgvTransactionType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTransactionType_CellFormatting);
            // 
            // transactionTypeIDColumn
            // 
            this.transactionTypeIDColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDColumn.HeaderText = "TransactionTypeID";
            this.transactionTypeIDColumn.Name = "transactionTypeIDColumn";
            this.transactionTypeIDColumn.ReadOnly = true;
            this.transactionTypeIDColumn.Visible = false;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            this.actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.HeaderText = "Action Type";
            this.actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            this.actionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasClientOrderInformationColumn
            // 
            this.hasClientOrderInformationColumn.DataPropertyName = "HasClientOrderInformation";
            this.hasClientOrderInformationColumn.HeaderText = "Has Client Order Information";
            this.hasClientOrderInformationColumn.Name = "hasClientOrderInformationColumn";
            this.hasClientOrderInformationColumn.ReadOnly = true;
            this.hasClientOrderInformationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hasClientOrderInformationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hasClientOrderInformationColumn.Width = 150;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Text = "Edit";
            this.EditColumn.UseColumnTextForButtonValue = true;
            this.EditColumn.Width = 50;
            // 
            // tblTransactionTypeBindingSource
            // 
            this.tblTransactionTypeBindingSource.DataMember = "tblTransactionType";
            this.tblTransactionTypeBindingSource.DataSource = this.inventoryStoreDataSet;
            // 
            // inventoryStoreDataSet
            // 
            this.inventoryStoreDataSet.DataSetName = "InventoryStoreDataSet";
            this.inventoryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransactionTypeTableAdapter
            // 
            this.tblTransactionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 196);
            this.Controls.Add(this.dgvTransactionType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTransactionType";
            this.Text = "TransactionType";
            this.Load += new System.EventHandler(this.ViewTransactionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionType;
        private InventoryStoreDataSet inventoryStoreDataSet;
        private System.Windows.Forms.BindingSource tblTransactionTypeBindingSource;
        private InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter tblTransactionTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasClientOrderInformationColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
    }
}