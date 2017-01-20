using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhistlingPalms
{
    public partial class AddNewProduct : Form
    {

        private int ProductID = 0;
        private bool IsUpdateMode = false;
        InventoryStoreDataSetTableAdapters.tblProductsTableAdapter taProducts = new InventoryStoreDataSetTableAdapters.tblProductsTableAdapter();
        InventoryStoreDataSet.tblProductsRow trProductsRow;

        public AddNewProduct()
        {
            InitializeComponent();
            ProductID = 0;
            IsUpdateMode = false;
        }

        public AddNewProduct(int iProductID)
        {
            InitializeComponent();
            ProductID = iProductID;
            IsUpdateMode = true;

            InventoryStoreDataSet.tblProductsDataTable dt = taProducts.GetProductByID(ProductID);
            if (dt.Rows.Count > 0)
            {
                trProductsRow = dt.Rows[0] as InventoryStoreDataSet.tblProductsRow;
            }
        }        

        #region "Helper Methods"

        private void ResetForm()
        {
            productNameTextBox.Text = "";
            descriptionTextBox.Text = "";
            manufacturerTextBox.Text = "";
            productTag1TextBox.Text = "";
            productTag2TextBox.Text = "";
            salePriceTextBox.Text = "";
        }

        private bool SaveProduct()
        {
            try
            {
                TrimTextBoxes();
                if (IsProductValid())
                {
                    Decimal dSalePrice = 0;

                    if (salePriceTextBox.Text != string.Empty)
                    {
                        dSalePrice = Decimal.Parse(salePriceTextBox.Text);
                    }

                    if (IsUpdateMode)
                    {
                        if (taProducts.Update(trProductsRow) > 0)
                        {
                            MessageBox.Show("Product updated successfully", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Product Updation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        } 
                    }
                    else
                    {
                        if (taProducts.Insert(productNameTextBox.Text, descriptionTextBox.Text,
                            manufacturerTextBox.Text, productTag1TextBox.Text, productTag2TextBox.Text,
                            dSalePrice, false) > 0)
                        {
                            MessageBox.Show("Product inserted successfully", "Product Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Product insertion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product insertion failed due to following error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TrimTextBoxes()
        {
            productNameTextBox.Text = productNameTextBox.Text.Trim();
            descriptionTextBox.Text = descriptionTextBox.Text.Trim();
            manufacturerTextBox.Text = manufacturerTextBox.Text.Trim();
            productTag1TextBox.Text = productTag1TextBox.Text.Trim();
            productTag2TextBox.Text = productTag2TextBox.Text.Trim();
            salePriceTextBox.Text = salePriceTextBox.Text.Trim();
        }

        private bool IsProductValid()
        {
            if (productNameTextBox.Text == string.Empty || productNameTextBox.Text == null)
            {
                MessageBox.Show("Product Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (productNameTextBox.Text.Length > 100)
            {
                MessageBox.Show("Product Name cannot be more than 100 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (descriptionTextBox.Text.Length > 1000)
            {
                MessageBox.Show("Description cannot be more than 1000 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (manufacturerTextBox.Text.Length > 200)
            {
                MessageBox.Show("Manufacturer cannot be more than 200 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (productTag1TextBox.Text.Length > 50)
            {
                MessageBox.Show("Product Tag 1 cannot be more than 50 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (productTag2TextBox.Text.Length > 50)
            {
                MessageBox.Show("Product Tag 2 cannot be more than 50 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Decimal dummyDecimal;

            if (salePriceTextBox.Text != string.Empty)
            {
                if (Decimal.TryParse(salePriceTextBox.Text, out dummyDecimal))
                {
                    if (dummyDecimal <= 0)
                    {
                        MessageBox.Show("Sale Price cannot be zero or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid sale price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region "Form Events"

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            if (IsUpdateMode)
            {
                this.Text = "Update Product";
                btnSaveAndNew.Visible = false;
                btnSaveAndClose.Text = "&Update";

                productNameTextBox.DataBindings.Add("Text", trProductsRow, "ProductName");
                descriptionTextBox.DataBindings.Add("Text", trProductsRow, "Description");
                manufacturerTextBox.DataBindings.Add("Text", trProductsRow, "Manufacturer");
                productTag1TextBox.DataBindings.Add("Text", trProductsRow, "ProductTag1");
                productTag2TextBox.DataBindings.Add("Text", trProductsRow, "ProductTag2");
                salePriceTextBox.DataBindings.Add("Text", trProductsRow, "SalePrice");
                chkDiscontinued.DataBindings.Add("Checked", trProductsRow, "Discontinued");
            }
            else
            {
                this.Text = "Add New Product";
                lblDiscontinued.Visible = false;
                chkDiscontinued.Visible = false;
            }
            productNameTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (SaveProduct())
                this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (SaveProduct())
                ResetForm();
        }

        #endregion        
    }
}
