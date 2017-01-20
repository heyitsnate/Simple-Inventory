namespace WhistlingPalms
{
    partial class WareHouseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareHouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareHouseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryStoreDataSet = new WhistlingPalms.InventoryStoreDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDescription = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKInventoryDetailstblWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWareHouseTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter();
            this.inventoryDetailsTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDescription.SuspendLayout();
            this.tpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInventoryDetailstblWareHouseBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(917, 507);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wareHouseIDDataGridViewTextBoxColumn,
            this.wareHouseNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.EditColumn});
            this.dataGridView1.DataSource = this.tblWareHouseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(917, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wareHouseIDDataGridViewTextBoxColumn
            // 
            this.wareHouseIDDataGridViewTextBoxColumn.DataPropertyName = "WareHouseID";
            this.wareHouseIDDataGridViewTextBoxColumn.HeaderText = "WareHouseID";
            this.wareHouseIDDataGridViewTextBoxColumn.Name = "wareHouseIDDataGridViewTextBoxColumn";
            this.wareHouseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wareHouseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // wareHouseNameDataGridViewTextBoxColumn
            // 
            this.wareHouseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "WareHouseName";
            this.wareHouseNameDataGridViewTextBoxColumn.HeaderText = "WareHouse Name";
            this.wareHouseNameDataGridViewTextBoxColumn.Name = "wareHouseNameDataGridViewTextBoxColumn";
            this.wareHouseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "Telephone No";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit/Modify";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Text = "Edit";
            this.EditColumn.ToolTipText = "Modify this WareHouse";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // tblWareHouseBindingSource
            // 
            this.tblWareHouseBindingSource.DataMember = "tblWareHouse";
            this.tblWareHouseBindingSource.DataSource = this.inventoryStoreDataSet;
            // 
            // inventoryStoreDataSet
            // 
            this.inventoryStoreDataSet.DataSetName = "InventoryStoreDataSet";
            this.inventoryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDescription);
            this.tabControl1.Controls.Add(this.tpInventory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 253);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpDescription
            // 
            this.tpDescription.Controls.Add(this.txtDescription);
            this.tpDescription.Location = new System.Drawing.Point(4, 22);
            this.tpDescription.Name = "tpDescription";
            this.tpDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescription.Size = new System.Drawing.Size(909, 227);
            this.tpDescription.TabIndex = 0;
            this.tpDescription.Text = "Description";
            this.tpDescription.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWareHouseBindingSource, "Description", true));
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(903, 221);
            this.txtDescription.TabIndex = 0;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.dataGridView2);
            this.tpInventory.Location = new System.Drawing.Point(4, 22);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(909, 227);
            this.tpInventory.TabIndex = 1;
            this.tpInventory.Text = "Inventory";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKInventoryDetailstblWareHouseBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(903, 221);
            this.dataGridView2.TabIndex = 0;
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
            // fKInventoryDetailstblWareHouseBindingSource
            // 
            this.fKInventoryDetailstblWareHouseBindingSource.DataMember = "FK_InventoryDetails_tblWareHouse";
            this.fKInventoryDetailstblWareHouseBindingSource.DataSource = this.tblWareHouseBindingSource;
            // 
            // tblWareHouseTableAdapter
            // 
            this.tblWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDetailsTableAdapter
            // 
            this.inventoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // WareHouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 507);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WareHouseList";
            this.Text = "WareHouses Listing";
            this.Load += new System.EventHandler(this.WareHouseList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDescription.ResumeLayout(false);
            this.tpDescription.PerformLayout();
            this.tpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInventoryDetailstblWareHouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InventoryStoreDataSet inventoryStoreDataSet;
        private System.Windows.Forms.BindingSource tblWareHouseBindingSource;
        private InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter tblWareHouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKInventoryDetailstblWareHouseBindingSource;
        private InventoryStoreDataSetTableAdapters.InventoryDetailsTableAdapter inventoryDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}