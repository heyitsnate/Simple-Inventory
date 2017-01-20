namespace WhistlingPalms
{
    partial class AddNewClient
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
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label contactNoLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailIDLabel;
            System.Windows.Forms.Label isVendorLabel;
            System.Windows.Forms.Label isCustomerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewClient));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailIDTextBox = new System.Windows.Forms.TextBox();
            this.isVendorCheckBox = new System.Windows.Forms.CheckBox();
            this.isCustomerCheckBox = new System.Windows.Forms.CheckBox();
            clientNameLabel = new System.Windows.Forms.Label();
            contactNoLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailIDLabel = new System.Windows.Forms.Label();
            isVendorLabel = new System.Windows.Forms.Label();
            isCustomerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(19, 17);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(67, 13);
            clientNameLabel.TabIndex = 0;
            clientNameLabel.Text = "Client Name:";
            // 
            // contactNoLabel
            // 
            contactNoLabel.AutoSize = true;
            contactNoLabel.Location = new System.Drawing.Point(19, 69);
            contactNoLabel.Name = "contactNoLabel";
            contactNoLabel.Size = new System.Drawing.Size(64, 13);
            contactNoLabel.TabIndex = 4;
            contactNoLabel.Text = "Contact No:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(19, 43);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 2;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(19, 95);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // emailIDLabel
            // 
            emailIDLabel.AutoSize = true;
            emailIDLabel.Location = new System.Drawing.Point(19, 228);
            emailIDLabel.Name = "emailIDLabel";
            emailIDLabel.Size = new System.Drawing.Size(49, 13);
            emailIDLabel.TabIndex = 8;
            emailIDLabel.Text = "Email ID:";
            // 
            // isVendorLabel
            // 
            isVendorLabel.AutoSize = true;
            isVendorLabel.Location = new System.Drawing.Point(19, 256);
            isVendorLabel.Name = "isVendorLabel";
            isVendorLabel.Size = new System.Drawing.Size(93, 13);
            isVendorLabel.TabIndex = 10;
            isVendorLabel.Text = "Is Client a Vendor:";
            // 
            // isCustomerLabel
            // 
            isCustomerLabel.AutoSize = true;
            isCustomerLabel.Location = new System.Drawing.Point(19, 286);
            isCustomerLabel.Name = "isCustomerLabel";
            isCustomerLabel.Size = new System.Drawing.Size(103, 13);
            isCustomerLabel.TabIndex = 12;
            isCustomerLabel.Text = "Is Client a Customer:";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnSaveAndClose);
            this.panel1.Controls.Add(clientNameLabel);
            this.panel1.Controls.Add(this.clientNameTextBox);
            this.panel1.Controls.Add(contactNoLabel);
            this.panel1.Controls.Add(this.contactNoTextBox);
            this.panel1.Controls.Add(contactPersonLabel);
            this.panel1.Controls.Add(this.contactPersonTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(emailIDLabel);
            this.panel1.Controls.Add(this.emailIDTextBox);
            this.panel1.Controls.Add(isVendorLabel);
            this.panel1.Controls.Add(this.isVendorCheckBox);
            this.panel1.Controls.Add(isCustomerLabel);
            this.panel1.Controls.Add(this.isCustomerCheckBox);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 344);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(400, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(22, 318);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(104, 23);
            this.btnSaveAndNew.TabIndex = 16;
            this.btnSaveAndNew.Text = "&Save And New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAndClose.Location = new System.Drawing.Point(290, 320);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(104, 23);
            this.btnSaveAndClose.TabIndex = 14;
            this.btnSaveAndClose.Text = "&Save And Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(128, 14);
            this.clientNameTextBox.MaxLength = 200;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(350, 20);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(128, 66);
            this.contactNoTextBox.MaxLength = 20;
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(175, 20);
            this.contactNoTextBox.TabIndex = 5;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(128, 40);
            this.contactPersonTextBox.MaxLength = 200;
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(347, 20);
            this.contactPersonTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(128, 92);
            this.addressTextBox.MaxLength = 1000;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(347, 127);
            this.addressTextBox.TabIndex = 7;
            // 
            // emailIDTextBox
            // 
            this.emailIDTextBox.Location = new System.Drawing.Point(128, 225);
            this.emailIDTextBox.MaxLength = 200;
            this.emailIDTextBox.Name = "emailIDTextBox";
            this.emailIDTextBox.Size = new System.Drawing.Size(347, 20);
            this.emailIDTextBox.TabIndex = 9;
            // 
            // isVendorCheckBox
            // 
            this.isVendorCheckBox.Location = new System.Drawing.Point(128, 251);
            this.isVendorCheckBox.Name = "isVendorCheckBox";
            this.isVendorCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isVendorCheckBox.TabIndex = 11;
            this.isVendorCheckBox.UseVisualStyleBackColor = true;
            // 
            // isCustomerCheckBox
            // 
            this.isCustomerCheckBox.Location = new System.Drawing.Point(128, 281);
            this.isCustomerCheckBox.Name = "isCustomerCheckBox";
            this.isCustomerCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isCustomerCheckBox.TabIndex = 13;
            this.isCustomerCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewClient";
            this.Load += new System.EventHandler(this.AddNewClient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailIDTextBox;
        private System.Windows.Forms.CheckBox isVendorCheckBox;
        private System.Windows.Forms.CheckBox isCustomerCheckBox;
        private System.Windows.Forms.Button btnSaveAndNew;



    }
}
