using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using WhistlingPalms.Properties;

namespace WhistlingPalms
{
    public partial class frmDBSettings : Form
    {
        private readonly clsDatabaseConfig objDatabaseConfig = new clsDatabaseConfig();

        public frmDBSettings()
        {
            InitializeComponent();
        }

        private void frmDBSettings_Load(object sender, EventArgs e)
        {
            splcMainForm.Panel2.Hide();
            splcMainForm.Panel1.Show();
            splcMainForm.SplitterDistance = splcMainForm.Width;
            FillSqlServerInstalledInstances();
            grpCredentials.DataBindings.Add("Enabled", rdbSQLServerAuthentication, "Checked");
            pnlAttachDatabase.DataBindings.Add("Visible", rdbAttachExistingDataBase, "Checked");
            grpDatabaseSelection.Visible = false;
            btnSetupConnection.Visible = false;
        }

        #region Helper Methods

        private void FillSqlServerInstalledInstances()
        {
            /// Old Code ///
            //Requires SQLBrowser service to be running.
            //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //System.Data.DataTable table = instance.GetDataSources();
            //foreach (System.Data.DataRow row in table.Rows)
            //{
            //    // Compare the SQL Server name with local computer name
            //    if (row[0].ToString().ToUpper().Equals(System.Net.Dns.GetHostName().ToUpper()))
            //    {
            //        // "row[1]" gives the sql server instance name
            //        comboBox1.Items.Add(row[1]);
            //    }
            //}

            //Doesn't require SQLBrowser service to be running. Better Code.
            cmbServer.Items.Clear();
            var k =
                Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
            foreach (var strServer in (string[]) k.GetValue("InstalledInstances", new string[] {}))
                cmbServer.Items.Add(".\\" + strServer);

            if (cmbServer.Items.Count > 0)
                cmbServer.SelectedIndex = 0;
        }

