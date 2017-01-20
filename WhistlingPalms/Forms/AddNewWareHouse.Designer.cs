namespace WhistlingPalms
{
    partial class AddNewWareHouse
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
            System.Windows.Forms.Label wareHouseNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telephoneNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWareHouse));
            this.inventoryStoreDataSet = new WhistlingPalms.InventoryStoreDataSet();
            this.tblWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWareHouseTableAdapter = new WhistlingPalms.InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter();
            this.tableAdapterManager = new WhistlingPalms.InventoryStoreDataSetTableAdapters.TableAdapterManager();
            this.wareHouseNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNoTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            wareHouseNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telephoneNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWareHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wareHouseNameLabel
            // 
            wareHouseNameLabel.AutoSize = true;
            wareHouseNameLabel.Location = new System.Drawing.Point(12, 15);
            wareHouseNameLabel.Name = "wareHouseNameLabel";
            wareHouseNameLabel.Size = new System.Drawing.Size(101, 13);
            wareHouseNameLabel.TabIndex = 0;
            wareHouseNameLabel.Text = "Ware House Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 147);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // telephoneNoLabel
            // 
            telephoneNoLabel.AutoSize = true;
            telephoneNoLabel.Location = new System.Drawing.Point(12, 253);
            telephoneNoLabel.Name = "telephoneNoLabel";
            telephoneNoLabel.Size = new System.Drawing.Size(78, 13);
            telephoneNoLabel.TabIndex = 6;
            telephoneNoLabel.Text = "Telephone No:";
            // 
            // inventoryStoreDataSet
            // 
            this.inventoryStoreDataSet.DataSetName = "InventoryStoreDataSet";
            this.inventoryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWareHouseBindingSource
            // 
            this.tblWareHouseBindingSource.DataMember = "tblWareHouse";
            this.tblWareHouseBindingSource.DataSource = this.inventoryStoreDataSet;
            // 
            // tblWareHouseTableAdapter
            // 
            this.tblWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblClientTableAdapter = null;
            this.tableAdapterManager.tblInventoryTableAdapter = null;
            this.tableAdapterManager.tblProductsTableAdapter = null;
            this.tableAdapterManager.tblTransactionDetailsTableAdapter = null;
            this.tableAdapterManager.tblTransactionStockInformationTableAdapter = null;
            this.tableAdapterManager.tblTransactionTableAdapter = null;
            this.tableAdapterManager.tblTransactionTypeTableAdapter = null;
            this.tableAdapterManager.tblWareHouseTableAdapter = this.tblWareHouseTableAdapter;
            this.tableAdapterManager.UpdateOrder = WhistlingPalms.InventoryStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // wareHouseNameTextBox
            // 
            this.wareHouseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWareHouseBindingSource, "WareHouseName", true));
            this.wareHouseNameTextBox.Location = new System.Drawing.Point(119, 12);
            this.wareHouseNameTextBox.MaxLength = 200;
            this.wareHouseNameTextBox.Name = "wareHouseNameTextBox";
            this.wareHouseNameTextBox.Size = new System.Drawing.Size(320, 20);
            this.wareHouseNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWareHouseBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(119, 38);
            this.descriptionTextBox.MaxLength = 1000;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(320, 100);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWareHouseBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(119, 144);
            this.addressTextBox.MaxLength = 1000;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(320, 100);
            this.addressTextBox.TabIndex = 5;
            // 
            // telephoneNoTextBox
            // 
            this.telephoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWareHouseBindingSource, "TelephoneNo", true));
            this.telephoneNoTextBox.Location = new System.Drawing.Point(119, 250);
            this.telephoneNoTextBox.MaxLength = 20;
            this.telephoneNoTextBox.Name = "telephoneNoTextBox";
            this.telephoneNoTextBox.Size = new System.Drawing.Size(165, 20);
            this.telephoneNoTextBox.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(364, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(15, 310);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(101, 23);
            this.btnSaveAndNew.TabIndex = 10;
            this.btnSaveAndNew.Text = "&Save And New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAndClose.Location = new System.Drawing.Point(247, 310);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(101, 23);
            this.btnSaveAndClose.TabIndex = 8;
            this.btnSaveAndClose.Text = "&Save And Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // AddNewWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 346);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(wareHouseNameLabel);
            this.Controls.Add(this.wareHouseNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(telephoneNoLabel);
            this.Controls.Add(this.telephoneNoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewWareHouse";
            this.Text = "AddNewWareHouse";
            this.Load += new System.EventHandler(this.AddNewWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWareHouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryStoreDataSet inventoryStoreDataSet;
        private System.Windows.Forms.BindingSource tblWareHouseBindingSource;
        private InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter tblWareHouseTableAdapter;
        private InventoryStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox wareHouseNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telephoneNoTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnSaveAndClose;
    }
}