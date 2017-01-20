namespace WhistlingPalms
{
    partial class AddNewProduct
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
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label productTag1Label;
            System.Windows.Forms.Label productTag2Label;
            System.Windows.Forms.Label salePriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProduct));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productTag1TextBox = new System.Windows.Forms.TextBox();
            this.productTag2TextBox = new System.Windows.Forms.TextBox();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            productNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            productTag1Label = new System.Windows.Forms.Label();
            productTag2Label = new System.Windows.Forms.Label();
            salePriceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(21, 19);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Product Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(31, 45);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(26, 157);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            manufacturerLabel.TabIndex = 4;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // productTag1Label
            // 
            productTag1Label.AutoSize = true;
            productTag1Label.Location = new System.Drawing.Point(24, 209);
            productTag1Label.Name = "productTag1Label";
            productTag1Label.Size = new System.Drawing.Size(75, 13);
            productTag1Label.TabIndex = 6;
            productTag1Label.Text = "Product Tag1:";
            // 
            // productTag2Label
            // 
            productTag2Label.AutoSize = true;
            productTag2Label.Location = new System.Drawing.Point(24, 235);
            productTag2Label.Name = "productTag2Label";
            productTag2Label.Size = new System.Drawing.Size(75, 13);
            productTag2Label.TabIndex = 8;
            productTag2Label.Text = "Product Tag2:";
            // 
            // salePriceLabel
            // 
            salePriceLabel.AutoSize = true;
            salePriceLabel.Location = new System.Drawing.Point(36, 261);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new System.Drawing.Size(58, 13);
            salePriceLabel.TabIndex = 10;
            salePriceLabel.Text = "Sale Price:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chkDiscontinued);
            this.panel1.Controls.Add(this.lblDiscontinued);
            this.panel1.Controls.Add(productNameLabel);
            this.panel1.Controls.Add(this.productNameTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(manufacturerLabel);
            this.panel1.Controls.Add(this.manufacturerTextBox);
            this.panel1.Controls.Add(productTag1Label);
            this.panel1.Controls.Add(this.productTag1TextBox);
            this.panel1.Controls.Add(productTag2Label);
            this.panel1.Controls.Add(this.productTag2TextBox);
            this.panel1.Controls.Add(salePriceLabel);
            this.panel1.Controls.Add(this.salePriceTextBox);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnSaveAndClose);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 361);
            this.panel1.TabIndex = 0;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(110, 284);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chkDiscontinued.TabIndex = 13;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(24, 284);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(75, 13);
            this.lblDiscontinued.TabIndex = 12;
            this.lblDiscontinued.Text = "Discontinued: ";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(109, 16);
            this.productNameTextBox.MaxLength = 100;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(350, 20);
            this.productNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(109, 42);
            this.descriptionTextBox.MaxLength = 1000;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(350, 106);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(109, 154);
            this.manufacturerTextBox.MaxLength = 200;
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(350, 20);
            this.manufacturerTextBox.TabIndex = 5;
            // 
            // productTag1TextBox
            // 
            this.productTag1TextBox.Location = new System.Drawing.Point(109, 206);
            this.productTag1TextBox.MaxLength = 50;
            this.productTag1TextBox.Name = "productTag1TextBox";
            this.productTag1TextBox.Size = new System.Drawing.Size(175, 20);
            this.productTag1TextBox.TabIndex = 7;
            // 
            // productTag2TextBox
            // 
            this.productTag2TextBox.Location = new System.Drawing.Point(109, 232);
            this.productTag2TextBox.MaxLength = 50;
            this.productTag2TextBox.Name = "productTag2TextBox";
            this.productTag2TextBox.Size = new System.Drawing.Size(175, 20);
            this.productTag2TextBox.TabIndex = 9;
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(109, 258);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(175, 20);
            this.salePriceTextBox.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(384, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(24, 324);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(101, 23);
            this.btnSaveAndNew.TabIndex = 16;
            this.btnSaveAndNew.Text = "&Save And New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAndClose.Location = new System.Drawing.Point(277, 326);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(101, 23);
            this.btnSaveAndClose.TabIndex = 14;
            this.btnSaveAndClose.Text = "&Save And Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(511, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewProduct";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox productTag1TextBox;
        private System.Windows.Forms.TextBox productTag2TextBox;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Label lblDiscontinued;



    }
}
