using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAA_project_clinic
{
    public partial class Splash_Screen : MetroFramework.Forms.MetroForm
    {
       
        public Splash_Screen()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 50;  //time in millisecond i.e 4 seconds
            timer1.Tick += new EventHandler(timer2_Tick); //timer event handler
            buttonStart.Visible = false;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (metroProgressBar1.Value < 100)
            {
                metroProgressBar1.Value += 5; //increment of 5
                this.metroLabel2.Text = string.Format("{0:p0}", (double)metroProgressBar1.Value / 100);
                metroProgressBar1.Invalidate();
            }
            else
            {
                timer1.Stop();
                buttonStart.Visible = true;
                this.label1.Text= string.Format("Press Start button to Proceed");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           LoginForm mf = new LoginForm(); //on button click open main form
            this.Hide();
            mf.ShowDialog();
            this.Close();                  //pervious form close
        }
       
    }

}
