namespace WhistlingPalms
{
    partial class AddNewTransaction
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
            System.Windows.Forms.Label lblRemarks;
            System.Windows.Forms.Label lblTransactionDetails;
            System.Windows.Forms.Label lblTransactionDate;
            System.Windows.Forms.Label lblClient;
            System.Windows.Forms.Label lblOrderNo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTransaction));
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTransactionInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.grpTransactionInfo = new System.Windows.Forms.GroupBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.txtTransactionDetails = new System.Windows.Forms.TextBox();
            this.grpClientInfo = new System.Windows.Forms.GroupBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.grpActionNextCancel = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flpTransactionItemDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTransactionItemDetails = new System.Windows.Forms.Panel();
            this.grpActionPreviousFinishCancel = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            lblRemarks = new System.Windows.Forms.Label();
            lblTransactionDetails = new System.Windows.Forms.Label();
            lblTransactionDate = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblOrderNo = new System.Windows.Forms.Label();
            this.flpContainer.SuspendLayout();
            this.flpTransactionInfo.SuspendLayout();
            this.grpTransactionInfo.SuspendLayout();
            this.grpClientInfo.SuspendLayout();
            this.grpActionNextCancel.SuspendLayout();
            this.flpTransactionItemDetails.SuspendLayout();
            this.grpActionPreviousFinishCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new System.Drawing.Point(75, 54);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new System.Drawing.Size(55, 13);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks: ";
            // 
            // lblTransactionDetails
            // 
            lblTransactionDetails.AutoSize = true;
            lblTransactionDetails.Location = new System.Drawing.Point(29, 26);
            lblTransactionDetails.Name = "lblTransactionDetails";
            lblTransactionDetails.Size = new System.Drawing.Size(101, 13);
            lblTransactionDetails.TabIndex = 0;
            lblTransactionDetails.Text = "Transaction Details:";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new System.Drawing.Point(38, 91);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new System.Drawing.Size(92, 13);
            lblTransactionDate.TabIndex = 2;
            lblTransactionDate.Text = "Transaction Date:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new System.Drawing.Point(417, 27);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(39, 13);
            lblClient.TabIndex = 2;
            lblClient.Text = "Client: ";
            // 
            // lblOrderNo
            // 
            lblOrderNo.AutoSize = true;
            lblOrderNo.Location = new System.Drawing.Point(74, 27);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new System.Drawing.Size(56, 13);
            lblOrderNo.TabIndex = 0;
            lblOrderNo.Text = "Order No: ";
            // 
            // flpContainer
            // 
            this.flpContainer.Controls.Add(this.flpTransactionInfo);
            this.flpContainer.Controls.Add(this.flpTransactionItemDetails);
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(844, 750);
            this.flpContainer.TabIndex = 0;
            // 
            // flpTransactionInfo
            // 
            this.flpTransactionInfo.Controls.Add(this.grpTransactionInfo);
            this.flpTransactionInfo.Controls.Add(this.grpClientInfo);
            this.flpTransactionInfo.Controls.Add(this.grpActionNextCancel);
            this.flpTransactionInfo.Location = new System.Drawing.Point(3, 3);
            this.flpTransactionInfo.Name = "flpTransactionInfo";
            this.flpTransactionInfo.Size = new System.Drawing.Size(831, 291);
            this.flpTransactionInfo.TabIndex = 0;
            // 
            // grpTransactionInfo
            // 
            this.grpTransactionInfo.Controls.Add(this.cmbTransactionType);
            this.grpTransactionInfo.Controls.Add(this.lblTransactionType);
            this.grpTransactionInfo.Controls.Add(lblTransactionDetails);
            this.grpTransactionInfo.Controls.Add(this.dtpTransactionDate);
            this.grpTransactionInfo.Controls.Add(this.txtTransactionDetails);
            this.grpTransactionInfo.Controls.Add(lblTransactionDate);
            this.grpTransactionInfo.Location = new System.Drawing.Point(3, 3);
            this.grpTransactionInfo.Name = "grpTransactionInfo";
            this.grpTransactionInfo.Size = new System.Drawing.Size(825, 118);
            this.grpTransactionInfo.TabIndex = 0;
            this.grpTransactionInfo.TabStop = false;
            this.grpTransactionInfo.Text = "Transaction Information";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(462, 88);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(357, 21);
            this.cmbTransactionType.TabIndex = 5;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(363, 91);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "Transaction Type:";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.CustomFormat = "dd MMMM yyyy";
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(136, 87);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(145, 20);
            this.dtpTransactionDate.TabIndex = 3;
            // 
            // txtTransactionDetails
            // 
            this.txtTransactionDetails.Location = new System.Drawing.Point(136, 23);
            this.txtTransactionDetails.MaxLength = 1000;
            this.txtTransactionDetails.Multiline = true;
            this.txtTransactionDetails.Name = "txtTransactionDetails";
            this.txtTransactionDetails.Size = new System.Drawing.Size(683, 57);
            this.txtTransactionDetails.TabIndex = 1;
            // 
            // grpClientInfo
            // 
            this.grpClientInfo.Controls.Add(this.txtOrderNo);
            this.grpClientInfo.Controls.Add(lblClient);
            this.grpClientInfo.Controls.Add(lblRemarks);
            this.grpClientInfo.Controls.Add(this.cmbClient);
            this.grpClientInfo.Controls.Add(lblOrderNo);
            this.grpClientInfo.Controls.Add(this.txtRemarks);
            this.grpClientInfo.Location = new System.Drawing.Point(3, 127);
            this.grpClientInfo.Name = "grpClientInfo";
            this.grpClientInfo.Size = new System.Drawing.Size(825, 108);
            this.grpClientInfo.TabIndex = 1;
            this.grpClientInfo.TabStop = false;
            this.grpClientInfo.Text = "Client And Order Information";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(136, 24);
            this.txtOrderNo.MaxLength = 50;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(145, 20);
            this.txtOrderNo.TabIndex = 1;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(462, 24);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(357, 21);
            this.cmbClient.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(136, 51);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(683, 50);
            this.txtRemarks.TabIndex = 5;
            // 
            // grpActionNextCancel
            // 
            this.grpActionNextCancel.Controls.Add(this.btnNext);
            this.grpActionNextCancel.Controls.Add(this.btnCancel);
            this.grpActionNextCancel.Location = new System.Drawing.Point(3, 241);
            this.grpActionNextCancel.Name = "grpActionNextCancel";
            this.grpActionNextCancel.Size = new System.Drawing.Size(825, 42);
            this.grpActionNextCancel.TabIndex = 2;
            this.grpActionNextCancel.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(663, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "&Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(744, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flpTransactionItemDetails
            // 
            this.flpTransactionItemDetails.Controls.Add(this.pnlTransactionItemDetails);
            this.flpTransactionItemDetails.Controls.Add(this.grpActionPreviousFinishCancel);
            this.flpTransactionItemDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTransactionItemDetails.Location = new System.Drawing.Point(3, 300);
            this.flpTransactionItemDetails.Name = "flpTransactionItemDetails";
            this.flpTransactionItemDetails.Size = new System.Drawing.Size(831, 327);
            this.flpTransactionItemDetails.TabIndex = 1;
            // 
            // pnlTransactionItemDetails
            // 
            this.pnlTransactionItemDetails.AutoSize = true;
            this.pnlTransactionItemDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTransactionItemDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlTransactionItemDetails.Name = "pnlTransactionItemDetails";
            this.pnlTransactionItemDetails.Size = new System.Drawing.Size(0, 0);
            this.pnlTransactionItemDetails.TabIndex = 0;
            // 
            // grpActionPreviousFinishCancel
            // 
            this.grpActionPreviousFinishCancel.Controls.Add(this.btnPrevious);
            this.grpActionPreviousFinishCancel.Controls.Add(this.btnFinish);
            this.grpActionPreviousFinishCancel.Controls.Add(this.btnCancel1);
            this.grpActionPreviousFinishCancel.Location = new System.Drawing.Point(3, 9);
            this.grpActionPreviousFinishCancel.Name = "grpActionPreviousFinishCancel";
            this.grpActionPreviousFinishCancel.Size = new System.Drawing.Size(825, 42);
            this.grpActionPreviousFinishCancel.TabIndex = 1;
            this.grpActionPreviousFinishCancel.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(582, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "< &Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(663, 13);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(744, 13);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 2;
            this.btnCancel1.Text = "&Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 750);
            this.Controls.Add(this.flpContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewTransaction";
            this.Text = "Add New Transaction";
            this.Load += new System.EventHandler(this.AddNewTransaction_Load);
            this.flpContainer.ResumeLayout(false);
            this.flpTransactionInfo.ResumeLayout(false);
            this.grpTransactionInfo.ResumeLayout(false);
            this.grpTransactionInfo.PerformLayout();
            this.grpClientInfo.ResumeLayout(false);
            this.grpClientInfo.PerformLayout();
            this.grpActionNextCancel.ResumeLayout(false);
            this.flpTransactionItemDetails.ResumeLayout(false);
            this.flpTransactionItemDetails.PerformLayout();
            this.grpActionPreviousFinishCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.FlowLayoutPanel flpTransactionInfo;
        private System.Windows.Forms.GroupBox grpTransactionInfo;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtTransactionDetails;
        private System.Windows.Forms.GroupBox grpClientInfo;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.GroupBox grpActionNextCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flpTransactionItemDetails;
        private System.Windows.Forms.GroupBox grpActionPreviousFinishCancel;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Panel pnlTransactionItemDetails;



    }
}