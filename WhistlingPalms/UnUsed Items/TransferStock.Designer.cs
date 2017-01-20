namespace WhistlingPalms
{
    partial class TransferStock
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
            System.Windows.Forms.Label transactionDetailsLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label fromWareHouseIDLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transactionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionDetailsTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbFromWareHouse = new System.Windows.Forms.ComboBox();
            this.btnTransferAndClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbToWareHouse = new System.Windows.Forms.ComboBox();
            this.toWareHouseIDLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.btnTransferAndNew = new System.Windows.Forms.Button();
            transactionDetailsLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            fromWareHouseIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionDetailsLabel
            // 
            transactionDetailsLabel.AutoSize = true;
            transactionDetailsLabel.Location = new System.Drawing.Point(29, 26);
            transactionDetailsLabel.Name = "transactionDetailsLabel";
            transactionDetailsLabel.Size = new System.Drawing.Size(101, 13);
            transactionDetailsLabel.TabIndex = 0;
            transactionDetailsLabel.Text = "Transaction Details:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new System.Drawing.Point(29, 138);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(92, 13);
            transactionDateLabel.TabIndex = 2;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(26, 23);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(47, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(26, 271);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 10;
            commentsLabel.Text = "Comments:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(353, 56);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 4;
            costLabel.Text = "Cost:";
            // 
            // fromWareHouseIDLabel
            // 
            fromWareHouseIDLabel.AutoSize = true;
            fromWareHouseIDLabel.Location = new System.Drawing.Point(26, 56);
            fromWareHouseIDLabel.Name = "fromWareHouseIDLabel";
            fromWareHouseIDLabel.Size = new System.Drawing.Size(96, 13);
            fromWareHouseIDLabel.TabIndex = 2;
            fromWareHouseIDLabel.Text = "From Ware House:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.WareHouseName,
            this.Cost,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(133, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 146);
            this.dataGridView1.TabIndex = 12;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // WareHouseName
            // 
            this.WareHouseName.DataPropertyName = "WareHouseName";
            this.WareHouseName.HeaderText = "WareHouse Name";
            this.WareHouseName.Name = "WareHouseName";
            this.WareHouseName.ReadOnly = true;
            this.WareHouseName.Width = 120;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(transactionDetailsLabel);
            this.groupBox1.Controls.Add(this.transactionDateDateTimePicker);
            this.groupBox1.Controls.Add(this.transactionDetailsTextBox);
            this.groupBox1.Controls.Add(transactionDateLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Information";
            // 
            // transactionDateDateTimePicker
            // 
            this.transactionDateDateTimePicker.Location = new System.Drawing.Point(136, 134);
            this.transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            this.transactionDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.transactionDateDateTimePicker.TabIndex = 3;
            // 
            // transactionDetailsTextBox
            // 
            this.transactionDetailsTextBox.Location = new System.Drawing.Point(136, 23);
            this.transactionDetailsTextBox.Multiline = true;
            this.transactionDetailsTextBox.Name = "transactionDetailsTextBox";
            this.transactionDetailsTextBox.Size = new System.Drawing.Size(748, 105);
            this.transactionDetailsTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(681, 53);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 7;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(821, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(623, 56);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // cmbFromWareHouse
            // 
            this.cmbFromWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromWareHouse.FormattingEnabled = true;
            this.cmbFromWareHouse.Location = new System.Drawing.Point(133, 52);
            this.cmbFromWareHouse.Name = "cmbFromWareHouse";
            this.cmbFromWareHouse.Size = new System.Drawing.Size(200, 21);
            this.cmbFromWareHouse.TabIndex = 3;
            // 
            // btnTransferAndClose
            // 
            this.btnTransferAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransferAndClose.Location = new System.Drawing.Point(673, 583);
            this.btnTransferAndClose.Name = "btnTransferAndClose";
            this.btnTransferAndClose.Size = new System.Drawing.Size(116, 23);
            this.btnTransferAndClose.TabIndex = 7;
            this.btnTransferAndClose.Text = "&Transfer And Close";
            this.btnTransferAndClose.UseVisualStyleBackColor = true;
            this.btnTransferAndClose.Click += new System.EventHandler(this.btnTransferAndClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbToWareHouse);
            this.groupBox2.Controls.Add(this.toWareHouseIDLabel);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.cmbFromWareHouse);
            this.groupBox2.Controls.Add(productIDLabel);
            this.groupBox2.Controls.Add(commentsLabel);
            this.groupBox2.Controls.Add(this.commentsTextBox);
            this.groupBox2.Controls.Add(this.cmbProducts);
            this.groupBox2.Controls.Add(this.costTextBox);
            this.groupBox2.Controls.Add(costLabel);
            this.groupBox2.Controls.Add(fromWareHouseIDLabel);
            this.groupBox2.Location = new System.Drawing.Point(15, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 369);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Information";
            // 
            // cmbToWareHouse
            // 
            this.cmbToWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToWareHouse.FormattingEnabled = true;
            this.cmbToWareHouse.Location = new System.Drawing.Point(133, 85);
            this.cmbToWareHouse.Name = "cmbToWareHouse";
            this.cmbToWareHouse.Size = new System.Drawing.Size(200, 21);
            this.cmbToWareHouse.TabIndex = 14;
            // 
            // toWareHouseIDLabel
            // 
            this.toWareHouseIDLabel.AutoSize = true;
            this.toWareHouseIDLabel.Location = new System.Drawing.Point(29, 88);
            this.toWareHouseIDLabel.Name = "toWareHouseIDLabel";
            this.toWareHouseIDLabel.Size = new System.Drawing.Size(83, 13);
            this.toWareHouseIDLabel.TabIndex = 13;
            this.toWareHouseIDLabel.Text = "To WareHouse:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(133, 268);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(748, 78);
            this.commentsTextBox.TabIndex = 11;
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(133, 20);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(748, 21);
            this.cmbProducts.TabIndex = 1;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(390, 53);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 5;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // btnTransferAndNew
            // 
            this.btnTransferAndNew.Location = new System.Drawing.Point(148, 583);
            this.btnTransferAndNew.Name = "btnTransferAndNew";
            this.btnTransferAndNew.Size = new System.Drawing.Size(104, 23);
            this.btnTransferAndNew.TabIndex = 9;
            this.btnTransferAndNew.Text = "&Transfer And New";
            this.btnTransferAndNew.UseVisualStyleBackColor = true;
            this.btnTransferAndNew.Click += new System.EventHandler(this.btnTransferAndNew_Click);
            // 
            // TransferStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransferAndClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTransferAndNew);
            this.Name = "TransferStock";
            this.Text = "TransferStock";
            this.Load += new System.EventHandler(this.TransferStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareHouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker transactionDateDateTimePicker;
        private System.Windows.Forms.TextBox transactionDetailsTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbFromWareHouse;
        private System.Windows.Forms.Button btnTransferAndClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button btnTransferAndNew;
        private System.Windows.Forms.Label toWareHouseIDLabel;
        private System.Windows.Forms.ComboBox cmbToWareHouse;

    }
}