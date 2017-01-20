using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WhistlingPalms
{
    public enum ErrorStates
    {
        Error = 0,
        Success = 1,
        Failure = 2,
        Cancelled = 3
    }

    class clsDatabaseConfig
    {
        #region Public Properties

        public string ServerName { get; set; }
        public bool IsIntegratedSecurity { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsNewDatabase { get; set; }
        public string NewDatabaseName { get; set; }
        public string NewDatabaseLocation { get; set; }
        public string AttachDBFileName { get; set; }

        #endregion

        #region Constructors

        public clsDatabaseConfig()
        {
            ServerName = "";
            IsIntegratedSecurity = true;
            UserName = "";
            Password = "";
            IsNewDatabase = false;
            NewDatabaseName = "";
            NewDatabaseLocation = "";
            AttachDBFileName = "";
        }

        public clsDatabaseConfig(string pServerName, bool pIsIntegratedSecurity, string pUserName, string pPassword,
            bool pIsNewDatabase, string pNewDatabaseName, string pNewDatabaseLocation, string pAttachDBFileName)
        {
            ServerName = pServerName;
            IsIntegratedSecurity = pIsIntegratedSecurity;
            UserName = pUserName;
            Password = pPassword;
            IsNewDatabase = pIsNewDatabase;
            NewDatabaseName = pNewDatabaseName;
            NewDatabaseLocation = pNewDatabaseLocation;
            AttachDBFileName = pAttachDBFileName;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Verifies if the DatabaseName passed in argument is attached to the server.
        /// </summary>
        /// <param name="strDatabaseName">Database Name to check if attached.</param>
        /// <returns>
        /// Success      : If database is attached.
        /// Failure      : If database is not attached.
        /// ErrorMessage : Any other error that might have occured while verifying.
        /// </returns>
        private string IsDatabaseAttached(string strDatabaseName)
        {
            string errorMessage = ErrorStates.Success.ToString();

            SqlConnection conn = new SqlConnection();
            string sql = "SELECT name FROM sys.databases WHERE name NOT IN ('master','tempdb','model','msdb') ORDER BY name";

            conn.ConnectionString = GetConnectionString("master", false);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                errorMessage = ErrorStates.Failure.ToString();
                while (rdr.Read())
                {
                    if (rdr.GetValue(0).ToString() == strDatabaseName)
                    {
                        errorMessage = ErrorStates.Success.ToString();
                        break;
                    }
                }
                rdr.Close();
                return errorMessage;
            }
            catch (Exception ex)
            {
                string sMessage = ex.Message;
                if (ex.Message.Contains("permission denied"))
                {
                    sMessage = "The account that you're connecting to SQL Server with is not allowed to create a Database. " +
                               "To correct this, you can use SQL Authentication";
                }
                errorMessage = sMessage;
                return errorMessage;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Gets the connection string to connect to database name passed in argument
        /// </summary>
        /// <param name="DBName">Database Name to connect to.</param>
        /// <returns>
        /// Connection string to connect to the database passed in argument
        /// </returns>
        private string GetConnectionString(string DBName, bool isAttachDBFileName)
        {
            String sCString = "Server='" + ServerName + "';";
            if (isAttachDBFileName)
            {
                sCString += "AttachDBFileName='" + DBName + "';";
                sCString += "Initial Catalog='" + DBName + "';";
            }
            else
            {
                sCString += "Initial Catalog='" + DBName + "';";
            }

            if (IsIntegratedSecurity)
            {
                sCString += "Integrated Security=true;";
            }
            else
            {
                sCString += "user id='" + UserName + "'; Password='" + Password + "';";
            }
            return sCString;
        }

        /// <summary>
        /// Gets the execution plan for executing the complete script
        /// </summary>
        /// <param name="scriptFilePath">File Path to the script to be executed</param>
        /// <returns>
        /// Execution plan
        /// </returns>
        private string[] GetExecutionPlan(string sql)
        {
            Regex regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return regex.Split(sql);
        }

        /// <summary>
        /// Executes the script mentioned in the script parameter into the database
        /// configured in the class's instance
        /// </summary>
        /// <param name="scriptSQL">Script to be executed</param>
        /// <returns>
        /// Success      : Script executed successfully
        /// ErrorMessage : Error that occured while executing the script
        /// </returns>
        private string ExecuteScript(string scriptSQL)
        {
            string errorMessage = ErrorStates.Success.ToString();

            SqlConnection conn = new SqlConnection();
            if (IsNewDatabase)
                conn.ConnectionString = GetConnectionString(NewDatabaseLocation + "\\" + NewDatabaseName, true);
            else
                conn.ConnectionString = GetConnectionString(AttachDBFileName, true);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


            SqlCommand cmd = new SqlCommand("", conn);
            String[] statements = GetExecutionPlan(scriptSQL);
            foreach (string statement in statements)
            {
                String sql = statement;
                try
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                    break;
                }
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return errorMessage;
        }

        /// <summary>
        /// Gets the schema verification script from the installation script generated by publishing
        /// </summary>
        /// <param name="installScript">Installation script generated by publishing</param>
        /// <returns>
        /// Schema verification script
        /// </returns>
        private string GetSchemaVerificationScript(string installScript)
        {
            StringBuilder verificationSQL = new StringBuilder();
            Regex r = new Regex(@"^IF NOT EXISTS .* OBJECT_ID\(N'(.*)'\) .*", RegexOptions.Multiline);
            MatchCollection matches = r.Matches(installScript);
            foreach (Match m in matches)
            {
                verificationSQL.Append(m.Value + Environment.NewLine);
                verificationSQL.Append("BEGIN" + Environment.NewLine);
                verificationSQL.Append("RAISERROR('" + m.Groups[1].Value + " was not found in the database', 11, 1)" + Environment.NewLine);
                verificationSQL.Append("END" + Environment.NewLine);
                verificationSQL.Append("GO" + Environment.NewLine);
            }

            return verificationSQL.ToString();
        }

        #endregion

        #region Public Methods

        public string IsNewDatabaseAttached()
        {
            return IsDatabaseAttached(NewDatabaseLocation + "\\" + NewDatabaseName);
        }

        public string IsExistingDatabaseAttached()
        {
            return IsDatabaseAttached(AttachDBFileName);
        }

        public string GetConnectionString()
        {
            if (IsNewDatabase)
                return GetConnectionString(NewDatabaseLocation + "\\" + NewDatabaseName, true);
            else
                return GetConnectionString(AttachDBFileName, true);
        }

        /// <summary>
        /// Checks if the server name is valid and responsive by connecting to master database
        /// </summary>
        /// <returns>
        /// Success      : If server is valid
        /// ErrorMessage : If server is invalid
        /// </returns>
        public string IsServerNameValid()
        {
            string errorMessage = ErrorStates.Success.ToString();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnectionString("master", false);
            try
            {
                conn.Open();
                conn.Close();
                return errorMessage;
            }
            catch (Exception ex)
            {
                string sMessage = ex.Message;
                if (ex.Message.ToLower().Contains("permission denied"))
                {
                    sMessage = "The account that you're connecting to SQL Server with is not allowed to read master database. " +
                               "To correct this, you can use SQL Authentication";
                }
                errorMessage = sMessage;
                return errorMessage;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Tries to attach the existing databasename supplied in 
        /// AttachDBFileName field of the class's instance
        /// </summary>
        /// <returns>
        /// Success      : If database was attached successfully
        /// ErrorMessage : If database attach failed
        /// </returns>
        public string AttachExistingDatabase()
        {
            string errorMessage = ErrorStates.Success.ToString();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnectionString(AttachDBFileName, true);
            try
            {
                conn.Open();
                conn.Close();
                return errorMessage;
            }
            catch (Exception ex)
            {
                string sMessage = ex.Message;
                if (ex.Message.ToLower().Contains("permission denied"))
                {
                    sMessage = "The account that you're connecting to SQL Server with is not allowed to read master database. " +
                               "To correct this, you can use SQL Authentication";
                }
                errorMessage = sMessage;
                return errorMessage;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Creates and Attaches new database specified by NewDatabaseName and NewDatabaseLocation
        /// </summary>
        /// <returns>
        /// Success      : Successfully created the database
        /// ErrorMessage : Any other error that might have occured while creating DB or verifying if it is attached.
        /// </returns>
        public string CreateNewDatabase()
        {
            string errorMessage = ErrorStates.Success.ToString();
            
            SqlConnection conn = new SqlConnection();
            string sql = "CREATE DATABASE [" + NewDatabaseLocation + "\\" + NewDatabaseName + "] ON  PRIMARY " +
                         "( NAME = N'" + NewDatabaseName + "', FILENAME = N'" + NewDatabaseLocation + "\\" + NewDatabaseName + "' , SIZE = 2752KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB ) " +
                         "LOG ON " +
                         "( NAME = N'" + NewDatabaseName + "_log ', FILENAME = N'" + NewDatabaseLocation + "\\" + System.IO.Path.GetFileNameWithoutExtension(NewDatabaseName) + "_log.ldf' , SIZE = 1024KB , MAXSIZE = UNLIMITED , FILEGROWTH = 512KB) ";

            conn.ConnectionString = GetConnectionString("master", false);
            try
            {
                //Create the new database
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return errorMessage;
            }
            catch (Exception ex)
            {
                string sMessage = ex.Message;
                if (ex.Message.ToLower().Contains("permission denied"))
                {
                    sMessage = "The account that you're connecting to SQL Server with is not allowed to create a Database. " +
                               "To correct this, you can use SQL Authentication";
                }
                errorMessage = sMessage;
                return errorMessage;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Executes the script mentioned in the scriptFilePath onto the database
        /// configured in the class's instance
        /// </summary>
        /// <param name="scriptFilePath">File Path to the script to be executed</param>
        /// <returns>
        /// Success      : Script executed successfully
        /// ErrorMessage : Error that occured while executing the script
        /// </returns>
        public string InstallScriptFile(string scriptFilePath)
        {
            string sql = "";
            string errorMessage = "";

            try
            {
                sql = System.IO.File.ReadAllText(scriptFilePath);
            }
            catch (Exception)
            {
                return "An error occured reading the script file at: " + scriptFilePath;
            }
            
            errorMessage = ExecuteScript(sql);

            if (errorMessage.ToLower().Contains("permission denied"))
            {
                errorMessage = "Your login does not have permission to create schema on your server." +
                           "Make sure that the login information you are using has " +
                           "EXECUTE and CREATE permissions (dbowner) for your SQL Server.";

            }
            else if(errorMessage != ErrorStates.Success.ToString())
            {
                errorMessage = "An error occurred with the install. The application CANNOT be installed into an existing application database. " +
                           "Please be sure to install into an emtpy database only. Error message is: " + errorMessage;
            }
            
            return errorMessage;
        }

        /// <summary>
        /// Verifies the schema in the database
        /// </summary>
        /// <param name="scriptFilePath">File Path to the script containing schema information</param>
        /// Success      : Script executed successfully
        /// ErrorMessage : Error that occured while verifying schema
        /// <returns></returns>
        public string VerifySchema(string scriptFilePath)
        {
            string installSQL = "";
            string verificationSQL = "";

            try
            {
                installSQL = System.IO.File.ReadAllText(scriptFilePath);
            }
            catch (Exception)
            {
                return "An error occured reading the script file at: " + scriptFilePath;
            }

            verificationSQL = GetSchemaVerificationScript(installSQL);
            return ExecuteScript(verificationSQL);
        }

        #endregion
    }
}
