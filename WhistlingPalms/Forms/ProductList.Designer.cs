namespace WhistlingPalms
{
    partial class ProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            this.inventoryStoreDataSet = new WhistlingPalms.InventoryStoreDataSet();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductsTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.tblProductsTableAdapter();
            this.tableAdapterManager = new WhistlingPalms.InventoryStoreDataSetTableAdapters.TableAdapterManager();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDescription = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareHouseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKInventoryDetailstblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDetailsTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDescription.SuspendLayout();
            this.tpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInventoryDetailstblProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryStoreDataSet
            // 
            this.inventoryStoreDataSet.DataSetName = "InventoryStoreDataSet";
            this.inventoryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.inventoryStoreDataSet;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblClientTableAdapter = null;
            this.tableAdapterManager.tblInventoryTableAdapter = null;
            this.tableAdapterManager.tblProductsTableAdapter = this.tblProductsTableAdapter;
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
            this.splitContainer1.Panel1.Controls.Add(this.tblProductsDataGridView);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(909, 499);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 2;
            // 
            // tblProductsDataGridView
            // 
            this.tblProductsDataGridView.AllowUserToAddRows = false;
            this.tblProductsDataGridView.AllowUserToDeleteRows = false;
            this.tblProductsDataGridView.AllowUserToOrderColumns = true;
            this.tblProductsDataGridView.AutoGenerateColumns = false;
            this.tblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.EditColumn});
            this.tblProductsDataGridView.DataSource = this.tblProductsBindingSource;
            this.tblProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProductsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tblProductsDataGridView.Name = "tblProductsDataGridView";
            this.tblProductsDataGridView.ReadOnly = true;
            this.tblProductsDataGridView.RowHeadersVisible = false;
            this.tblProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductsDataGridView.Size = new System.Drawing.Size(909, 210);
            this.tblProductsDataGridView.TabIndex = 0;
            this.tblProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProductsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductTag1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tag1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProductTag2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tag2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn11.HeaderText = "Sale Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit/Modify";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Text = "Edit";
            this.EditColumn.ToolTipText = "Modify Product";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDescription);
            this.tabControl1.Controls.Add(this.tpInventory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 285);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpDescription
            // 
            this.tpDescription.Controls.Add(this.textBox1);
            this.tpDescription.Location = new System.Drawing.Point(4, 22);
            this.tpDescription.Name = "tpDescription";
            this.tpDescription.Size = new System.Drawing.Size(901, 259);
            this.tpDescription.TabIndex = 4;
            this.tpDescription.Text = "Description";
            this.tpDescription.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductsBindingSource, "Description", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(901, 259);
            this.textBox1.TabIndex = 0;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.dataGridView1);
            this.tpInventory.Location = new System.Drawing.Point(4, 22);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(901, 259);
            this.tpInventory.TabIndex = 0;
            this.tpInventory.Text = "Inventory";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareHouseNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKInventoryDetailstblProductsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // wareHouseNameDataGridViewTextBoxColumn
            // 
            this.wareHouseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "WareHouseName";
            this.wareHouseNameDataGridViewTextBoxColumn.HeaderText = "WareHouse Name";
            this.wareHouseNameDataGridViewTextBoxColumn.Name = "wareHouseNameDataGridViewTextBoxColumn";
            this.wareHouseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKInventoryDetailstblProductsBindingSource
            // 
            this.fKInventoryDetailstblProductsBindingSource.DataMember = "FK_InventoryDetails_tblProducts";
            this.fKInventoryDetailstblProductsBindingSource.DataSource = this.tblProductsBindingSource;
            // 
            // inventoryDetailsTableAdapter
            // 
            this.inventoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 499);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductList";
            this.Text = "Products Listing";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDescription.ResumeLayout(false);
            this.tpDescription.PerformLayout();
            this.tpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInventoryDetailstblProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventoryStoreDataSet inventoryStoreDataSet;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private InventoryStoreDataSetTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private InventoryStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tblProductsDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.BindingSource fKInventoryDetailstblProductsBindingSource;
        private InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter inventoryDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}
