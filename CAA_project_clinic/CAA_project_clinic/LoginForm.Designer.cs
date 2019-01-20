namespace CAA_project_clinic
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Loginbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            // 
            // 
            // 
            this.TextBoxUsername.CustomButton.Image = null;
            this.TextBoxUsername.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TextBoxUsername.CustomButton.Name = "";
            this.TextBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxUsername.CustomButton.TabIndex = 1;
            this.TextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxUsername.CustomButton.UseSelectable = true;
            this.TextBoxUsername.CustomButton.Visible = false;
            this.TextBoxUsername.Lines = new string[0];
            this.TextBoxUsername.Location = new System.Drawing.Point(170, 121);
            this.TextBoxUsername.MaxLength = 32767;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PromptText = "Username";
            this.TextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.SelectionLength = 0;
            this.TextBoxUsername.SelectionStart = 0;
            this.TextBoxUsername.ShortcutsEnabled = true;
            this.TextBoxUsername.Size = new System.Drawing.Size(183, 23);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.UseSelectable = true;
            this.TextBoxUsername.WaterMark = "Username";
            this.TextBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxPassword
            // 
            // 
            // 
            // 
            this.TextBoxPassword.CustomButton.Image = null;
            this.TextBoxPassword.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TextBoxPassword.CustomButton.Name = "";
            this.TextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPassword.CustomButton.TabIndex = 1;
            this.TextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPassword.CustomButton.UseSelectable = true;
            this.TextBoxPassword.CustomButton.Visible = false;
            this.TextBoxPassword.Lines = new string[0];
            this.TextBoxPassword.Location = new System.Drawing.Point(170, 165);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.PromptText = "Password";
            this.TextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.SelectionLength = 0;
            this.TextBoxPassword.SelectionStart = 0;
            this.TextBoxPassword.ShortcutsEnabled = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(183, 23);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.UseSelectable = true;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.WaterMark = "Password";
            this.TextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(483, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Loginbutton
            // 
            this.Loginbutton.ActiveBorderThickness = 1;
            this.Loginbutton.ActiveCornerRadius = 20;
            this.Loginbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Loginbutton.ActiveForecolor = System.Drawing.Color.White;
            this.Loginbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbutton.BackgroundImage")));
            this.Loginbutton.ButtonText = "Login";
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Loginbutton.IdleBorderThickness = 1;
            this.Loginbutton.IdleCornerRadius = 20;
            this.Loginbutton.IdleFillColor = System.Drawing.Color.White;
            this.Loginbutton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Loginbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Loginbutton.Location = new System.Drawing.Point(170, 216);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(181, 41);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbutton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Font = new System.Drawing.Font("Cairo", 8.25F);
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(230, 191);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 20);
            this.labelerror.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 308);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "LoginForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBoxUsername;
        private MetroFramework.Controls.MetroTextBox TextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbutton;
        private System.Windows.Forms.Label labelerror;

    }
}