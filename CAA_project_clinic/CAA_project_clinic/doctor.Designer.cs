namespace CAA_project_clinic
{
    partial class doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboxcategory = new MetroFramework.Controls.MetroComboBox();
            this.textboxAddsress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMobile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxNic = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxconsulting = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxCaano = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonExit_patient_reg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboxcategory);
            this.groupBox1.Controls.Add(this.textboxAddsress);
            this.groupBox1.Controls.Add(this.textboxMobile);
            this.groupBox1.Controls.Add(this.textboxNic);
            this.groupBox1.Controls.Add(this.textboxconsulting);
            this.groupBox1.Controls.Add(this.textboxEmail);
            this.groupBox1.Controls.Add(this.textboxName);
            this.groupBox1.Controls.Add(this.textboxCaano);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 14F);
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboxcategory
            // 
            this.comboxcategory.FormattingEnabled = true;
            this.comboxcategory.ItemHeight = 23;
            this.comboxcategory.Location = new System.Drawing.Point(17, 327);
            this.comboxcategory.Name = "comboxcategory";
            this.comboxcategory.PromptText = "Category";
            this.comboxcategory.Size = new System.Drawing.Size(199, 29);
            this.comboxcategory.TabIndex = 2;
            this.comboxcategory.Tag = "";
            this.comboxcategory.UseSelectable = true;
            // 
            // textboxAddsress
            // 
            this.textboxAddsress.Depth = 0;
            this.textboxAddsress.Hint = "Address";
            this.textboxAddsress.Location = new System.Drawing.Point(21, 163);
            this.textboxAddsress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxAddsress.Name = "textboxAddsress";
            this.textboxAddsress.PasswordChar = '\0';
            this.textboxAddsress.SelectedText = "";
            this.textboxAddsress.SelectionLength = 0;
            this.textboxAddsress.SelectionStart = 0;
            this.textboxAddsress.Size = new System.Drawing.Size(195, 23);
            this.textboxAddsress.TabIndex = 1;
            this.textboxAddsress.UseSystemPasswordChar = false;
            // 
            // textboxMobile
            // 
            this.textboxMobile.Depth = 0;
            this.textboxMobile.Hint = "Mobile";
            this.textboxMobile.Location = new System.Drawing.Point(21, 206);
            this.textboxMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMobile.Name = "textboxMobile";
            this.textboxMobile.PasswordChar = '\0';
            this.textboxMobile.SelectedText = "";
            this.textboxMobile.SelectionLength = 0;
            this.textboxMobile.SelectionStart = 0;
            this.textboxMobile.Size = new System.Drawing.Size(195, 23);
            this.textboxMobile.TabIndex = 1;
            this.textboxMobile.UseSystemPasswordChar = false;
            // 
            // textboxNic
            // 
            this.textboxNic.Depth = 0;
            this.textboxNic.Hint = "NIC";
            this.textboxNic.Location = new System.Drawing.Point(21, 123);
            this.textboxNic.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxNic.Name = "textboxNic";
            this.textboxNic.PasswordChar = '\0';
            this.textboxNic.SelectedText = "";
            this.textboxNic.SelectionLength = 0;
            this.textboxNic.SelectionStart = 0;
            this.textboxNic.Size = new System.Drawing.Size(195, 23);
            this.textboxNic.TabIndex = 1;
            this.textboxNic.UseSystemPasswordChar = false;
            // 
            // textboxconsulting
            // 
            this.textboxconsulting.Depth = 0;
            this.textboxconsulting.Hint = "Consulting Hour";
            this.textboxconsulting.Location = new System.Drawing.Point(21, 289);
            this.textboxconsulting.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxconsulting.Name = "textboxconsulting";
            this.textboxconsulting.PasswordChar = '\0';
            this.textboxconsulting.SelectedText = "";
            this.textboxconsulting.SelectionLength = 0;
            this.textboxconsulting.SelectionStart = 0;
            this.textboxconsulting.Size = new System.Drawing.Size(195, 23);
            this.textboxconsulting.TabIndex = 1;
            this.textboxconsulting.UseSystemPasswordChar = false;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Depth = 0;
            this.textboxEmail.Hint = "Email";
            this.textboxEmail.Location = new System.Drawing.Point(21, 246);
            this.textboxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.PasswordChar = '\0';
            this.textboxEmail.SelectedText = "";
            this.textboxEmail.SelectionLength = 0;
            this.textboxEmail.SelectionStart = 0;
            this.textboxEmail.Size = new System.Drawing.Size(195, 23);
            this.textboxEmail.TabIndex = 1;
            this.textboxEmail.UseSystemPasswordChar = false;
            // 
            // textboxName
            // 
            this.textboxName.Depth = 0;
            this.textboxName.Hint = "Name";
            this.textboxName.Location = new System.Drawing.Point(21, 88);
            this.textboxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.Size = new System.Drawing.Size(195, 23);
            this.textboxName.TabIndex = 1;
            this.textboxName.UseSystemPasswordChar = false;
            // 
            // textboxCaano
            // 
            this.textboxCaano.Depth = 0;
            this.textboxCaano.Hint = "CAA Number";
            this.textboxCaano.Location = new System.Drawing.Point(21, 50);
            this.textboxCaano.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxCaano.Name = "textboxCaano";
            this.textboxCaano.PasswordChar = '\0';
            this.textboxCaano.SelectedText = "";
            this.textboxCaano.SelectionLength = 0;
            this.textboxCaano.SelectionStart = 0;
            this.textboxCaano.Size = new System.Drawing.Size(195, 23);
            this.textboxCaano.TabIndex = 0;
            this.textboxCaano.UseSystemPasswordChar = false;
            // 
            // buttonExit_patient_reg
            // 
            this.buttonExit_patient_reg.ActiveBorderThickness = 1;
            this.buttonExit_patient_reg.ActiveCornerRadius = 20;
            this.buttonExit_patient_reg.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.ActiveForecolor = System.Drawing.Color.White;
            this.buttonExit_patient_reg.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit_patient_reg.BackgroundImage")));
            this.buttonExit_patient_reg.ButtonText = "Exit";
            this.buttonExit_patient_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit_patient_reg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit_patient_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.IdleBorderThickness = 1;
            this.buttonExit_patient_reg.IdleCornerRadius = 20;
            this.buttonExit_patient_reg.IdleFillColor = System.Drawing.Color.White;
            this.buttonExit_patient_reg.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.buttonExit_patient_reg.Location = new System.Drawing.Point(207, 439);
            this.buttonExit_patient_reg.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit_patient_reg.Name = "buttonExit_patient_reg";
            this.buttonExit_patient_reg.Size = new System.Drawing.Size(142, 41);
            this.buttonExit_patient_reg.TabIndex = 13;
            this.buttonExit_patient_reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonExit_patient_reg.Click += new System.EventHandler(this.buttonExit_patient_reg_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Submit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(44, 439);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(153, 41);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 510);
            this.Controls.Add(this.buttonExit_patient_reg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuThinButton21);
            this.MaximizeBox = false;
            this.Name = "doctor";
            this.Text = " ";
            this.Load += new System.EventHandler(this.doctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxAddsress;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMobile;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxNic;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxCaano;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxconsulting;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonExit_patient_reg;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private MetroFramework.Controls.MetroComboBox comboxcategory;
    }
}