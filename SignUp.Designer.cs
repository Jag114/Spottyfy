namespace Spottyfy
{
    partial class SignUp
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
            this.panel_signup_window = new System.Windows.Forms.Panel();
            this.button_signup_login_window = new System.Windows.Forms.Button();
            this.button_exit_signup_window = new System.Windows.Forms.Button();
            this.label_failed_signup_window = new System.Windows.Forms.Label();
            this.button_cancel_signup_window = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.input_password_signup_window = new System.Windows.Forms.TextBox();
            this.input_username_signup_window = new System.Windows.Forms.TextBox();
            this.label_password_signup_window = new System.Windows.Forms.Label();
            this.label_user_signup_window = new System.Windows.Forms.Label();
            this.input_repeatpassword_signup_window = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_repeatpassword_signup_window = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.input_email_signup_window = new System.Windows.Forms.TextBox();
            this.label_email_signup_window = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.checkBox_agreement_signup_window = new System.Windows.Forms.CheckBox();
            this.checkBox_newsletter_signup_window = new System.Windows.Forms.CheckBox();
            this.panel_signup_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_signup_window
            // 
            this.panel_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel_signup_window.Controls.Add(this.checkBox_newsletter_signup_window);
            this.panel_signup_window.Controls.Add(this.checkBox_agreement_signup_window);
            this.panel_signup_window.Controls.Add(this.panel8);
            this.panel_signup_window.Controls.Add(this.panel7);
            this.panel_signup_window.Controls.Add(this.label_email_signup_window);
            this.panel_signup_window.Controls.Add(this.input_email_signup_window);
            this.panel_signup_window.Controls.Add(this.panel6);
            this.panel_signup_window.Controls.Add(this.label_repeatpassword_signup_window);
            this.panel_signup_window.Controls.Add(this.panel1);
            this.panel_signup_window.Controls.Add(this.input_repeatpassword_signup_window);
            this.panel_signup_window.Controls.Add(this.button_signup_login_window);
            this.panel_signup_window.Controls.Add(this.button_exit_signup_window);
            this.panel_signup_window.Controls.Add(this.label_failed_signup_window);
            this.panel_signup_window.Controls.Add(this.button_cancel_signup_window);
            this.panel_signup_window.Controls.Add(this.panel5);
            this.panel_signup_window.Controls.Add(this.panel4);
            this.panel_signup_window.Controls.Add(this.panel3);
            this.panel_signup_window.Controls.Add(this.panel2);
            this.panel_signup_window.Controls.Add(this.input_password_signup_window);
            this.panel_signup_window.Controls.Add(this.input_username_signup_window);
            this.panel_signup_window.Controls.Add(this.label_password_signup_window);
            this.panel_signup_window.Controls.Add(this.label_user_signup_window);
            this.panel_signup_window.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.panel_signup_window.Location = new System.Drawing.Point(-2, -3);
            this.panel_signup_window.Name = "panel_signup_window";
            this.panel_signup_window.Size = new System.Drawing.Size(799, 650);
            this.panel_signup_window.TabIndex = 1;
            this.panel_signup_window.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_signup_window_Paint);
            // 
            // button_signup_login_window
            // 
            this.button_signup_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_signup_login_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signup_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_signup_login_window.Location = new System.Drawing.Point(406, 575);
            this.button_signup_login_window.Name = "button_signup_login_window";
            this.button_signup_login_window.Size = new System.Drawing.Size(310, 50);
            this.button_signup_login_window.TabIndex = 13;
            this.button_signup_login_window.Text = "Sign up";
            this.button_signup_login_window.UseVisualStyleBackColor = false;
            this.button_signup_login_window.Click += new System.EventHandler(this.button_signup_login_window_Click);
            // 
            // button_exit_signup_window
            // 
            this.button_exit_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_exit_signup_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_exit_signup_window.Location = new System.Drawing.Point(280, 575);
            this.button_exit_signup_window.Name = "button_exit_signup_window";
            this.button_exit_signup_window.Size = new System.Drawing.Size(120, 50);
            this.button_exit_signup_window.TabIndex = 12;
            this.button_exit_signup_window.Text = "Close";
            this.button_exit_signup_window.UseVisualStyleBackColor = false;
            this.button_exit_signup_window.Click += new System.EventHandler(this.button_exit_signup_window_Click);
            // 
            // label_failed_signup_window
            // 
            this.label_failed_signup_window.AutoSize = true;
            this.label_failed_signup_window.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_failed_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_failed_signup_window.Location = new System.Drawing.Point(188, 104);
            this.label_failed_signup_window.Name = "label_failed_signup_window";
            this.label_failed_signup_window.Size = new System.Drawing.Size(464, 29);
            this.label_failed_signup_window.TabIndex = 11;
            this.label_failed_signup_window.Text = "incorrect username and/or password!";
            this.label_failed_signup_window.Visible = false;
            // 
            // button_cancel_signup_window
            // 
            this.button_cancel_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_cancel_signup_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_cancel_signup_window.Location = new System.Drawing.Point(83, 575);
            this.button_cancel_signup_window.Name = "button_cancel_signup_window";
            this.button_cancel_signup_window.Size = new System.Drawing.Size(191, 50);
            this.button_cancel_signup_window.TabIndex = 9;
            this.button_cancel_signup_window.Text = "Cancel";
            this.button_cancel_signup_window.UseVisualStyleBackColor = false;
            this.button_cancel_signup_window.Click += new System.EventHandler(this.button_cancel_signup_window_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel5.Location = new System.Drawing.Point(399, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(398, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(193, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(193, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 1);
            this.panel2.TabIndex = 4;
            // 
            // input_password_signup_window
            // 
            this.input_password_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_password_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_password_signup_window.Location = new System.Drawing.Point(398, 224);
            this.input_password_signup_window.Name = "input_password_signup_window";
            this.input_password_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_password_signup_window.TabIndex = 3;
            this.input_password_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_password_signup_window.UseSystemPasswordChar = true;
            // 
            // input_username_signup_window
            // 
            this.input_username_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_username_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_username_signup_window.Location = new System.Drawing.Point(398, 151);
            this.input_username_signup_window.Name = "input_username_signup_window";
            this.input_username_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_username_signup_window.TabIndex = 2;
            this.input_username_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_username_signup_window.WordWrap = false;
            // 
            // label_password_signup_window
            // 
            this.label_password_signup_window.AutoSize = true;
            this.label_password_signup_window.Location = new System.Drawing.Point(188, 224);
            this.label_password_signup_window.Name = "label_password_signup_window";
            this.label_password_signup_window.Size = new System.Drawing.Size(171, 35);
            this.label_password_signup_window.TabIndex = 1;
            this.label_password_signup_window.Text = "Password";
            // 
            // label_user_signup_window
            // 
            this.label_user_signup_window.AutoSize = true;
            this.label_user_signup_window.Location = new System.Drawing.Point(188, 154);
            this.label_user_signup_window.Name = "label_user_signup_window";
            this.label_user_signup_window.Size = new System.Drawing.Size(179, 35);
            this.label_user_signup_window.TabIndex = 0;
            this.label_user_signup_window.Text = "Username";
            // 
            // input_repeatpassword_signup_window
            // 
            this.input_repeatpassword_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_repeatpassword_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_repeatpassword_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_repeatpassword_signup_window.Location = new System.Drawing.Point(398, 298);
            this.input_repeatpassword_signup_window.Name = "input_repeatpassword_signup_window";
            this.input_repeatpassword_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_repeatpassword_signup_window.TabIndex = 14;
            this.input_repeatpassword_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_repeatpassword_signup_window.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(399, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 1);
            this.panel1.TabIndex = 8;
            // 
            // label_repeatpassword_signup_window
            // 
            this.label_repeatpassword_signup_window.AutoSize = true;
            this.label_repeatpassword_signup_window.Location = new System.Drawing.Point(65, 306);
            this.label_repeatpassword_signup_window.Name = "label_repeatpassword_signup_window";
            this.label_repeatpassword_signup_window.Size = new System.Drawing.Size(294, 35);
            this.label_repeatpassword_signup_window.TabIndex = 15;
            this.label_repeatpassword_signup_window.Text = "Repeat Password";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel6.Location = new System.Drawing.Point(71, 344);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 1);
            this.panel6.TabIndex = 5;
            // 
            // input_email_signup_window
            // 
            this.input_email_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_email_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_email_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_email_signup_window.Location = new System.Drawing.Point(398, 371);
            this.input_email_signup_window.Name = "input_email_signup_window";
            this.input_email_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_email_signup_window.TabIndex = 16;
            this.input_email_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_email_signup_window.UseSystemPasswordChar = true;
            this.input_email_signup_window.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_email_signup_window
            // 
            this.label_email_signup_window.AutoSize = true;
            this.label_email_signup_window.Location = new System.Drawing.Point(240, 373);
            this.label_email_signup_window.Name = "label_email_signup_window";
            this.label_email_signup_window.Size = new System.Drawing.Size(119, 35);
            this.label_email_signup_window.TabIndex = 17;
            this.label_email_signup_window.Text = "E-mail";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel7.Location = new System.Drawing.Point(236, 413);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(123, 1);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel8.Location = new System.Drawing.Point(399, 413);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 1);
            this.panel8.TabIndex = 9;
            // 
            // checkBox_agreement_signup_window
            // 
            this.checkBox_agreement_signup_window.AutoSize = true;
            this.checkBox_agreement_signup_window.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_agreement_signup_window.Location = new System.Drawing.Point(193, 472);
            this.checkBox_agreement_signup_window.Name = "checkBox_agreement_signup_window";
            this.checkBox_agreement_signup_window.Size = new System.Drawing.Size(371, 22);
            this.checkBox_agreement_signup_window.TabIndex = 18;
            this.checkBox_agreement_signup_window.Text = "Plesae fell free to sell my personal data";
            this.checkBox_agreement_signup_window.UseVisualStyleBackColor = true;
            // 
            // checkBox_newsletter_signup_window
            // 
            this.checkBox_newsletter_signup_window.AutoSize = true;
            this.checkBox_newsletter_signup_window.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_newsletter_signup_window.Location = new System.Drawing.Point(193, 500);
            this.checkBox_newsletter_signup_window.Name = "checkBox_newsletter_signup_window";
            this.checkBox_newsletter_signup_window.Size = new System.Drawing.Size(171, 22);
            this.checkBox_newsletter_signup_window.TabIndex = 19;
            this.checkBox_newsletter_signup_window.Text = "I love spam uwu";
            this.checkBox_newsletter_signup_window.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.panel_signup_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingUp";
            this.panel_signup_window.ResumeLayout(false);
            this.panel_signup_window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_signup_window;
        private System.Windows.Forms.Button button_signup_login_window;
        private System.Windows.Forms.Button button_exit_signup_window;
        private System.Windows.Forms.Label label_failed_signup_window;
        private System.Windows.Forms.Button button_cancel_signup_window;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox input_password_signup_window;
        private System.Windows.Forms.TextBox input_username_signup_window;
        private System.Windows.Forms.Label label_password_signup_window;
        private System.Windows.Forms.Label label_user_signup_window;
        private System.Windows.Forms.Label label_repeatpassword_signup_window;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input_repeatpassword_signup_window;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_email_signup_window;
        private System.Windows.Forms.TextBox input_email_signup_window;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox checkBox_agreement_signup_window;
        private System.Windows.Forms.CheckBox checkBox_newsletter_signup_window;
    }
}