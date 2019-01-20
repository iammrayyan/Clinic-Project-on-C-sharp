using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAA_project_clinic
{
    public partial class Main_Form : MetroFramework.Forms.MetroForm
    {
        public Main_Form(string a)
        {
            InitializeComponent();
            label1.Text = a;
            btnAdduser.Enabled = false;
            btnAdddoctor.Enabled = false;
            adminLabel.Visible = false;
            labelUser.Visible = false;
            if (Program.Role == "admin" || Program.Role == "Admin")
            {
                btnAdduser.Enabled = true;
                btnAdddoctor.Enabled = true;
                adminLabel.Visible = true;
            }
            else if(Program.Role=="User"|| Program.Role=="user")
            {
                labelUser.Visible = true;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Patient_Registration pr = new Patient_Registration();
            this.Hide();
            pr.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Signup dr = new Signup();
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = false;
                panel1.Width = 173;
                panelAnimatior.ShowSync(panel1);
            }
            else
            {
                panel1.Visible = false;
                panel1.Width = 50;
                panelAnimatior.ShowSync(panel1);
            }
        }

        private void btnAdddoctor_Click(object sender, EventArgs e)
        {
            doctor dr = new doctor();
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            LoginForm dr = new LoginForm();
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
