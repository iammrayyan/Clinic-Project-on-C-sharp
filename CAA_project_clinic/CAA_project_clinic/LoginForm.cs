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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection Sqlcon;
        public static string userName;
        public LoginForm()
        {
            InitializeComponent();
            String str = Properties.Settings.Default.connstr;
            Sqlcon = new SqlConnection(str);
        } 
     
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
             string qurey = "Select UserId ,Name, Role from userTable where Name='" + TextBoxUsername.Text + "'and password = '" + TextBoxPassword.Text + "'; ";
            Sqlcon.Open();
            SqlCommand cmd = new SqlCommand(qurey, Sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Program.UserId = dr.GetInt32(0);
                    Program.Name = dr.GetString(1);
                    Program.Role = dr.GetString(2);
                }

                if (Program.Role == "admin" || Program.Role == "Admin")
                    MessageBox.Show("Login Succesfull admin");
                else
                    MessageBox.Show("Login Succesfull user");
                
                userName = Program.Name;

                Main_Form mf = new Main_Form(userName);
                this.Hide();
                mf.ShowDialog();
                this.Close();

                
            }
            else
            {
                labelerror.Text = "Invalid Username/Password";
                labelerror.Show();
            }

            Sqlcon.Close();


        }
        private bool ValidateData() //Valdiation
        {
            if (TextBoxUsername.Text == "" || (TextBoxPassword.Text == "" && TextBoxPassword.Text.Length < 4))
            {
                labelerror.Text = "Please enter all fields.";
                labelerror.Show();
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
