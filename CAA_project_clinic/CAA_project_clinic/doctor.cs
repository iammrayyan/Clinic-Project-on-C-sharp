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
    public partial class doctor : MetroFramework.Forms.MetroForm
    {
        SqlConnection Sqlcon;
        public static string userName;
        public doctor()
        {
            
            InitializeComponent();
            String str = Properties.Settings.Default.connstr;
            Sqlcon = new SqlConnection(str);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Insert
            string Query = "Insert into [Doctor] ( CaNo , Name, Category , Nic , Address, Mobile, Email , ConsultingHour) values('" + textboxCaano.Text + "','" + textboxName.Text + "','" + comboxcategory.Text + "','" + textboxNic.Text + "','" + textboxAddsress.Text + "','" + textboxMobile.Text + "','" + textboxEmail.Text + "','" + textboxconsulting.Text + "');";
            Sqlcon.Open();
            MessageBox.Show(Query);

            SqlCommand sqlCmd = new SqlCommand(Query, Sqlcon);

            if (sqlCmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Doctor Information Saved!");
            }
            Sqlcon.Close();
        }

        private void buttonExit_patient_reg_Click(object sender, EventArgs e)
        {
            Main_Form dr = new Main_Form(userName);
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            comboxcategory.Items.Add("General Physician");
            comboxcategory.Items.Add("Cardiologist");
            comboxcategory.Items.Add("Emergency Medicine Specialists");
            comboxcategory.Items.Add("General Surgeons");
        }

        private void doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