        private bool IsServerDetailsValid()
        {
            if (cmbServer.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Server Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rdbSQLServerAuthentication.Checked)
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter User Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool IsConnectionDetailsValid()
        {
            if (!IsServerDetailsValid())
                return false;

            if (rdbAttachExistingDataBase.Checked)
            {
                if (!File.Exists(txtDatabaseFile.Text.Trim()))
                {
                    MessageBox.Show("Please choose a valid database file to attach.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (Path.GetExtension(txtDatabaseFile.Text.Trim()).ToLower() != ".mdf")
                {
                    MessageBox.Show("Please choose a valid database file to attach.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Button Events

        private void btnSetupConnection_Click(object sender, EventArgs e)
        {
            if (IsConnectionDetailsValid())
            {
                splcMainForm.Panel1.Hide();
                splcMainForm.Panel2.Show();
                splcMainForm.SplitterDistance = 0;
                pgbProgressBar.Visible = true;
                lblStatus.Text = "Validating Server. Please wait...";

                objDatabaseConfig.ServerName = cmbServer.Text.Trim();
                objDatabaseConfig.IsIntegratedSecurity = rdbWindowsAuthentication.Checked;
                objDatabaseConfig.UserName = txtUserName.Text.Trim();
                objDatabaseConfig.Password = txtPassword.Text.Trim();
                objDatabaseConfig.IsNewDatabase = rdbNewDataBase.Checked;
                objDatabaseConfig.NewDatabaseName = "InventoryStore.mdf";
                objDatabaseConfig.NewDatabaseLocation = Application.UserAppDataPath;
                objDatabaseConfig.AttachDBFileName = txtDatabaseFile.Text.Trim();

                bgwSetupConnection.RunWorkerAsync(objDatabaseConfig);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
                txtDatabaseFile.Text = dlgOpenFileDialog.FileName;
        }

        private void btnSetServer_Click(object sender, EventArgs e)
        {
            if (IsServerDetailsValid())
            {
                splcMainForm.Panel1.Hide();
                splcMainForm.Panel2.Show();
                splcMainForm.SplitterDistance = 0;
                pgbProgressBar.Visible = false;
                lblStatus.Text = "Validating Server. Please wait...";

                objDatabaseConfig.ServerName = cmbServer.Text;
                objDatabaseConfig.IsIntegratedSecurity = rdbWindowsAuthentication.Checked;
                objDatabaseConfig.UserName = txtUserName.Text;
                objDatabaseConfig.Password = txtPassword.Text;

                bgwSetServer.RunWorkerAsync(objDatabaseConfig);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            splcMainForm.Panel2.Hide();
            splcMainForm.Panel1.Show();
            splcMainForm.SplitterDistance = splcMainForm.Width;
            FillSqlServerInstalledInstances();
            grpServerSelection.Enabled = true;
            grpCredentials.DataBindings.Clear();
            grpCredentials.DataBindings.Add("Enabled", rdbSQLServerAuthentication, "Checked");
            pnlAttachDatabase.DataBindings.Clear();
            pnlAttachDatabase.DataBindings.Add("Visible", rdbAttachExistingDataBase, "Checked");
            rdbAttachExistingDataBase.Checked = true;
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtDatabaseFile.Text = "";
            grpDatabaseSelection.Visible = false;
            btnSetupConnection.Visible = false;
        }

        #endregion

        #region BackgroundWorker Events

        private void bgwSetServer_DoWork(object sender, DoWorkEventArgs e)
        {
            var objdb = (clsDatabaseConfig) e.Argument;
            e.Result = objdb.IsServerNameValid();
        }

        private void bgwSetServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var errorMessage = e.Result.ToString();
            if (errorMessage == ErrorStates.Success.ToString())
            {
                grpServerSelection.Enabled = false;
                grpDatabaseSelection.Visible = true;
                btnSetupConnection.Visible = true;
            }
            else
            {
                MessageBox.Show("Following error occurred in validating server." + Environment.NewLine +
                                errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            splcMainForm.Panel2.Hide();
            splcMainForm.Panel1.Show();
            splcMainForm.SplitterDistance = splcMainForm.Width;
            lblStatus.Text = "";
        }

        private void bgwSetupConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            var objdb = (clsDatabaseConfig) e.Argument;
            var errorMessage = "";

            if (objdb.IsNewDatabase)
            {
                bgwSetupConnection.ReportProgress(10, "(1/6) Creating the database file...");
                errorMessage = objdb.CreateNewDatabase();
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Creating the database failed.");
                    e.Result = "Following error occurred while creating the database:" + Environment.NewLine +
                               errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(30, "(2/6) Verifying if database was attached...");
                errorMessage = objdb.IsNewDatabaseAttached();
                if (errorMessage == ErrorStates.Failure.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Database was not attached to the server.");
                    e.Result = "Database was not attached to the server." + Environment.NewLine +
                               "Try attaching it manually and rerun the configuration process";
                    return;
                }
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Verifying the attached database failed.");
                    e.Result = "Following error occurred while verifying the attached database:" + Environment.NewLine +
                               errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(50, "(3/6) Installing schema onto the blank database...");
                errorMessage = objdb.InstallScriptFile(Application.StartupPath + "\\Scripts\\InstallDatabaseSchema.sql");
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Installing schema to the database failed.");
                    e.Result = "Following error occurred while installing schema to the database:" + Environment.NewLine +
                               errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(70, "(4/6) Verifying the integrity of database schema...");
                errorMessage = objdb.VerifySchema(Application.StartupPath + "\\Scripts\\InstallDatabaseSchema.sql");
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Verifying integrity of the database schema failed.");
                    e.Result = "Following error occurred while verifying integrity of the database schema:" +
                               Environment.NewLine + errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(90, "(5/6) Fetching connection settings...");
                Thread.Sleep(500);
                e.Result = "|Success|" + objdb.GetConnectionString();

                bgwSetupConnection.ReportProgress(100, "(6/6) Database connection complete. Opening application...");
                Thread.Sleep(1000);
            }
            else
            {
                bgwSetupConnection.ReportProgress(10, "(1/5) Attaching the database file...");
                errorMessage = objdb.AttachExistingDatabase();
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Attaching the database failed.");
                    e.Result = "Following error occurred while attaching the database:" + Environment.NewLine +
                               errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(30, "(2/5) Verifying if database was attached...");
                errorMessage = objdb.IsExistingDatabaseAttached();
                if (errorMessage == ErrorStates.Failure.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Database was not attached to the server.");
                    e.Result = "Database was not attached to the server." + Environment.NewLine +
                               "Try attaching it manually and rerun the configuration process";
                    return;
                }
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Verifying the attached database failed.");
                    e.Result = "Following error occurred while verifying the attached database:" + Environment.NewLine +
                               errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(50, "(3/5) Verifying the integrity of database schema...");
                errorMessage = objdb.VerifySchema(Application.StartupPath + "\\Scripts\\InstallDatabaseSchema.sql");
                if (errorMessage != ErrorStates.Success.ToString())
                {
                    bgwSetupConnection.ReportProgress(100, "Verifying integrity of the database schema failed.");
                    e.Result = "Following error occurred while verifying integrity of the database schema:" +
                               Environment.NewLine + errorMessage;
                    return;
                }

                bgwSetupConnection.ReportProgress(85, "(4/5) Fetching connection settings...");
                Thread.Sleep(500);
                e.Result = "|Success|" + objdb.GetConnectionString();

                bgwSetupConnection.ReportProgress(100, "(5/5) Database connection complete. Opening application...");
                Thread.Sleep(1000);
            }
        }

        private void bgwSetupConnection_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbProgressBar.Value = e.ProgressPercentage;
            lblStatus.Text = e.UserState.ToString();
        }

        private void bgwSetupConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var errorMessage = e.Result.ToString();
            if (errorMessage.StartsWith("|Success|"))
            {
                Settings.Default.InventoryStoreConnectionString =
                    errorMessage.Substring(9);
                Settings.Default.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            splcMainForm.Panel2.Hide();
            splcMainForm.Panel1.Show();
            splcMainForm.SplitterDistance = splcMainForm.Width;
            lblStatus.Text = "";
        }

        #endregion
    }
}