using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;            // For SQL connection
using System.Windows.Forms;
using System.Text.RegularExpressions;   // For Validation of Email

namespace CAA_project_clinic
{
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        SqlConnection Sqlcon;
        public static string userName;
        public Signup()
        {
            InitializeComponent();
            String str = Properties.Settings.Default.connstr;
            Sqlcon = new SqlConnection(str);
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Signupbutton.Enabled = false;

            if (!ValidateData())
            {
                Signupbutton.Enabled = true;
                return;
            }
            try
            {
                int id = 0;
                string qurey = "Insert into [userTable] (Fullname, Password,Email,Mobile,Role) OUTPUT INSERTED.ID values ('" + TextBoxFullname.Text + "','" + TextBoxEmail.Text + "','" + TextBoxPassword.Text + "','" + TextBoxPassConfirm.Text + "', '" + TextBoxMobileno.Text + "','User');";
                Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(qurey, Sqlcon);
                id = (int)sqlcmd.ExecuteScalar();
                if (id > 0)
                {
                    MessageBox.Show("Sign up Successful");
                    Program.UserId = id;
                    Program.Name = TextBoxFullname.Text;
                    Program.Role = "User";
                }

                else
                {
                    labelerror.Text = "Unknown Error Occured.";
                    labelerror.Show();
                }
                Sqlcon.Close();
            }
            catch (SqlException ex)
            {
                labelerror.Text = "Unknown Error Occured.";
                labelerror.Show();
                // Debug.WriteLine(ex.Message);
            }

            Signupbutton.Enabled = true;
        }
        private bool ValidateData()
        {
            if (TextBoxFullname.Text == "" || TextBoxEmail.Text == "" || TextBoxPassword.Text == "" || TextBoxPassConfirm.Text == "" || TextBoxMobileno.Text == "" || TextBoxCAAno.Text == "")      //Validation for Input in all Fields.
            {
                labelerror.Text = "Please Fill all Fields.";
                labelerror.Show();
                return false;
            }
            else if (TextBoxPassword.Text != TextBoxPassConfirm.Text)       // Validation For Password Matching.
            {

                labelerror.Text = "Password Doesn't Match.";
                labelerror.Show();
                return false;
            }
            else
            {
                return false;
            }
        }

        private void TextBoxMobileno_KeyPress(object sender, KeyPressEventArgs e)   // For Validation of Mobile Number
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
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_Form dr = new Main_Form(userName);
            this.Hide();
            dr.ShowDialog();
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            comboxRole.Items.Add("user");
            comboxRole.Items.Add("admin");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
   }


}