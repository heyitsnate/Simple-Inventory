namespace WhistlingPalms
{
    partial class StockChangeInformation
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label wareHouseIDLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.stockChangeInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new WhistlingPalms.ReportsDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbWareHouse = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stockChangeInformationTableAdapter = new WhistlingPalms.ReportsDataSetTableAdapters.StockChangeInformationTableAdapter();
            this.dtpToTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromTransactionDate = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            wareHouseIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockChangeInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(12, 14);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(47, 13);
            productIDLabel.TabIndex = 4;
            productIDLabel.Text = "Product:";
            // 
            // wareHouseIDLabel
            // 
            wareHouseIDLabel.AutoSize = true;
            wareHouseIDLabel.Location = new System.Drawing.Point(12, 46);
            wareHouseIDLabel.Name = "wareHouseIDLabel";
            wareHouseIDLabel.Size = new System.Drawing.Size(70, 13);
            wareHouseIDLabel.TabIndex = 6;
            wareHouseIDLabel.Text = "Ware House:";
            // 
            // stockChangeInformationBindingSource
            // 
            this.stockChangeInformationBindingSource.DataMember = "StockChangeInformation";
            this.stockChangeInformationBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 471);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpToTransactionDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFromTransactionDate);
            this.panel1.Controls.Add(this.lblFromTransactionDate);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.cmbWareHouse);
            this.panel1.Controls.Add(productIDLabel);
            this.panel1.Controls.Add(this.cmbProducts);
            this.panel1.Controls.Add(wareHouseIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(594, 73);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbWareHouse
            // 
            this.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWareHouse.FormattingEnabled = true;
            this.cmbWareHouse.Location = new System.Drawing.Point(127, 43);
            this.cmbWareHouse.Name = "cmbWareHouse";
            this.cmbWareHouse.Size = new System.Drawing.Size(200, 21);
            this.cmbWareHouse.TabIndex = 7;
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(127, 11);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(740, 21);
            this.cmbProducts.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportsDataSet";
            reportDataSource1.Value = this.stockChangeInformationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WhistlingPalms.ReportFiles.StockChangeInformation.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(879, 385);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // stockChangeInformationTableAdapter
            // 
            this.stockChangeInformationTableAdapter.ClearBeforeFill = true;
            // 
            // dtpToTransactionDate
            // 
            this.dtpToTransactionDate.Checked = false;
            this.dtpToTransactionDate.Location = new System.Drawing.Point(413, 75);
            this.dtpToTransactionDate.Name = "dtpToTransactionDate";
            this.dtpToTransactionDate.ShowCheckBox = true;
            this.dtpToTransactionDate.Size = new System.Drawing.Size(138, 20);
            this.dtpToTransactionDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "To Transaction Date:";
            // 
            // dtpFromTransactionDate
            // 
            this.dtpFromTransactionDate.Checked = false;
            this.dtpFromTransactionDate.Location = new System.Drawing.Point(127, 75);
            this.dtpFromTransactionDate.Name = "dtpFromTransactionDate";
            this.dtpFromTransactionDate.ShowCheckBox = true;
            this.dtpFromTransactionDate.Size = new System.Drawing.Size(132, 20);
            this.dtpFromTransactionDate.TabIndex = 23;
            // 
            // lblFromTransactionDate
            // 
            this.lblFromTransactionDate.AutoSize = true;
            this.lblFromTransactionDate.Location = new System.Drawing.Point(3, 78);
            this.lblFromTransactionDate.Name = "lblFromTransactionDate";
            this.lblFromTransactionDate.Size = new System.Drawing.Size(118, 13);
            this.lblFromTransactionDate.TabIndex = 22;
            this.lblFromTransactionDate.Text = "From Transaction Date:";
            // 
            // StockChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockChangeInformation";
            this.Text = "StockChangeInformation";
            this.Load += new System.EventHandler(this.StockChangeInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockChangeInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbWareHouse;
        private System.Windows.Forms.ComboBox cmbProducts;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource stockChangeInformationBindingSource;
        private ReportsDataSetTableAdapters.StockChangeInformationTableAdapter stockChangeInformationTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpToTransactionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromTransactionDate;
        private System.Windows.Forms.Label lblFromTransactionDate;
    }
}