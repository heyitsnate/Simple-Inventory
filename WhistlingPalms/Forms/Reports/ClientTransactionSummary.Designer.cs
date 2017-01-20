namespace WhistlingPalms
{
    partial class ClientTransactionSummary
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
            System.Windows.Forms.Label lblClient;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TransactionSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportsDataSet = new WhistlingPalms.ReportsDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromTransactionDate = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransactionSummaryTableAdapter = new WhistlingPalms.ReportsDataSetTableAdapters.TransactionSummaryTableAdapter();
            lblClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new System.Drawing.Point(89, 19);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(39, 13);
            lblClient.TabIndex = 16;
            lblClient.Text = "Client: ";
            // 
            // TransactionSummaryBindingSource
            // 
            this.TransactionSummaryBindingSource.DataMember = "TransactionSummary";
            this.TransactionSummaryBindingSource.DataSource = this.ReportsDataSet;
            // 
            // ReportsDataSet
            // 
            this.ReportsDataSet.DataSetName = "ReportsDataSet";
            this.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.dtpToTransactionDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFromTransactionDate);
            this.panel1.Controls.Add(this.lblFromTransactionDate);
            this.panel1.Controls.Add(this.cmbTransactionType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(lblClient);
            this.panel1.Controls.Add(this.cmbClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(522, 77);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 22;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpToTransactionDate
            // 
            this.dtpToTransactionDate.Checked = false;
            this.dtpToTransactionDate.Location = new System.Drawing.Point(459, 45);
            this.dtpToTransactionDate.Name = "dtpToTransactionDate";
            this.dtpToTransactionDate.ShowCheckBox = true;
            this.dtpToTransactionDate.Size = new System.Drawing.Size(138, 20);
            this.dtpToTransactionDate.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "To Transaction Date:";
            // 
            // dtpFromTransactionDate
            // 
            this.dtpFromTransactionDate.Checked = false;
            this.dtpFromTransactionDate.Location = new System.Drawing.Point(134, 45);
            this.dtpFromTransactionDate.Name = "dtpFromTransactionDate";
            this.dtpFromTransactionDate.ShowCheckBox = true;
            this.dtpFromTransactionDate.Size = new System.Drawing.Size(132, 20);
            this.dtpFromTransactionDate.TabIndex = 19;
            // 
            // lblFromTransactionDate
            // 
            this.lblFromTransactionDate.AutoSize = true;
            this.lblFromTransactionDate.Location = new System.Drawing.Point(10, 48);
            this.lblFromTransactionDate.Name = "lblFromTransactionDate";
            this.lblFromTransactionDate.Size = new System.Drawing.Size(118, 13);
            this.lblFromTransactionDate.TabIndex = 18;
            this.lblFromTransactionDate.Text = "From Transaction Date:";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(134, 74);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(282, 21);
            this.cmbTransactionType.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Transaction Type:";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(134, 16);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(463, 21);
            this.cmbClient.TabIndex = 17;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ClientTransactionSummaryDataSet";
            reportDataSource1.Value = this.TransactionSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WhistlingPalms.ReportFiles.ClientTransactionSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(623, 345);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // TransactionSummaryTableAdapter
            // 
            this.TransactionSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // ClientTransactionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientTransactionSummary";
            this.Text = "Client Transaction Summary Report";
            this.Load += new System.EventHandler(this.ClientTransactionSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpToTransactionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromTransactionDate;
        private System.Windows.Forms.Label lblFromTransactionDate;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionSummaryBindingSource;
        private ReportsDataSet ReportsDataSet;
        private WhistlingPalms.ReportsDataSetTableAdapters.TransactionSummaryTableAdapter TransactionSummaryTableAdapter;

    }
}