namespace WhistlingPalms
{
    partial class FinancialStatistics
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TransactionSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportsDataSet = new WhistlingPalms.ReportsDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpToTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromTransactionDate = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransactionSummaryTableAdapter = new WhistlingPalms.ReportsDataSetTableAdapters.TransactionSummaryTableAdapter();
            this.CurrentInventoryTableAdapter = new WhistlingPalms.ReportsDataSetTableAdapters.CurrentInventoryTableAdapter();
            this.CurrentInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.dtpToTransactionDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFromTransactionDate);
            this.panel1.Controls.Add(this.lblFromTransactionDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(600, 12);
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
            this.dtpToTransactionDate.Location = new System.Drawing.Point(420, 14);
            this.dtpToTransactionDate.Name = "dtpToTransactionDate";
            this.dtpToTransactionDate.ShowCheckBox = true;
            this.dtpToTransactionDate.Size = new System.Drawing.Size(138, 20);
            this.dtpToTransactionDate.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "To Transaction Date:";
            // 
            // dtpFromTransactionDate
            // 
            this.dtpFromTransactionDate.Checked = false;
            this.dtpFromTransactionDate.Location = new System.Drawing.Point(134, 14);
            this.dtpFromTransactionDate.Name = "dtpFromTransactionDate";
            this.dtpFromTransactionDate.ShowCheckBox = true;
            this.dtpFromTransactionDate.Size = new System.Drawing.Size(132, 20);
            this.dtpFromTransactionDate.TabIndex = 19;
            // 
            // lblFromTransactionDate
            // 
            this.lblFromTransactionDate.AutoSize = true;
            this.lblFromTransactionDate.Location = new System.Drawing.Point(10, 17);
            this.lblFromTransactionDate.Name = "lblFromTransactionDate";
            this.lblFromTransactionDate.Size = new System.Drawing.Size(118, 13);
            this.lblFromTransactionDate.TabIndex = 18;
            this.lblFromTransactionDate.Text = "From Transaction Date:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TransactionSummaryDataSet";
            reportDataSource1.Value = this.TransactionSummaryBindingSource;
            reportDataSource2.Name = "CurrentInventoryDataSet";
            reportDataSource2.Value = this.CurrentInventoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WhistlingPalms.ReportFiles.FinancialStatistics.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(736, 446);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // TransactionSummaryTableAdapter
            // 
            this.TransactionSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // CurrentInventoryTableAdapter
            // 
            this.CurrentInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // CurrentInventoryBindingSource
            // 
            this.CurrentInventoryBindingSource.DataMember = "CurrentInventory";
            this.CurrentInventoryBindingSource.DataSource = this.ReportsDataSet;
            // 
            // FinancialStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FinancialStatistics";
            this.Text = "Financial Statistics Report";
            this.Load += new System.EventHandler(this.GrossProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInventoryBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionSummaryBindingSource;
        private ReportsDataSet ReportsDataSet;
        private ReportsDataSetTableAdapters.TransactionSummaryTableAdapter TransactionSummaryTableAdapter;
        private ReportsDataSetTableAdapters.CurrentInventoryTableAdapter CurrentInventoryTableAdapter;
        private System.Windows.Forms.BindingSource CurrentInventoryBindingSource;
    }
}