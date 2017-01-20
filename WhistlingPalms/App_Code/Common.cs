using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace WhistlingPalms
{
    public enum ActionType
    {
        Addition = 0,
        Deduction = 1,
        Transfer =2
    }

    class Common
    {
        static public void FillProducts(ComboBox cmbProducts, bool IsSelectRowRequired, string strSelectRowText)
        {
            InventoryStoreDataSet.tblProductsDataTable dt = new InventoryStoreDataSet.tblProductsDataTable();
            InventoryStoreDataSetTableAdapters.tblProductsTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblProductsTableAdapter();
            adp.FillActiveProducts(dt);

            if (IsSelectRowRequired)
            {
                InventoryStoreDataSet.tblProductsRow dr1 = dt.NewtblProductsRow();
                dr1.ProductID = 0;
                dr1.ProductName = strSelectRowText;
                dr1.Manufacturer = "";
                dr1.ProductTag1 = "";
                dr1.ProductTag2 = "";
                dr1.Discontinued = true;
                dt.Rows.InsertAt(dr1, 0);
            }

            cmbProducts.DataSource = dt;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";

            // Enable the owner draw on the ComboBox.
            cmbProducts.DrawMode = DrawMode.OwnerDrawFixed;
            // Handle the DrawItem event to draw the items.
            cmbProducts.DrawItem += delegate(object comboBox, DrawItemEventArgs args)
            {
                // Draw the default background
                args.DrawBackground();


                // The ComboBox is bound to a DataTable,
                // so the items are DataRowView objects.
                InventoryStoreDataSet.tblProductsRow drv = (InventoryStoreDataSet.tblProductsRow)(((DataRowView)cmbProducts.Items[args.Index]).Row);

                // Retrieve the value of each column.
                string productName = drv.ProductName;
                string manufacturer = (drv.Manufacturer == null) ? "" : drv.Manufacturer;
                string productTag1 = drv.ProductTag1 == null ? "" : drv.ProductTag1;
                string productTag2 = drv.ProductTag2 == null ? "" : drv.ProductTag2;

                // Get the bounds for the first column
                Rectangle r1 = args.Bounds;
                r1.Width /= 4;

                // Draw the text on the first column
                using (SolidBrush sb = new SolidBrush(args.ForeColor))
                {
                    args.Graphics.DrawString(productName, args.Font, sb, r1);
                }

                // Draw a line to isolate the columns 
                using (Pen p = new Pen(Color.Black))
                {
                    args.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom);
                }

                // Get the bounds for the second column
                Rectangle r2 = args.Bounds;
                r2.X = r1.Right;
                r2.Width /= 4;

                // Draw the text on the second column
                using (SolidBrush sb = new SolidBrush(args.ForeColor))
                {
                    args.Graphics.DrawString(manufacturer, args.Font, sb, r2);
                }

                // Draw a line to isolate the columns 
                using (Pen p = new Pen(Color.Black))
                {
                    args.Graphics.DrawLine(p, r2.Right, 0, r2.Right, r2.Bottom);
                }

                // Get the bounds for the second column
                Rectangle r3 = args.Bounds;
                r3.X = r2.Right;
                r3.Width /= 4;

                // Draw the text on the second column
                using (SolidBrush sb = new SolidBrush(args.ForeColor))
                {
                    args.Graphics.DrawString(productTag1, args.Font, sb, r3);
                }

                // Draw a line to isolate the columns 
                using (Pen p = new Pen(Color.Black))
                {
                    args.Graphics.DrawLine(p, r3.Right, 0, r3.Right, r3.Bottom);
                }

                // Get the bounds for the second column
                Rectangle r4 = args.Bounds;
                r4.X = r3.Right;
                r4.Width /= 4;

                // Draw the text on the second column
                using (SolidBrush sb = new SolidBrush(args.ForeColor))
                {
                    args.Graphics.DrawString(productTag2, args.Font, sb, r4);
                }
            };
        }

        static public void FillWareHouses(ComboBox cmbWareHouse, bool IsSelectRowRequired, string strSelectRowText)
        {
            InventoryStoreDataSet.tblWareHouseDataTable dt = new InventoryStoreDataSet.tblWareHouseDataTable();
            InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblWareHouseTableAdapter();
            adp.Fill(dt);

            if (IsSelectRowRequired)
            {
                InventoryStoreDataSet.tblWareHouseRow dr1 = dt.NewtblWareHouseRow();
                dr1.WareHouseID = 0;
                dr1.WareHouseName = strSelectRowText;
                dt.Rows.InsertAt(dr1, 0);
            }

            cmbWareHouse.DataSource = dt;
            cmbWareHouse.DisplayMember = "WareHouseName";
            cmbWareHouse.ValueMember = "WareHouseID";
        }

        static public void FillClients(ComboBox cmbClient, bool IsSelectRowRequired, string strSelectRowText)
        {
            InventoryStoreDataSet.tblClientDataTable dt = new InventoryStoreDataSet.tblClientDataTable();
            InventoryStoreDataSetTableAdapters.tblClientTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblClientTableAdapter();
            adp.Fill(dt);

            if (IsSelectRowRequired)
            {
                InventoryStoreDataSet.tblClientRow dr1 = dt.NewtblClientRow();
                dr1.ClientID = 0;
                dr1.ClientName = strSelectRowText;
                dr1.IsCustomer = false;
                dr1.IsVendor = false;
                dt.Rows.InsertAt(dr1, 0);
            }

            cmbClient.DataSource = dt;
            cmbClient.DisplayMember = "ClientName";
            cmbClient.ValueMember = "ClientID";
        }

        static public void FillTransactionType(ComboBox cmbWareHouse, bool IsSelectRowRequired, string strSelectRowText)
        {
            InventoryStoreDataSet.tblTransactionTypeDataTable dt = new InventoryStoreDataSet.tblTransactionTypeDataTable();
            InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter adp = new InventoryStoreDataSetTableAdapters.tblTransactionTypeTableAdapter();
            adp.Fill(dt);

            if (IsSelectRowRequired)
            {
                InventoryStoreDataSet.tblTransactionTypeRow dr1 = dt.NewtblTransactionTypeRow();
                dr1.TransactionTypeID = 0;
                dr1.TransactionType = strSelectRowText;
                dr1.ActionType = strSelectRowText;
                dr1.HasClientOrderInformation = false;
                dt.Rows.InsertAt(dr1, 0);
            }

            cmbWareHouse.DataSource = dt;
            cmbWareHouse.DisplayMember = "TransactionType";
            cmbWareHouse.ValueMember = "TransactionTypeID";
        }
    }
}
