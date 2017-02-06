using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhistlingPalms.Forms
{
    public partial class frmSplashScreen : Form
    {
        Timer t = new Timer();
        frmHomePage frm = new frmHomePage();

        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;

        Bitmap bmp;
        Graphics g;

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            pbWIDTH = picboxPB.Width;
            pbHEIGHT = picboxPB.Height;

            pbUnit = pbWIDTH / 100.0;

            pbComplete = 0;

            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            t.Interval = 50;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Gray);
            g.FillRectangle(Brushes.MediumPurple, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT));
            g.DrawString(pbComplete + "%", new Font("Arial", pbHEIGHT / 2), Brushes.AliceBlue, new PointF(pbWIDTH /2 - pbHEIGHT, pbHEIGHT / 10));
            picboxPB.Image = bmp;

            pbComplete++;
            if (pbComplete > 100)
            {
                g.Dispose();
                t.Stop();
            }
            if (pbComplete.Equals(10))
            {
                lbl3.Text = String.Format("Starting Modules...");
            }
            if (pbComplete.Equals(40))
            {
                lbl3.Text = String.Format("Loading Modules");
            }
            if (pbComplete.Equals(60))
            {
                lbl3.Text = String.Format("Database Initializing...");
            }

            if (pbComplete.Equals(80))
            {
                lbl3.Text = String.Format("Database Loaded...");
            }
            if (pbComplete.Equals(100))
            {
                frm.Show();
                t.Enabled = false;
                this.Hide();
            }
        }
    }
}
