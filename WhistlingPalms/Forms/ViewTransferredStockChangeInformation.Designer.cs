namespace WhistlingPalms
{
    partial class ViewTransferredStockChangeInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransferredStockChangeInformation));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvToWareHouseStockInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblFromWareHouse = new System.Windows.Forms.Label();
            this.dgvFromWareHouseStockInfo = new System.Windows.Forms.DataGridView();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToWareHouse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToWareHouseStockInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromWareHouseStockInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvToWareHouseStockInfo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvFromWareHouseStockInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 411);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvToWareHouseStockInfo
            // 
            this.dgvToWareHouseStockInfo.AllowUserToAddRows = false;
            this.dgvToWareHouseStockInfo.AllowUserToDeleteRows = false;
            this.dgvToWareHouseStockInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToWareHouseStockInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvToWareHouseStockInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToWareHouseStockInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvToWareHouseStockInfo.Location = new System.Drawing.Point(3, 258);
            this.dgvToWareHouseStockInfo.Name = "dgvToWareHouseStockInfo";
            this.dgvToWareHouseStockInfo.RowHeadersVisible = false;
            this.dgvToWareHouseStockInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToWareHouseStockInfo.Size = new System.Drawing.Size(505, 99);
            this.dgvToWareHouseStockInfo.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransactQuantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Transact Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OldQuantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Old Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NewQuantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "New Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 45);
            this.panel2.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(325, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(421, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.lblFromWareHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From WareHouse : ";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(71, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(11, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = " ";
            // 
            // lblFromWareHouse
            // 
            this.lblFromWareHouse.AutoSize = true;
            this.lblFromWareHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromWareHouse.Location = new System.Drawing.Point(117, 56);
            this.lblFromWareHouse.Name = "lblFromWareHouse";
            this.lblFromWareHouse.Size = new System.Drawing.Size(11, 13);
            this.lblFromWareHouse.TabIndex = 2;
            this.lblFromWareHouse.Text = " ";
            // 
            // dgvFromWareHouseStockInfo
            // 
            this.dgvFromWareHouseStockInfo.AllowUserToAddRows = false;
            this.dgvFromWareHouseStockInfo.AllowUserToDeleteRows = false;
            this.dgvFromWareHouseStockInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromWareHouseStockInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cost,
            this.TransactQuantity,
            this.OldQuantity,
            this.NewQuantity});
            this.dgvFromWareHouseStockInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFromWareHouseStockInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFromWareHouseStockInfo.Location = new System.Drawing.Point(3, 93);
            this.dgvFromWareHouseStockInfo.Name = "dgvFromWareHouseStockInfo";
            this.dgvFromWareHouseStockInfo.RowHeadersVisible = false;
            this.dgvFromWareHouseStockInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFromWareHouseStockInfo.Size = new System.Drawing.Size(505, 99);
            this.dgvFromWareHouseStockInfo.TabIndex = 0;
            this.dgvFromWareHouseStockInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFromWareHouseStockInfo_CellEndEdit);
            this.dgvFromWareHouseStockInfo.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFromWareHouseStockInfo_CellValidated);
            this.dgvFromWareHouseStockInfo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvFromWareHouseStockInfo_CellValidating);
            this.dgvFromWareHouseStockInfo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFromWareHouseStockInfo_EditingControlShowing);
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactQuantity
            // 
            this.TransactQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactQuantity.DataPropertyName = "TransactQuantity";
            this.TransactQuantity.HeaderText = "Transact Qty";
            this.TransactQuantity.Name = "TransactQuantity";
            this.TransactQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OldQuantity
            // 
            this.OldQuantity.DataPropertyName = "OldQuantity";
            this.OldQuantity.HeaderText = "Old Qty";
            this.OldQuantity.Name = "OldQuantity";
            this.OldQuantity.ReadOnly = true;
            this.OldQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NewQuantity
            // 
            this.NewQuantity.DataPropertyName = "NewQuantity";
            this.NewQuantity.HeaderText = "New Qty";
            this.NewQuantity.Name = "NewQuantity";
            this.NewQuantity.ReadOnly = true;
            this.NewQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblToWareHouse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 54);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To WareHouse : ";
            // 
            // lblToWareHouse
            // 
            this.lblToWareHouse.AutoSize = true;
            this.lblToWareHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToWareHouse.Location = new System.Drawing.Point(107, 29);
            this.lblToWareHouse.Name = "lblToWareHouse";
            this.lblToWareHouse.Size = new System.Drawing.Size(11, 13);
            this.lblToWareHouse.TabIndex = 2;
            this.lblToWareHouse.Text = " ";
            // 
            // ViewTransferredStockChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTransferredStockChangeInformation";
            this.Text = "View Transferred Stock Change Information";
            this.Load += new System.EventHandler(this.ViewTransferredStockChangeInformation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToWareHouseStockInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromWareHouseStockInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblFromWareHouse;
        private System.Windows.Forms.DataGridView dgvFromWareHouseStockInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToWareHouse;
        private System.Windows.Forms.DataGridView dgvToWareHouseStockInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}