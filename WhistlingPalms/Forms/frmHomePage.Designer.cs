namespace WhistlingPalms
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllWareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTransactionSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTransactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockChangeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.wareHouseToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.transactionTypeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllProductsToolStripMenuItem,
            this.addNewProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "&Products";
            // 
            // listAllProductsToolStripMenuItem
            // 
            this.listAllProductsToolStripMenuItem.Name = "listAllProductsToolStripMenuItem";
            this.listAllProductsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listAllProductsToolStripMenuItem.Text = "List All Products";
            this.listAllProductsToolStripMenuItem.Click += new System.EventHandler(this.listAllProductsToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // wareHouseToolStripMenuItem
            // 
            this.wareHouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllWareHouseToolStripMenuItem,
            this.addNewWareHouseToolStripMenuItem});
            this.wareHouseToolStripMenuItem.Name = "wareHouseToolStripMenuItem";
            this.wareHouseToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.wareHouseToolStripMenuItem.Text = "&WareHouse";
            // 
            // listAllWareHouseToolStripMenuItem
            // 
            this.listAllWareHouseToolStripMenuItem.Name = "listAllWareHouseToolStripMenuItem";
            this.listAllWareHouseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listAllWareHouseToolStripMenuItem.Text = "List All WareHouse";
            this.listAllWareHouseToolStripMenuItem.Click += new System.EventHandler(this.listAllWareHouseToolStripMenuItem_Click);
            // 
            // addNewWareHouseToolStripMenuItem
            // 
            this.addNewWareHouseToolStripMenuItem.Name = "addNewWareHouseToolStripMenuItem";
            this.addNewWareHouseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addNewWareHouseToolStripMenuItem.Text = "Add New WareHouse";
            this.addNewWareHouseToolStripMenuItem.Click += new System.EventHandler(this.addNewWareHouseToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllCustomersToolStripMenuItem,
            this.listAllVendorsToolStripMenuItem,
            this.addNewClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "&Client";
            // 
            // listAllCustomersToolStripMenuItem
            // 
            this.listAllCustomersToolStripMenuItem.Name = "listAllCustomersToolStripMenuItem";
            this.listAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listAllCustomersToolStripMenuItem.Text = "List All Customers";
            this.listAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.listAllCustomersToolStripMenuItem_Click);
            // 
            // listAllVendorsToolStripMenuItem
            // 
            this.listAllVendorsToolStripMenuItem.Name = "listAllVendorsToolStripMenuItem";
            this.listAllVendorsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listAllVendorsToolStripMenuItem.Text = "List All Vendors";
            this.listAllVendorsToolStripMenuItem.Click += new System.EventHandler(this.listAllVendorsToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.viewStockToolStripMenuItem,
            this.viewTransactionsToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewStockToolStripMenuItem.Text = "View Inventory";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            this.viewTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentInventoryToolStripMenuItem,
            this.clientTransactionSummaryToolStripMenuItem,
            this.clientTransactionDetailsToolStripMenuItem,
            this.financialStatisticsToolStripMenuItem,
            this.stockChangeInformationToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // currentInventoryToolStripMenuItem
            // 
            this.currentInventoryToolStripMenuItem.Name = "currentInventoryToolStripMenuItem";
            this.currentInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.currentInventoryToolStripMenuItem.Text = "Current Inventory";
            this.currentInventoryToolStripMenuItem.Click += new System.EventHandler(this.currentInventoryToolStripMenuItem_Click);
            // 
            // clientTransactionSummaryToolStripMenuItem
            // 
            this.clientTransactionSummaryToolStripMenuItem.Name = "clientTransactionSummaryToolStripMenuItem";
            this.clientTransactionSummaryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clientTransactionSummaryToolStripMenuItem.Text = "Client Transaction Summary";
            this.clientTransactionSummaryToolStripMenuItem.Click += new System.EventHandler(this.clientTransactionSummaryToolStripMenuItem_Click);
            // 
            // clientTransactionDetailsToolStripMenuItem
            // 
            this.clientTransactionDetailsToolStripMenuItem.Name = "clientTransactionDetailsToolStripMenuItem";
            this.clientTransactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clientTransactionDetailsToolStripMenuItem.Text = "Client Transaction Details";
            this.clientTransactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.clientTransactionDetailsToolStripMenuItem_Click);
            // 
            // financialStatisticsToolStripMenuItem
            // 
            this.financialStatisticsToolStripMenuItem.Name = "financialStatisticsToolStripMenuItem";
            this.financialStatisticsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.financialStatisticsToolStripMenuItem.Text = "Financial Statistics";
            this.financialStatisticsToolStripMenuItem.Click += new System.EventHandler(this.financialStatisticsToolStripMenuItem_Click);
            // 
            // stockChangeInformationToolStripMenuItem
            // 
            this.stockChangeInformationToolStripMenuItem.Name = "stockChangeInformationToolStripMenuItem";
            this.stockChangeInformationToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.stockChangeInformationToolStripMenuItem.Text = "Stock Change Information";
            this.stockChangeInformationToolStripMenuItem.Click += new System.EventHandler(this.stockChangeInformationToolStripMenuItem_Click);
            // 
            // transactionTypeToolStripMenuItem
            // 
            this.transactionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionTypeToolStripMenuItem,
            this.viewTransactionTypeToolStripMenuItem});
            this.transactionTypeToolStripMenuItem.Name = "transactionTypeToolStripMenuItem";
            this.transactionTypeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.transactionTypeToolStripMenuItem.Text = "&Transaction Type";
            // 
            // addTransactionTypeToolStripMenuItem
            // 
            this.addTransactionTypeToolStripMenuItem.Name = "addTransactionTypeToolStripMenuItem";
            this.addTransactionTypeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addTransactionTypeToolStripMenuItem.Text = "Add Transaction Type";
            this.addTransactionTypeToolStripMenuItem.Click += new System.EventHandler(this.addTransactionTypeToolStripMenuItem_Click);
            // 
            // viewTransactionTypeToolStripMenuItem
            // 
            this.viewTransactionTypeToolStripMenuItem.Name = "viewTransactionTypeToolStripMenuItem";
            this.viewTransactionTypeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewTransactionTypeToolStripMenuItem.Text = "View Transaction Type";
            this.viewTransactionTypeToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionTypeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHomePage";
            this.Text = "Simple Inventory Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomePage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllWareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientTransactionSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientTransactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockChangeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}