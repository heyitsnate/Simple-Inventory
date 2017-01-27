using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WhistlingPalms.Forms;

namespace WhistlingPalms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmHomePage());
            new MyApp().Run(args);
        }
    }

    public class MyApp : WindowsFormsApplicationBase
    {
        //Sequence of flow:
        // 1. OnInitialize is automatically called by constructor.
        // 2. OnInitialize internally calls OnCreateSplashScreen() to show the splash screen form
        // 3. OnRun is called.
        // 4. OnRun() internally calls OnCreateMainForm() to create the main form and HideSplashScreen() to close the splash screen.
        // Note: Heavy tasks should be done either within OnRun() before calling base.OnRun()
        //       or within OnCreateMainForm() before setting this.MainForm property.
        public MyApp()
        {
            // This ensures the underlying single-SDI framework is employed, 
            // and OnStartupNextInstance is fired
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
            this.MinimumSplashScreenDisplayTime = 0;
        }

        protected override void OnRun()
        {
            //Do the DB Connection and all other heavy tasks here.
            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(WhistlingPalms.Properties.Settings.Default.InventoryStoreConnectionString);
            bool isDBConnected = false;

            try
            {
                cn.Open();
                isDBConnected = true;
            }
            catch (Exception)
            {
                this.HideSplashScreen();
                //MessageBox.Show("Unable to connect to DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmDBSettings frm = new frmDBSettings();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    isDBConnected = false;
                }
                else
                {
                    isDBConnected = true;
                }
                this.ShowSplashScreen();
            }
            finally
            {
                if (cn.State != System.Data.ConnectionState.Closed)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            Thread.Sleep(5000);

            // Run the main application only if DB is connected.
            // Avoiding base.OnRun() => causes OnCreateMainForm() and HideSplashScreen() not to be called.
            // And hence terminates the application.
            if (isDBConnected)
                base.OnRun();
        }

        protected override void OnCreateSplashScreen()
        {           
            this.SplashScreen = new frmSplashScreen();
        }

        protected override void OnCreateMainForm()
        {
            // Do all the heavy tasks here...
            // No tasks need to be done since the same are executed by OnRun() handler

            // Then create the main form, the splash screen will automatically close
            this.MainForm = new frmHomePage();
        }
    }
}