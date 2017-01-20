namespace WhistlingPalms
{
    partial class AddEditTransactionType
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
            System.Windows.Forms.Label lblHasCustomerInformation;
            System.Windows.Forms.Label lblActionType;
            System.Windows.Forms.Label lblTransactionType;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTransactionType));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAddNewTransactionType = new System.Windows.Forms.GroupBox();
            this.chkHasCustomerInformation = new System.Windows.Forms.CheckBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.txtTransactionType = new System.Windows.Forms.TextBox();
            lblHasCustomerInformation = new System.Windows.Forms.Label();
            lblActionType = new System.Windows.Forms.Label();
            lblTransactionType = new System.Windows.Forms.Label();
            this.gbAddNewTransactionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHasCustomerInformation
            // 
            lblHasCustomerInformation.AutoSize = true;
            lblHasCustomerInformation.Location = new System.Drawing.Point(6, 89);
            lblHasCustomerInformation.Name = "lblHasCustomerInformation";
            lblHasCustomerInformation.Size = new System.Drawing.Size(131, 13);
            lblHasCustomerInformation.TabIndex = 4;
            lblHasCustomerInformation.Text = "Has Customer Information:";
            // 
            // lblActionType
            // 
            lblActionType.AutoSize = true;
            lblActionType.Location = new System.Drawing.Point(6, 59);
            lblActionType.Name = "lblActionType";
            lblActionType.Size = new System.Drawing.Size(67, 13);
            lblActionType.TabIndex = 3;
            lblActionType.Text = "Action Type:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new System.Drawing.Point(6, 28);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new System.Drawing.Size(93, 13);
            lblTransactionType.TabIndex = 1;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbAddNewTransactionType
            // 
            this.gbAddNewTransactionType.Controls.Add(this.chkHasCustomerInformation);
            this.gbAddNewTransactionType.Controls.Add(this.cmbActionType);
            this.gbAddNewTransactionType.Controls.Add(lblHasCustomerInformation);
            this.gbAddNewTransactionType.Controls.Add(lblActionType);
            this.gbAddNewTransactionType.Controls.Add(this.txtTransactionType);
            this.gbAddNewTransactionType.Controls.Add(lblTransactionType);
            this.gbAddNewTransactionType.Location = new System.Drawing.Point(2, 2);
            this.gbAddNewTransactionType.Name = "gbAddNewTransactionType";
            this.gbAddNewTransactionType.Size = new System.Drawing.Size(400, 117);
            this.gbAddNewTransactionType.TabIndex = 4;
            this.gbAddNewTransactionType.TabStop = false;
            this.gbAddNewTransactionType.Text = "Add New Transaction Type";
            // 
            // chkHasCustomerInformation
            // 
            this.chkHasCustomerInformation.AutoSize = true;
            this.chkHasCustomerInformation.Location = new System.Drawing.Point(151, 88);
            this.chkHasCustomerInformation.Name = "chkHasCustomerInformation";
            this.chkHasCustomerInformation.Size = new System.Drawing.Size(15, 14);
            this.chkHasCustomerInformation.TabIndex = 6;
            this.chkHasCustomerInformation.UseVisualStyleBackColor = true;
            // 
            // cmbActionType
            // 
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(151, 56);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(213, 21);
            this.cmbActionType.TabIndex = 5;
            // 
            // txtTransactionType
            // 
            this.txtTransactionType.Location = new System.Drawing.Point(151, 25);
            this.txtTransactionType.Name = "txtTransactionType";
            this.txtTransactionType.Size = new System.Drawing.Size(213, 20);
            this.txtTransactionType.TabIndex = 2;
            // 
            // AddEditTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 157);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAddNewTransactionType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditTransactionType";
            this.Text = "AddEditTransactiontype";
            this.Load += new System.EventHandler(this.AddEditTransactionType_Load);
            this.gbAddNewTransactionType.ResumeLayout(false);
            this.gbAddNewTransactionType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAddNewTransactionType;
        private System.Windows.Forms.CheckBox chkHasCustomerInformation;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.TextBox txtTransactionType;

    }
}