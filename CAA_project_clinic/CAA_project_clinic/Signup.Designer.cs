namespace CAA_project_clinic
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFullname = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPassConfirm = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxMobileno = new MetroFramework.Controls.MetroTextBox();
            this.Signupbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelerror = new System.Windows.Forms.Label();
            this.TextBoxCAAno = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboxRole = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(213, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new Account";
            // 
            // TextBoxFullname
            // 
            // 
            // 
            // 
            this.TextBoxFullname.CustomButton.Image = null;
            this.TextBoxFullname.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxFullname.CustomButton.Name = "";
            this.TextBoxFullname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxFullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxFullname.CustomButton.TabIndex = 1;
            this.TextBoxFullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxFullname.CustomButton.UseSelectable = true;
            this.TextBoxFullname.CustomButton.Visible = false;
            this.TextBoxFullname.Lines = new string[0];
            this.TextBoxFullname.Location = new System.Drawing.Point(191, 136);
            this.TextBoxFullname.MaxLength = 32767;
            this.TextBoxFullname.Name = "TextBoxFullname";
            this.TextBoxFullname.PasswordChar = '\0';
            this.TextBoxFullname.PromptText = "Full Name";
            this.TextBoxFullname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxFullname.SelectedText = "";
            this.TextBoxFullname.SelectionLength = 0;
            this.TextBoxFullname.SelectionStart = 0;
            this.TextBoxFullname.ShortcutsEnabled = true;
            this.TextBoxFullname.Size = new System.Drawing.Size(266, 23);
            this.TextBoxFullname.TabIndex = 1;
            this.TextBoxFullname.UseSelectable = true;
            this.TextBoxFullname.WaterMark = "Full Name";
            this.TextBoxFullname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxFullname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxPassword
            // 
            // 
            // 
            // 
            this.TextBoxPassword.CustomButton.Image = null;
            this.TextBoxPassword.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxPassword.CustomButton.Name = "";
            this.TextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPassword.CustomButton.TabIndex = 1;
            this.TextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPassword.CustomButton.UseSelectable = true;
            this.TextBoxPassword.CustomButton.Visible = false;
            this.TextBoxPassword.Lines = new string[0];
            this.TextBoxPassword.Location = new System.Drawing.Point(191, 195);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.PromptText = "Password";
            this.TextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.SelectionLength = 0;
            this.TextBoxPassword.SelectionStart = 0;
            this.TextBoxPassword.ShortcutsEnabled = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(266, 23);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.UseSelectable = true;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.WaterMark = "Password";
            this.TextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxEmail
            // 
            // 
            // 
            // 
            this.TextBoxEmail.CustomButton.Image = null;
            this.TextBoxEmail.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxEmail.CustomButton.Name = "";
            this.TextBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxEmail.CustomButton.TabIndex = 1;
            this.TextBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxEmail.CustomButton.UseSelectable = true;
            this.TextBoxEmail.CustomButton.Visible = false;
            this.TextBoxEmail.Lines = new string[0];
            this.TextBoxEmail.Location = new System.Drawing.Point(191, 166);
            this.TextBoxEmail.MaxLength = 32767;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PromptText = "Email";
            this.TextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.SelectionLength = 0;
            this.TextBoxEmail.SelectionStart = 0;
            this.TextBoxEmail.ShortcutsEnabled = true;
            this.TextBoxEmail.Size = new System.Drawing.Size(266, 23);
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.UseSelectable = true;
            this.TextBoxEmail.WaterMark = "Email";
            this.TextBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxPassConfirm
            // 
            // 
            // 
            // 
            this.TextBoxPassConfirm.CustomButton.Image = null;
            this.TextBoxPassConfirm.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxPassConfirm.CustomButton.Name = "";
            this.TextBoxPassConfirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPassConfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPassConfirm.CustomButton.TabIndex = 1;
            this.TextBoxPassConfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPassConfirm.CustomButton.UseSelectable = true;
            this.TextBoxPassConfirm.CustomButton.Visible = false;
            this.TextBoxPassConfirm.Lines = new string[0];
            this.TextBoxPassConfirm.Location = new System.Drawing.Point(191, 225);
            this.TextBoxPassConfirm.MaxLength = 32767;
            this.TextBoxPassConfirm.Name = "TextBoxPassConfirm";
            this.TextBoxPassConfirm.PasswordChar = '●';
            this.TextBoxPassConfirm.PromptText = "Confirm Password";
            this.TextBoxPassConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPassConfirm.SelectedText = "";
            this.TextBoxPassConfirm.SelectionLength = 0;
            this.TextBoxPassConfirm.SelectionStart = 0;
            this.TextBoxPassConfirm.ShortcutsEnabled = true;
            this.TextBoxPassConfirm.Size = new System.Drawing.Size(266, 23);
            this.TextBoxPassConfirm.TabIndex = 4;
            this.TextBoxPassConfirm.UseSelectable = true;
            this.TextBoxPassConfirm.UseSystemPasswordChar = true;
            this.TextBoxPassConfirm.WaterMark = "Confirm Password";
            this.TextBoxPassConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPassConfirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxMobileno
            // 
            // 
            // 
            // 
            this.TextBoxMobileno.CustomButton.Image = null;
            this.TextBoxMobileno.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxMobileno.CustomButton.Name = "";
            this.TextBoxMobileno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxMobileno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxMobileno.CustomButton.TabIndex = 1;
            this.TextBoxMobileno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxMobileno.CustomButton.UseSelectable = true;
            this.TextBoxMobileno.CustomButton.Visible = false;
            this.TextBoxMobileno.Lines = new string[0];
            this.TextBoxMobileno.Location = new System.Drawing.Point(191, 256);
            this.TextBoxMobileno.MaxLength = 32767;
            this.TextBoxMobileno.Name = "TextBoxMobileno";
            this.TextBoxMobileno.PasswordChar = '\0';
            this.TextBoxMobileno.PromptText = "Mobile No";
            this.TextBoxMobileno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxMobileno.SelectedText = "";
            this.TextBoxMobileno.SelectionLength = 0;
            this.TextBoxMobileno.SelectionStart = 0;
            this.TextBoxMobileno.ShortcutsEnabled = true;
            this.TextBoxMobileno.Size = new System.Drawing.Size(266, 23);
            this.TextBoxMobileno.TabIndex = 5;
            this.TextBoxMobileno.UseSelectable = true;
            this.TextBoxMobileno.WaterMark = "Mobile No";
            this.TextBoxMobileno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxMobileno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxMobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMobileno_KeyPress);
            // 
            // Signupbutton
            // 
            this.Signupbutton.ActiveBorderThickness = 1;
            this.Signupbutton.ActiveCornerRadius = 20;
            this.Signupbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Signupbutton.ActiveForecolor = System.Drawing.Color.White;
            this.Signupbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Signupbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Signupbutton.BackgroundImage")));
            this.Signupbutton.ButtonText = "Submit";
            this.Signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signupbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Signupbutton.IdleBorderThickness = 1;
            this.Signupbutton.IdleCornerRadius = 20;
            this.Signupbutton.IdleFillColor = System.Drawing.Color.White;
            this.Signupbutton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Signupbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Signupbutton.Location = new System.Drawing.Point(235, 379);
            this.Signupbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(158, 56);
            this.Signupbutton.TabIndex = 7;
            this.Signupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Font = new System.Drawing.Font("Cairo", 8.25F);
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(326, 346);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 20);
            this.labelerror.TabIndex = 10;
            // 
            // TextBoxCAAno
            // 
            // 
            // 
            // 
            this.TextBoxCAAno.CustomButton.Image = null;
            this.TextBoxCAAno.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.TextBoxCAAno.CustomButton.Name = "";
            this.TextBoxCAAno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxCAAno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxCAAno.CustomButton.TabIndex = 1;
            this.TextBoxCAAno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxCAAno.CustomButton.UseSelectable = true;
            this.TextBoxCAAno.CustomButton.Visible = false;
            this.TextBoxCAAno.Lines = new string[0];
            this.TextBoxCAAno.Location = new System.Drawing.Point(191, 285);
            this.TextBoxCAAno.MaxLength = 32767;
            this.TextBoxCAAno.Name = "TextBoxCAAno";
            this.TextBoxCAAno.PasswordChar = '\0';
            this.TextBoxCAAno.PromptText = "CAA Number";
            this.TextBoxCAAno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCAAno.SelectedText = "";
            this.TextBoxCAAno.SelectionLength = 0;
            this.TextBoxCAAno.SelectionStart = 0;
            this.TextBoxCAAno.ShortcutsEnabled = true;
            this.TextBoxCAAno.Size = new System.Drawing.Size(266, 23);
            this.TextBoxCAAno.TabIndex = 6;
            this.TextBoxCAAno.UseSelectable = true;
            this.TextBoxCAAno.WaterMark = "CAA Number";
            this.TextBoxCAAno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxCAAno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comboxRole
            // 
            this.comboxRole.FormattingEnabled = true;
            this.comboxRole.ItemHeight = 23;
            this.comboxRole.Location = new System.Drawing.Point(191, 314);
            this.comboxRole.Name = "comboxRole";
            this.comboxRole.PromptText = "Role";
            this.comboxRole.Size = new System.Drawing.Size(266, 29);
            this.comboxRole.TabIndex = 12;
            this.comboxRole.UseSelectable = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 452);
            this.Controls.Add(this.comboxRole);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextBoxCAAno);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.TextBoxMobileno);
            this.Controls.Add(this.TextBoxPassConfirm);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox TextBoxFullname;
        private MetroFramework.Controls.MetroTextBox TextBoxPassword;
        private MetroFramework.Controls.MetroTextBox TextBoxEmail;
        private MetroFramework.Controls.MetroTextBox TextBoxPassConfirm;
        private MetroFramework.Controls.MetroTextBox TextBoxMobileno;
        private Bunifu.Framework.UI.BunifuThinButton2 Signupbutton;
        private System.Windows.Forms.Label labelerror;
        private MetroFramework.Controls.MetroTextBox TextBoxCAAno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroComboBox comboxRole;
    }
}