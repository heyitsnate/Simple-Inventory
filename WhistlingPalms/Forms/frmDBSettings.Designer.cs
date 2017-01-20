namespace WhistlingPalms
{
    partial class frmDBSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBSettings));
            this.btnSetupConnection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpServerSelection = new System.Windows.Forms.GroupBox();
            this.btnSetServer = new System.Windows.Forms.Button();
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.rdbSQLServerAuthentication = new System.Windows.Forms.RadioButton();
            this.rdbWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.grpDatabaseSelection = new System.Windows.Forms.GroupBox();
            this.pnlAttachDatabase = new System.Windows.Forms.Panel();
            this.lblAttachDBFileName = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txtDatabaseFile = new System.Windows.Forms.TextBox();
            this.rdbAttachExistingDataBase = new System.Windows.Forms.RadioButton();
            this.rdbNewDataBase = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splcMainForm = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgbProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgwSetServer = new System.ComponentModel.BackgroundWorker();
            this.bgwSetupConnection = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpServerSelection.SuspendLayout();
            this.grpCredentials.SuspendLayout();
            this.grpDatabaseSelection.SuspendLayout();
            this.pnlAttachDatabase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splcMainForm.Panel1.SuspendLayout();
            this.splcMainForm.Panel2.SuspendLayout();
            this.splcMainForm.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetupConnection
            // 
            this.btnSetupConnection.Location = new System.Drawing.Point(377, 8);
            this.btnSetupConnection.Name = "btnSetupConnection";
            this.btnSetupConnection.Size = new System.Drawing.Size(123, 23);
            this.btnSetupConnection.TabIndex = 0;
            this.btnSetupConnection.Text = "&Setup Connection";
            this.btnSetupConnection.UseVisualStyleBackColor = true;
            this.btnSetupConnection.Click += new System.EventHandler(this.btnSetupConnection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(529, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpServerSelection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpDatabaseSelection, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.632153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33788F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.18945F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Configuration Page";
            // 
            // grpServerSelection
            // 
            this.grpServerSelection.Controls.Add(this.btnSetServer);
            this.grpServerSelection.Controls.Add(this.grpCredentials);
            this.grpServerSelection.Controls.Add(this.rdbSQLServerAuthentication);
            this.grpServerSelection.Controls.Add(this.rdbWindowsAuthentication);
            this.grpServerSelection.Controls.Add(this.cmbServer);
            this.grpServerSelection.Controls.Add(this.lblServer);
            this.grpServerSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServerSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServerSelection.Location = new System.Drawing.Point(3, 42);
            this.grpServerSelection.Name = "grpServerSelection";
            this.grpServerSelection.Size = new System.Drawing.Size(629, 157);
            this.grpServerSelection.TabIndex = 0;
            this.grpServerSelection.TabStop = false;
            this.grpServerSelection.Text = "Server Selection";
            // 
            // btnSetServer
            // 
            this.btnSetServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetServer.Location = new System.Drawing.Point(95, 119);
            this.btnSetServer.Name = "btnSetServer";
            this.btnSetServer.Size = new System.Drawing.Size(75, 23);
            this.btnSetServer.TabIndex = 5;
            this.btnSetServer.Text = "Set Server";
            this.btnSetServer.UseVisualStyleBackColor = true;
            this.btnSetServer.Click += new System.EventHandler(this.btnSetServer_Click);
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.lblUserName);
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.txtUserName);
            this.grpCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCredentials.Location = new System.Drawing.Point(309, 22);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new System.Drawing.Size(312, 120);
            this.grpCredentials.TabIndex = 4;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(107, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(13, 43);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(107, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(190, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // rdbSQLServerAuthentication
            // 
            this.rdbSQLServerAuthentication.AutoSize = true;
            this.rdbSQLServerAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSQLServerAuthentication.Location = new System.Drawing.Point(95, 91);
            this.rdbSQLServerAuthentication.Name = "rdbSQLServerAuthentication";
            this.rdbSQLServerAuthentication.Size = new System.Drawing.Size(151, 17);
            this.rdbSQLServerAuthentication.TabIndex = 3;
            this.rdbSQLServerAuthentication.Text = "SQL Server Authentication";
            this.rdbSQLServerAuthentication.UseVisualStyleBackColor = true;
            // 
            // rdbWindowsAuthentication
            // 
            this.rdbWindowsAuthentication.AutoSize = true;
            this.rdbWindowsAuthentication.Checked = true;
            this.rdbWindowsAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWindowsAuthentication.Location = new System.Drawing.Point(95, 63);
            this.rdbWindowsAuthentication.Name = "rdbWindowsAuthentication";
            this.rdbWindowsAuthentication.Size = new System.Drawing.Size(140, 17);
            this.rdbWindowsAuthentication.TabIndex = 2;
            this.rdbWindowsAuthentication.TabStop = true;
            this.rdbWindowsAuthentication.Text = "Windows Authentication";
            this.rdbWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // cmbServer
            // 
            this.cmbServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(95, 31);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(151, 21);
            this.cmbServer.TabIndex = 1;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(14, 34);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(75, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server Name: ";
            // 
            // grpDatabaseSelection
            // 
            this.grpDatabaseSelection.Controls.Add(this.pnlAttachDatabase);
            this.grpDatabaseSelection.Controls.Add(this.rdbAttachExistingDataBase);
            this.grpDatabaseSelection.Controls.Add(this.rdbNewDataBase);
            this.grpDatabaseSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatabaseSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatabaseSelection.Location = new System.Drawing.Point(3, 222);
            this.grpDatabaseSelection.Name = "grpDatabaseSelection";
            this.grpDatabaseSelection.Size = new System.Drawing.Size(629, 101);
            this.grpDatabaseSelection.TabIndex = 4;
            this.grpDatabaseSelection.TabStop = false;
            this.grpDatabaseSelection.Text = "Database Selection";
            // 
            // pnlAttachDatabase
            // 
            this.pnlAttachDatabase.Controls.Add(this.lblAttachDBFileName);
            this.pnlAttachDatabase.Controls.Add(this.btnBrowseFile);
            this.pnlAttachDatabase.Controls.Add(this.txtDatabaseFile);
            this.pnlAttachDatabase.Location = new System.Drawing.Point(0, 56);
            this.pnlAttachDatabase.Name = "pnlAttachDatabase";
            this.pnlAttachDatabase.Size = new System.Drawing.Size(582, 38);
            this.pnlAttachDatabase.TabIndex = 23;
            // 
            // lblAttachDBFileName
            // 
            this.lblAttachDBFileName.AutoSize = true;
            this.lblAttachDBFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachDBFileName.Location = new System.Drawing.Point(13, 12);
            this.lblAttachDBFileName.Name = "lblAttachDBFileName";
            this.lblAttachDBFileName.Size = new System.Drawing.Size(126, 13);
            this.lblAttachDBFileName.TabIndex = 20;
            this.lblAttachDBFileName.Text = "Database File to attach:  ";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(498, 6);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 22;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txtDatabaseFile
            // 
            this.txtDatabaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseFile.Location = new System.Drawing.Point(145, 9);
            this.txtDatabaseFile.Name = "txtDatabaseFile";
            this.txtDatabaseFile.ReadOnly = true;
            this.txtDatabaseFile.Size = new System.Drawing.Size(347, 20);
            this.txtDatabaseFile.TabIndex = 21;
            // 
            // rdbAttachExistingDataBase
            // 
            this.rdbAttachExistingDataBase.AutoSize = true;
            this.rdbAttachExistingDataBase.Checked = true;
            this.rdbAttachExistingDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAttachExistingDataBase.Location = new System.Drawing.Point(309, 33);
            this.rdbAttachExistingDataBase.Name = "rdbAttachExistingDataBase";
            this.rdbAttachExistingDataBase.Size = new System.Drawing.Size(201, 17);
            this.rdbAttachExistingDataBase.TabIndex = 3;
            this.rdbAttachExistingDataBase.TabStop = true;
            this.rdbAttachExistingDataBase.Text = "Browse and use an existing database";
            this.rdbAttachExistingDataBase.UseVisualStyleBackColor = true;
            // 
            // rdbNewDataBase
            // 
            this.rdbNewDataBase.AutoSize = true;
            this.rdbNewDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNewDataBase.Location = new System.Drawing.Point(17, 33);
            this.rdbNewDataBase.Name = "rdbNewDataBase";
            this.rdbNewDataBase.Size = new System.Drawing.Size(205, 17);
            this.rdbNewDataBase.TabIndex = 3;
            this.rdbNewDataBase.Text = "Create and use a new blank database";
            this.rdbNewDataBase.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSetupConnection);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(25, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(20, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dlgOpenFileDialog
            // 
            this.dlgOpenFileDialog.DefaultExt = "mdf";
            this.dlgOpenFileDialog.Filter = "Database Files| *.mdf";
            this.dlgOpenFileDialog.Title = "Select Database File";
            // 
            // splcMainForm
            // 
            this.splcMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcMainForm.Location = new System.Drawing.Point(0, 0);
            this.splcMainForm.Name = "splcMainForm";
            // 
            // splcMainForm.Panel1
            // 
            this.splcMainForm.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splcMainForm.Panel1MinSize = 0;
            // 
            // splcMainForm.Panel2
            // 
            this.splcMainForm.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splcMainForm.Panel2MinSize = 0;
            this.splcMainForm.Size = new System.Drawing.Size(676, 387);
            this.splcMainForm.SplitterDistance = 308;
            this.splcMainForm.SplitterWidth = 1;
            this.splcMainForm.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88296F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.11704F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 387);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database Configuration Page";
            this.label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.pgbProgressBar);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(30, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 300);
            this.panel2.TabIndex = 5;
            this.panel2.UseWaitCursor = true;
            // 
            // pgbProgressBar
            // 
            this.pgbProgressBar.Location = new System.Drawing.Point(34, 219);
            this.pgbProgressBar.Name = "pgbProgressBar";
            this.pgbProgressBar.Size = new System.Drawing.Size(236, 23);
            this.pgbProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbProgressBar.TabIndex = 3;
            this.pgbProgressBar.UseWaitCursor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 250);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(306, 50);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.UseWaitCursor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(145, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "   ";
            this.lblStatus.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhistlingPalms.Properties.Resources.processing;
            this.pictureBox1.Location = new System.Drawing.Point(54, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // bgwSetServer
            // 
            this.bgwSetServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSetServer_DoWork);
            this.bgwSetServer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSetServer_RunWorkerCompleted);
            // 
            // bgwSetupConnection
            // 
            this.bgwSetupConnection.WorkerReportsProgress = true;
            this.bgwSetupConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSetupConnection_DoWork);
            this.bgwSetupConnection.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSetupConnection_ProgressChanged);
            this.bgwSetupConnection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSetupConnection_RunWorkerCompleted);
            // 
            // frmDBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 387);
            this.Controls.Add(this.splcMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure DataBase Settings";
            this.Load += new System.EventHandler(this.frmDBSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpServerSelection.ResumeLayout(false);
            this.grpServerSelection.PerformLayout();
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.grpDatabaseSelection.ResumeLayout(false);
            this.grpDatabaseSelection.PerformLayout();
            this.pnlAttachDatabase.ResumeLayout(false);
            this.pnlAttachDatabase.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splcMainForm.Panel1.ResumeLayout(false);
            this.splcMainForm.Panel2.ResumeLayout(false);
            this.splcMainForm.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetupConnection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpServerSelection;
        private System.Windows.Forms.RadioButton rdbSQLServerAuthentication;
        private System.Windows.Forms.RadioButton rdbWindowsAuthentication;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSetServer;
        private System.Windows.Forms.GroupBox grpCredentials;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpDatabaseSelection;
        private System.Windows.Forms.RadioButton rdbAttachExistingDataBase;
        private System.Windows.Forms.RadioButton rdbNewDataBase;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtDatabaseFile;
        private System.Windows.Forms.Label lblAttachDBFileName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.SplitContainer splcMainForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgwSetServer;
        private System.ComponentModel.BackgroundWorker bgwSetupConnection;
        private System.Windows.Forms.ProgressBar pgbProgressBar;
        private System.Windows.Forms.Panel pnlAttachDatabase;
    }
}