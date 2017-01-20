using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using WhistlingPalms.Forms;

namespace WhistlingPalms
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Detach the database from SQL Server instance, if dataset attaches it
            //Get the dataset connection information
            SqlConnection DataStoreConnection = new SqlConnection(Properties.Settings.Default.InventoryStoreConnectionString);

            //Detach only if dataset connection information contains "AttachDbFilename"
            if (DataStoreConnection.ConnectionString.ToLower().Contains("attachdbfilename"))
            {
                //Set up a connection to master
                String strMasterConnectionString = "Server='" + DataStoreConnection.DataSource + "';" +
                                                    "Initial Catalog='master';Integrated Security=true;";

                SqlConnection MasterConnection = new SqlConnection(strMasterConnectionString);
                SqlCommand cmd = new SqlCommand("", MasterConnection);

                //Get the database name from dataset connection information
                String strDatabaseName = "";
                String[] ConnectionStringElements = Regex.Split(DataStoreConnection.ConnectionString, ";");
                foreach (string strElement in ConnectionStringElements)
                {
                    if (strElement.ToLower().StartsWith("attachdbfilename="))
                    {
                        Match m = Regex.Match(strElement, "attachdbfilename=(.*$)", RegexOptions.IgnoreCase);
                        strDatabaseName = m.Groups[1].Value;
                        break;
                    }
                }
                if (strDatabaseName.Contains("|DataDirectory|"))
                    strDatabaseName = strDatabaseName.Replace(@"|DataDirectory|\", AppDomain.CurrentDomain.BaseDirectory);

                if (strDatabaseName.StartsWith("'"))
                    strDatabaseName = strDatabaseName.TrimStart(new char[1] { '\'' });
                if (strDatabaseName.EndsWith("'"))
                    strDatabaseName = strDatabaseName.TrimEnd(new char[1] { '\'' });
                
                //Check if the database is still attached
                Boolean isAttached = false;
                try
                {
                    if (MasterConnection.State != ConnectionState.Open)
                    {
                        MasterConnection.Open();
                    }
                    cmd.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name LIKE '" + strDatabaseName + "'";

                    if (cmd.ExecuteScalar().ToString() == "1")
                        isAttached = true;
                    else
                        isAttached = false;
                }
                catch (Exception)
                {
                    //MessageBox.Show("Error detaching the database from server:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (MasterConnection.State == ConnectionState.Open)
                    {
                        MasterConnection.Close();
                    }
                    MasterConnection.Dispose();
                    cmd.Dispose();
                    return;
                }

                //Detach the database if it is attached
                if (isAttached)
                {
                    String[] DetachStatements = new String[2];
                    DetachStatements[0] = "ALTER DATABASE [" + strDatabaseName + "] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    DetachStatements[1] = "EXEC master.dbo.sp_detach_db @dbname = N'" + strDatabaseName + "'";
                    foreach (string strQuery in DetachStatements)
                    {
                        try
                        {
                            if (MasterConnection.State != ConnectionState.Open)
                            {
                                MasterConnection.Open();
                            }
                            cmd.CommandText = strQuery;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("Error detaching the database from server:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (MasterConnection.State == ConnectionState.Open)
                            {
                                MasterConnection.Close();
                            }
                            MasterConnection.Dispose();
                            cmd.Dispose();
                            return;
                        }
                    }
                }

                if (MasterConnection.State == ConnectionState.Open)
                {
                    MasterConnection.Close();
                }
                MasterConnection.Dispose();
                cmd.Dispose();
            }
        }

        private void listAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList frm = new ProductList();            
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct frm = new AddNewProduct();            
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void listAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void listAllVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorList frm = new VendorList();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewClient frm = new AddNewClient();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void listAllWareHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareHouseList frm = new WareHouseList();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void addNewWareHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewWareHouse frm = new AddNewWareHouse();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInventory frm = new ViewInventory();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactions frm = new ViewTransactions();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTransaction frm = new AddNewTransaction();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void currentInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentInventory frm = new CurrentInventory();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void clientTransactionSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTransactionSummary frm = new ClientTransactionSummary();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void clientTransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTransactionDetails frm = new ClientTransactionDetails();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void financialStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialStatistics frm = new FinancialStatistics();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void stockChangeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockChangeInformation frm = new StockChangeInformation();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addTransactionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditTransactionType frm = new AddEditTransactionType();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void viewTransactionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactionType frm = new ViewTransactionType();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();                
        }
    }
}
