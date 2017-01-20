namespace WhistlingPalms
{
    partial class CurrentInventory
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label wareHouseIDLabel;
            this.CurrentInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportsDataSet = new WhistlingPalms.ReportsDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CurrentInventoryTableAdapter = new WhistlingPalms.ReportsDataSetTableAdapters.CurrentInventoryTableAdapter();
            this.cmbWareHouse = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            productIDLabel = new System.Windows.Forms.Label();
            wareHouseIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentInventoryBindingSource
            // 
            this.CurrentInventoryBindingSource.DataMember = "CurrentInventory";
            this.CurrentInventoryBindingSource.DataSource = this.ReportsDataSet;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.cmbWareHouse);
            this.panel1.Controls.Add(productIDLabel);
            this.panel1.Controls.Add(this.cmbProducts);
            this.panel1.Controls.Add(wareHouseIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 74);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportsDataSet";
            reportDataSource1.Value = this.CurrentInventoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WhistlingPalms.ReportFiles.CurrentInventory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(878, 412);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // CurrentInventoryTableAdapter
            // 
            this.CurrentInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // cmbWareHouse
            // 
            this.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWareHouse.FormattingEnabled = true;
            this.cmbWareHouse.Location = new System.Drawing.Point(119, 43);
            this.cmbWareHouse.Name = "cmbWareHouse";
            this.cmbWareHouse.Size = new System.Drawing.Size(200, 21);
            this.cmbWareHouse.TabIndex = 7;
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
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(119, 11);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(748, 21);
            this.cmbProducts.TabIndex = 5;
            // 
            // wareHouseIDLabel
            // 
            wareHouseIDLabel.AutoSize = true;
            wareHouseIDLabel.Location = new System.Drawing.Point(12, 47);
            wareHouseIDLabel.Name = "wareHouseIDLabel";
            wareHouseIDLabel.Size = new System.Drawing.Size(70, 13);
            wareHouseIDLabel.TabIndex = 6;
            wareHouseIDLabel.Text = "Ware House:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(477, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ReportCurrentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportCurrentInventory";
            this.Text = "Current Inventory Report";
            this.Load += new System.EventHandler(this.ReportCurrentInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CurrentInventoryBindingSource;
        private ReportsDataSet ReportsDataSet;
        private ReportsDataSetTableAdapters.CurrentInventoryTableAdapter CurrentInventoryTableAdapter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbWareHouse;
        private System.Windows.Forms.ComboBox cmbProducts;
    }
}