namespace Register_Form_Panel
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_cs = new System.Windows.Forms.Label();
            this.label_txt = new System.Windows.Forms.Label();
            this.label_sign_up = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txbx_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbx_surname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txbx_age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txbx_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txbx_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aplication_exit = new System.Windows.Forms.Label();
            this.lbl_name_error = new System.Windows.Forms.Label();
            this.lbl_surname_error = new System.Windows.Forms.Label();
            this.lbl_age_error = new System.Windows.Forms.Label();
            this.lbl_email_error = new System.Windows.Forms.Label();
            this.lbl_password_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label_txt);
            this.panel1.Controls.Add(this.label_cs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 515);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_password_error);
            this.panel2.Controls.Add(this.lbl_email_error);
            this.panel2.Controls.Add(this.lbl_age_error);
            this.panel2.Controls.Add(this.lbl_surname_error);
            this.panel2.Controls.Add(this.lbl_name_error);
            this.panel2.Controls.Add(this.aplication_exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbx_password);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.txbx_email);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.txbx_age);
            this.panel2.Controls.Add(this.lbl_age);
            this.panel2.Controls.Add(this.txbx_surname);
            this.panel2.Controls.Add(this.lbl_surname);
            this.panel2.Controls.Add(this.txbx_name);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.label_sign_up);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 515);
            this.panel2.TabIndex = 1;
            // 
            // label_cs
            // 
            this.label_cs.AutoSize = true;
            this.label_cs.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cs.ForeColor = System.Drawing.Color.White;
            this.label_cs.Location = new System.Drawing.Point(47, 59);
            this.label_cs.Name = "label_cs";
            this.label_cs.Size = new System.Drawing.Size(180, 112);
            this.label_cs.TabIndex = 0;
            this.label_cs.Text = "C#";
            // 
            // label_txt
            // 
            this.label_txt.AutoSize = true;
            this.label_txt.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_txt.ForeColor = System.Drawing.Color.White;
            this.label_txt.Location = new System.Drawing.Point(-3, 216);
            this.label_txt.Name = "label_txt";
            this.label_txt.Size = new System.Drawing.Size(283, 98);
            this.label_txt.TabIndex = 1;
            this.label_txt.Text = "Register Form\r\n        Panel";
            // 
            // label_sign_up
            // 
            this.label_sign_up.AutoSize = true;
            this.label_sign_up.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sign_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label_sign_up.Location = new System.Drawing.Point(6, 26);
            this.label_sign_up.Name = "label_sign_up";
            this.label_sign_up.Size = new System.Drawing.Size(101, 30);
            this.label_sign_up.TabIndex = 0;
            this.label_sign_up.Text = "Sign Up";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lbl_name.Location = new System.Drawing.Point(6, 77);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 21);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "User Name:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbx_name
            // 
            this.txbx_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_name.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_name.HintText = "Full name";
            this.txbx_name.isPassword = false;
            this.txbx_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_name.LineThickness = 3;
            this.txbx_name.Location = new System.Drawing.Point(4, 102);
            this.txbx_name.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(291, 28);
            this.txbx_name.TabIndex = 2;
            this.txbx_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbx_surname
            // 
            this.txbx_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_surname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_surname.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_surname.HintText = "Surname";
            this.txbx_surname.isPassword = false;
            this.txbx_surname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_surname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_surname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_surname.LineThickness = 3;
            this.txbx_surname.Location = new System.Drawing.Point(4, 175);
            this.txbx_surname.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(291, 28);
            this.txbx_surname.TabIndex = 4;
            this.txbx_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lbl_surname.Location = new System.Drawing.Point(3, 150);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(83, 21);
            this.lbl_surname.TabIndex = 3;
            this.lbl_surname.Text = "Surname:";
            // 
            // txbx_age
            // 
            this.txbx_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_age.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_age.HintText = "Your age";
            this.txbx_age.isPassword = false;
            this.txbx_age.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_age.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_age.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_age.LineThickness = 3;
            this.txbx_age.Location = new System.Drawing.Point(4, 250);
            this.txbx_age.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_age.Name = "txbx_age";
            this.txbx_age.Size = new System.Drawing.Size(291, 28);
            this.txbx_age.TabIndex = 6;
            this.txbx_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lbl_age.Location = new System.Drawing.Point(7, 225);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(48, 21);
            this.lbl_age.TabIndex = 5;
            this.lbl_age.Text = "Age:";
            // 
            // txbx_email
            // 
            this.txbx_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_email.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_email.HintText = "email";
            this.txbx_email.isPassword = false;
            this.txbx_email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_email.LineThickness = 3;
            this.txbx_email.Location = new System.Drawing.Point(4, 327);
            this.txbx_email.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(291, 28);
            this.txbx_email.TabIndex = 8;
            this.txbx_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lbl_email.Location = new System.Drawing.Point(6, 302);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 21);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email:";
            // 
            // txbx_password
            // 
            this.txbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_password.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_password.HintText = "Password";
            this.txbx_password.isPassword = true;
            this.txbx_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txbx_password.LineThickness = 3;
            this.txbx_password.Location = new System.Drawing.Point(4, 404);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(291, 28);
            this.txbx_password.TabIndex = 10;
            this.txbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lbl_password.Location = new System.Drawing.Point(6, 379);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(86, 21);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aplication_exit
            // 
            this.aplication_exit.AutoSize = true;
            this.aplication_exit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aplication_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.aplication_exit.Location = new System.Drawing.Point(280, 0);
            this.aplication_exit.Name = "aplication_exit";
            this.aplication_exit.Size = new System.Drawing.Size(28, 30);
            this.aplication_exit.TabIndex = 12;
            this.aplication_exit.Text = "X";
            this.aplication_exit.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_name_error
            // 
            this.lbl_name_error.AutoSize = true;
            this.lbl_name_error.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_name_error.Location = new System.Drawing.Point(10, 134);
            this.lbl_name_error.Name = "lbl_name_error";
            this.lbl_name_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_name_error.TabIndex = 13;
            // 
            // lbl_surname_error
            // 
            this.lbl_surname_error.AutoSize = true;
            this.lbl_surname_error.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_surname_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_surname_error.Location = new System.Drawing.Point(10, 209);
            this.lbl_surname_error.Name = "lbl_surname_error";
            this.lbl_surname_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_surname_error.TabIndex = 14;
            // 
            // lbl_age_error
            // 
            this.lbl_age_error.AutoSize = true;
            this.lbl_age_error.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_age_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_age_error.Location = new System.Drawing.Point(10, 282);
            this.lbl_age_error.Name = "lbl_age_error";
            this.lbl_age_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_age_error.TabIndex = 15;
            // 
            // lbl_email_error
            // 
            this.lbl_email_error.AutoSize = true;
            this.lbl_email_error.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_email_error.Location = new System.Drawing.Point(10, 359);
            this.lbl_email_error.Name = "lbl_email_error";
            this.lbl_email_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_email_error.TabIndex = 16;
            // 
            // lbl_password_error
            // 
            this.lbl_password_error.AutoSize = true;
            this.lbl_password_error.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_password_error.Location = new System.Drawing.Point(10, 436);
            this.lbl_password_error.Name = "lbl_password_error";
            this.lbl_password_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_password_error.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_txt;
        private System.Windows.Forms.Label label_cs;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label_sign_up;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_email;
        private System.Windows.Forms.Label lbl_email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_age;
        private System.Windows.Forms.Label lbl_age;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_surname;
        private System.Windows.Forms.Label lbl_surname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label aplication_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_password_error;
        private System.Windows.Forms.Label lbl_email_error;
        private System.Windows.Forms.Label lbl_age_error;
        private System.Windows.Forms.Label lbl_surname_error;
        private System.Windows.Forms.Label lbl_name_error;
    }
}

