using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAA_project_clinic
{
    public partial class Patient_Registration : MetroFramework.Forms.MetroForm
    {

        SqlConnection Sqlcon;
        public static string userName;
        public Patient_Registration()
        {
            InitializeComponent();
              String str = Properties.Settings.Default.connstr;
            Sqlcon = new SqlConnection(str);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            comboxblood.Items.Add("O -ve");
            comboxblood.Items.Add("O +ve");
            comboxblood.Items.Add("A +ve");
            comboxblood.Items.Add("A -ve");
            comboxblood.Items.Add("B +ve");
            comboxblood.Items.Add("B -ve");
            comboxblood.Items.Add("AB +ve");
            comboxblood.Items.Add("AB -ve");

            comboxReligion.Items.Add("Muslim");
            comboxReligion.Items.Add("Hindu");
            comboxReligion.Items.Add("Christian");
            comboxgender.Items.Add("Male");
            comboxgender.Items.Add("Female");
        }

        private void buttonExit_patient_reg_Click(object sender, EventArgs e)
        {
            Main_Form mf = new Main_Form(userName);
            this.Hide();
            mf.ShowDialog();
            this.Close();
        }

        private void materialSingleLineTextField3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Insert
            string Query = "Insert into [Patient] ( CaNo , Name, Designation , Email , Address, Nic, city , Mobile , Religion , Gender , Age , Problem, BloodGroup) values('" + textBoxCaano.Text + "','" + textboxpname.Text + "','" + TextboxDesgination.Text + "','" + textboxemail.Text + "','" + textboxaddress.Text + "','" + textboxnic.Text + "','" + textboxcity.Text + "','" + textboxconatchno.Text + "','" + comboxReligion.Text + "','" + comboxgender.Text + "','" + textboxage.Text + "','" + textboxproblem.Text + "','" + comboxblood.Text + "');";
            Sqlcon.Open ();
            MessageBox.Show(Query);

            SqlCommand sqlCmd = new SqlCommand(Query, Sqlcon);

            if (sqlCmd.ExecuteNonQuery() > 0)
            {
            MessageBox.Show("Patient Information Saved!");
            }
           Sqlcon.Close();

            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_Form dr = new Main_Form(userName);
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }
        }

        

    }

