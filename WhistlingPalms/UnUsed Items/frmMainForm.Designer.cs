namespace WhistlingPalms.Forms
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.tbcMainTabControl = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.tsProducts = new System.Windows.Forms.ToolStrip();
            this.tsbtnListProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNewProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlProductsContent = new System.Windows.Forms.Panel();
            this.tabWareHouse = new System.Windows.Forms.TabPage();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.tblClient = new System.Windows.Forms.TableLayoutPanel();
            this.tsClient = new System.Windows.Forms.ToolStrip();
            this.tsbtnListCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListVendors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNewClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlClientsContent = new System.Windows.Forms.Panel();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabSalesOrder = new System.Windows.Forms.TabPage();
            this.tabPurchaseOrder = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tbcMainTabControl.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tblProducts.SuspendLayout();
            this.tsProducts.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tblClient.SuspendLayout();
            this.tsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMainTabControl
            // 
            this.tbcMainTabControl.Controls.Add(this.tabProducts);
            this.tbcMainTabControl.Controls.Add(this.tabWareHouse);
            this.tbcMainTabControl.Controls.Add(this.tabClient);
            this.tbcMainTabControl.Controls.Add(this.tabInventory);
            this.tbcMainTabControl.Controls.Add(this.tabSalesOrder);
            this.tbcMainTabControl.Controls.Add(this.tabPurchaseOrder);
            this.tbcMainTabControl.Controls.Add(this.tabReports);
            this.tbcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.tbcMainTabControl.Name = "tbcMainTabControl";
            this.tbcMainTabControl.SelectedIndex = 0;
            this.tbcMainTabControl.Size = new System.Drawing.Size(841, 577);
            this.tbcMainTabControl.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tblProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(833, 551);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // tblProducts
            // 
            this.tblProducts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblProducts.ColumnCount = 2;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tblProducts.Controls.Add(this.tsProducts, 1, 0);
            this.tblProducts.Controls.Add(this.pnlProductsContent, 0, 0);
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducts.Location = new System.Drawing.Point(3, 3);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.RowCount = 1;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Size = new System.Drawing.Size(827, 545);
            this.tblProducts.TabIndex = 0;
            // 
            // tsProducts
            // 
            this.tsProducts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnListProducts,
            this.toolStripSeparator1,
            this.tsbtnNewProduct,
            this.toolStripSeparator2});
            this.tsProducts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsProducts.Location = new System.Drawing.Point(656, 1);
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(170, 80);
            this.tsProducts.TabIndex = 0;
            // 
            // tsbtnListProducts
            // 
            this.tsbtnListProducts.AutoSize = false;
            this.tsbtnListProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnListProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnListProducts.Image")));
            this.tsbtnListProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnListProducts.Name = "tsbtnListProducts";
            this.tsbtnListProducts.Size = new System.Drawing.Size(149, 30);
            this.tsbtnListProducts.Text = "List All Products";
            this.tsbtnListProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnListProducts.Click += new System.EventHandler(this.tsbtnListProducts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // tsbtnNewProduct
            // 
            this.tsbtnNewProduct.AutoSize = false;
            this.tsbtnNewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewProduct.Image")));
            this.tsbtnNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewProduct.Name = "tsbtnNewProduct";
            this.tsbtnNewProduct.Size = new System.Drawing.Size(149, 30);
            this.tsbtnNewProduct.Text = "Add New Product";
            this.tsbtnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnNewProduct.Click += new System.EventHandler(this.tsbtnNewProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // pnlProductsContent
            // 
            this.pnlProductsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsContent.Location = new System.Drawing.Point(4, 4);
            this.pnlProductsContent.Name = "pnlProductsContent";
            this.pnlProductsContent.Size = new System.Drawing.Size(648, 537);
            this.pnlProductsContent.TabIndex = 1;
            // 
            // tabWareHouse
            // 
            this.tabWareHouse.Location = new System.Drawing.Point(4, 22);
            this.tabWareHouse.Name = "tabWareHouse";
            this.tabWareHouse.Size = new System.Drawing.Size(833, 551);
            this.tabWareHouse.TabIndex = 2;
            this.tabWareHouse.Text = "Ware House";
            this.tabWareHouse.UseVisualStyleBackColor = true;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.tblClient);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(833, 551);
            this.tabClient.TabIndex = 3;
            this.tabClient.Text = "Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // tblClient
            // 
            this.tblClient.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblClient.ColumnCount = 2;
            this.tblClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tblClient.Controls.Add(this.tsClient, 1, 0);
            this.tblClient.Controls.Add(this.pnlClientsContent, 0, 0);
            this.tblClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblClient.Location = new System.Drawing.Point(0, 0);
            this.tblClient.Name = "tblClient";
            this.tblClient.RowCount = 1;
            this.tblClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblClient.Size = new System.Drawing.Size(833, 551);
            this.tblClient.TabIndex = 1;
            // 
            // tsClient
            // 
            this.tsClient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnListCustomers,
            this.toolStripSeparator3,
            this.tsbtnListVendors,
            this.toolStripSeparator5,
            this.tsbtnNewClient,
            this.toolStripSeparator4});
            this.tsClient.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsClient.Location = new System.Drawing.Point(662, 1);
            this.tsClient.Name = "tsClient";
            this.tsClient.Size = new System.Drawing.Size(170, 119);
            this.tsClient.TabIndex = 0;
            // 
            // tsbtnListCustomers
            // 
            this.tsbtnListCustomers.AutoSize = false;
            this.tsbtnListCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnListCustomers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnListCustomers.Image")));
            this.tsbtnListCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnListCustomers.Name = "tsbtnListCustomers";
            this.tsbtnListCustomers.Size = new System.Drawing.Size(149, 30);
            this.tsbtnListCustomers.Text = "List All Customers";
            this.tsbtnListCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnListCustomers.Click += new System.EventHandler(this.tsbtnListCustomers_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // tsbtnListVendors
            // 
            this.tsbtnListVendors.AutoSize = false;
            this.tsbtnListVendors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnListVendors.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnListVendors.Image")));
            this.tsbtnListVendors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnListVendors.Name = "tsbtnListVendors";
            this.tsbtnListVendors.Size = new System.Drawing.Size(149, 30);
            this.tsbtnListVendors.Text = "List All Vendors";
            this.tsbtnListVendors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnListVendors.Click += new System.EventHandler(this.tsbtnListVendors_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // tsbtnNewClient
            // 
            this.tsbtnNewClient.AutoSize = false;
            this.tsbtnNewClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewClient.Image")));
            this.tsbtnNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewClient.Name = "tsbtnNewClient";
            this.tsbtnNewClient.Size = new System.Drawing.Size(149, 30);
            this.tsbtnNewClient.Text = "Add New Client";
            this.tsbtnNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnNewClient.Click += new System.EventHandler(this.tsbtnNewClient_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // pnlClientsContent
            // 
            this.pnlClientsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientsContent.Location = new System.Drawing.Point(4, 4);
            this.pnlClientsContent.Name = "pnlClientsContent";
            this.pnlClientsContent.Size = new System.Drawing.Size(654, 543);
            this.pnlClientsContent.TabIndex = 1;
            // 
            // tabInventory
            // 
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(833, 551);
            this.tabInventory.TabIndex = 4;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // tabSalesOrder
            // 
            this.tabSalesOrder.Location = new System.Drawing.Point(4, 22);
            this.tabSalesOrder.Name = "tabSalesOrder";
            this.tabSalesOrder.Size = new System.Drawing.Size(833, 551);
            this.tabSalesOrder.TabIndex = 6;
            this.tabSalesOrder.Text = "Sales Order";
            this.tabSalesOrder.UseVisualStyleBackColor = true;
            // 
            // tabPurchaseOrder
            // 
            this.tabPurchaseOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPurchaseOrder.Name = "tabPurchaseOrder";
            this.tabPurchaseOrder.Size = new System.Drawing.Size(833, 551);
            this.tabPurchaseOrder.TabIndex = 7;
            this.tabPurchaseOrder.Text = "Purchase Order";
            this.tabPurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(833, 551);
            this.tabReports.TabIndex = 8;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 577);
            this.Controls.Add(this.tbcMainTabControl);
            this.Name = "frmMainForm";
            this.Text = "Inventory Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.tbcMainTabControl.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tblProducts.ResumeLayout(false);
            this.tblProducts.PerformLayout();
            this.tsProducts.ResumeLayout(false);
            this.tsProducts.PerformLayout();
            this.tabClient.ResumeLayout(false);
            this.tblClient.ResumeLayout(false);
            this.tblClient.PerformLayout();
            this.tsClient.ResumeLayout(false);
            this.tsClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMainTabControl;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabWareHouse;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabSalesOrder;
        private System.Windows.Forms.TabPage tabPurchaseOrder;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsbtnListProducts;
        private System.Windows.Forms.ToolStripButton tsbtnNewProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlProductsContent;
        private System.Windows.Forms.TableLayoutPanel tblClient;
        private System.Windows.Forms.ToolStrip tsClient;
        private System.Windows.Forms.ToolStripButton tsbtnListCustomers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnNewClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel pnlClientsContent;
        private System.Windows.Forms.ToolStripButton tsbtnListVendors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}