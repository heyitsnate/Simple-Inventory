using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WhistlingPalms.Forms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        UserControl currentControl = null;

        #region "Helper Methods"

        public void LoadControl(string controlFullName, Control contentHolder)
        {
            UserControl uscMainControl = System.Activator.CreateInstance(Type.GetType(controlFullName)) as UserControl;

            if (currentControl != null)
            {
                currentControl.Dispose();
            }

            currentControl = uscMainControl;

            ClearContentControls(contentHolder);
            uscMainControl.Dock = DockStyle.Fill;
            uscMainControl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            contentHolder.Controls.Add(uscMainControl);
        }

        public void ClearContentControls(Control contentHolder)
        {
            foreach (Control c in contentHolder.Controls)
            {
                c.Dispose();
            }
            contentHolder.Controls.Clear();
        }

        #endregion

        #region "Form Events"

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Detach the database from SQL Server instance, if dataset attaches it
            //Get the dataset connection information
            SqlConnection DataStoreConnection = new SqlConnection(Properties.Settings.Default.InventoryStoreConnectionString);

            //Detach only if dataset connection information contains "AttachDbFilename"
            if (DataStoreConnection.ConnectionString.Contains("AttachDbFilename"))
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
                    if (strElement.StartsWith("AttachDbFilename="))
                    {
                        Match m = Regex.Match(strElement, "AttachDbFilename=(.*$)");
                        strDatabaseName = m.Groups[1].Value;
                    }
                }
                if (strDatabaseName.Contains("|DataDirectory|"))
                    strDatabaseName = strDatabaseName.Replace(@"|DataDirectory|\", AppDomain.CurrentDomain.BaseDirectory);

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

        #endregion

        #region "Product Page Events"

        private void tsbtnListProducts_Click(object sender, EventArgs e)
        {
            LoadControl(typeof(ProductList).FullName, pnlProductsContent);
        }

        private void tsbtnNewProduct_Click(object sender, EventArgs e)
        {
            LoadControl(typeof(AddNewProduct).FullName, pnlProductsContent);
        }

        #endregion

        #region "Client Page Events"

        private void tsbtnListCustomers_Click(object sender, EventArgs e)
        {
            LoadControl(typeof(CustomerList).FullName, pnlClientsContent);
        }

        private void tsbtnNewClient_Click(object sender, EventArgs e)
        {
            LoadControl(typeof(AddNewClient).FullName, pnlClientsContent);
        }

        private void tsbtnListVendors_Click(object sender, EventArgs e)
        {
            LoadControl(typeof(VendorList).FullName, pnlClientsContent);
        }

        #endregion
    }
}
