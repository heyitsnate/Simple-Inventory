namespace WhistlingPalms
{
    partial class uscTransferStock
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label wareHouseIDLabel;
            System.Windows.Forms.Label lblToWareHouse;
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToTransaction = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbToWareHouse = new System.Windows.Forms.ComboBox();
            this.cmbFromWareHouse = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.ProductNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWareHouseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInformationButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            productIDLabel = new System.Windows.Forms.Label();
            wareHouseIDLabel = new System.Windows.Forms.Label();
            lblToWareHouse = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(27, 15);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(47, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product:";
            // 
            // wareHouseIDLabel
            // 
            wareHouseIDLabel.AutoSize = true;
            wareHouseIDLabel.Location = new System.Drawing.Point(27, 48);
            wareHouseIDLabel.Name = "wareHouseIDLabel";
            wareHouseIDLabel.Size = new System.Drawing.Size(93, 13);
            wareHouseIDLabel.TabIndex = 2;
            wareHouseIDLabel.Text = "From WareHouse:";
            // 
            // lblToWareHouse
            // 
            lblToWareHouse.AutoSize = true;
            lblToWareHouse.Location = new System.Drawing.Point(342, 48);
            lblToWareHouse.Name = "lblToWareHouse";
            lblToWareHouse.Size = new System.Drawing.Size(83, 13);
            lblToWareHouse.TabIndex = 4;
            lblToWareHouse.Text = "To WareHouse:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.dgvTransactionDetails);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(834, 427);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Information";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 108);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddToTransaction);
            this.panel1.Controls.Add(productIDLabel);
            this.panel1.Controls.Add(lblToWareHouse);
            this.panel1.Controls.Add(wareHouseIDLabel);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.cmbToWareHouse);
            this.panel1.Controls.Add(this.cmbFromWareHouse);
            this.panel1.Controls.Add(this.cmbProducts);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 102);
            this.panel1.TabIndex = 0;
            // 
            // btnAddToTransaction
            // 
            this.btnAddToTransaction.Location = new System.Drawing.Point(696, 71);
            this.btnAddToTransaction.Name = "btnAddToTransaction";
            this.btnAddToTransaction.Size = new System.Drawing.Size(109, 23);
            this.btnAddToTransaction.TabIndex = 8;
            this.btnAddToTransaction.Text = "&Add To Transaction";
            this.btnAddToTransaction.UseVisualStyleBackColor = true;
            this.btnAddToTransaction.Click += new System.EventHandler(this.btnAddToTransaction_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(720, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(85, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(620, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(94, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Transfer Quantity: ";
            // 
            // cmbToWareHouse
            // 
            this.cmbToWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToWareHouse.FormattingEnabled = true;
            this.cmbToWareHouse.Location = new System.Drawing.Point(431, 45);
            this.cmbToWareHouse.Name = "cmbToWareHouse";
            this.cmbToWareHouse.Size = new System.Drawing.Size(165, 21);
            this.cmbToWareHouse.TabIndex = 5;
            // 
            // cmbFromWareHouse
            // 
            this.cmbFromWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromWareHouse.FormattingEnabled = true;
            this.cmbFromWareHouse.Location = new System.Drawing.Point(134, 44);
            this.cmbFromWareHouse.Name = "cmbFromWareHouse";
            this.cmbFromWareHouse.Size = new System.Drawing.Size(165, 21);
            this.cmbFromWareHouse.TabIndex = 3;
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(134, 12);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(671, 21);
            this.cmbProducts.TabIndex = 1;
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.AllowUserToAddRows = false;
            this.dgvTransactionDetails.AllowUserToDeleteRows = false;
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameColumn1,
            this.WareHouseNameColumn,
            this.ToWareHouseNameColumn,
            this.TransactQuantityColumn,
            this.StockInformationButtonColumn,
            this.DeleteColumn});
            this.dgvTransactionDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(3, 155);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.RowHeadersVisible = false;
            this.dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(826, 142);
            this.dgvTransactionDetails.TabIndex = 1;
            this.dgvTransactionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetails_CellClick);
            this.dgvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetails_CellContentClick);
            // 
            // ProductNameColumn1
            // 
            this.ProductNameColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumn1.DataPropertyName = "ProductName";
            this.ProductNameColumn1.HeaderText = "Product Name";
            this.ProductNameColumn1.Name = "ProductNameColumn1";
            this.ProductNameColumn1.ReadOnly = true;
            // 
            // WareHouseNameColumn
            // 
            this.WareHouseNameColumn.DataPropertyName = "FromWareHouseName";
            this.WareHouseNameColumn.HeaderText = "From WareHouse";
            this.WareHouseNameColumn.Name = "WareHouseNameColumn";
            this.WareHouseNameColumn.ReadOnly = true;
            this.WareHouseNameColumn.Width = 130;
            // 
            // ToWareHouseNameColumn
            // 
            this.ToWareHouseNameColumn.DataPropertyName = "ToWareHouseName";
            this.ToWareHouseNameColumn.HeaderText = "To WareHouse";
            this.ToWareHouseNameColumn.Name = "ToWareHouseNameColumn";
            this.ToWareHouseNameColumn.ReadOnly = true;
            this.ToWareHouseNameColumn.Width = 103;
            // 
            // TransactQuantityColumn
            // 
            this.TransactQuantityColumn.DataPropertyName = "TransactQuantity";
            this.TransactQuantityColumn.HeaderText = "Transact Qty";
            this.TransactQuantityColumn.Name = "TransactQuantityColumn";
            this.TransactQuantityColumn.ReadOnly = true;
            this.TransactQuantityColumn.Width = 95;
            // 
            // StockInformationButtonColumn
            // 
            this.StockInformationButtonColumn.HeaderText = "View Stock Change Information";
            this.StockInformationButtonColumn.Name = "StockInformationButtonColumn";
            this.StockInformationButtonColumn.ReadOnly = true;
            this.StockInformationButtonColumn.Text = "View Stock Change Information";
            this.StockInformationButtonColumn.UseColumnTextForButtonValue = true;
            this.StockInformationButtonColumn.Width = 180;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.ToolTipText = "Delete this Transaction Details";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 90;
            // 
            // uscTransferStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "uscTransferStock";
            this.Size = new System.Drawing.Size(837, 431);
            this.Load += new System.EventHandler(this.uscTransferStock_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddToTransaction;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbFromWareHouse;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.ComboBox cmbToWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHouseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWareHouseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactQuantityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn StockInformationButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
