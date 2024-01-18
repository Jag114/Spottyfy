namespace Spottyfy
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_login_window = new System.Windows.Forms.Panel();
            this.button_singup_login_window = new System.Windows.Forms.Button();
            this.button_exit_login_window = new System.Windows.Forms.Button();
            this.label_failed_login_window = new System.Windows.Forms.Label();
            this.linkLabel_forgot_password = new System.Windows.Forms.LinkLabel();
            this.button_loggin_window = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.input_password_login_window = new System.Windows.Forms.TextBox();
            this.input_username_login_window = new System.Windows.Forms.TextBox();
            this.label_password_login_window = new System.Windows.Forms.Label();
            this.label_user_login_window = new System.Windows.Forms.Label();
            this.panel_login_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login_window
            // 
            this.panel_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel_login_window.Controls.Add(this.button_singup_login_window);
            this.panel_login_window.Controls.Add(this.button_exit_login_window);
            this.panel_login_window.Controls.Add(this.label_failed_login_window);
            this.panel_login_window.Controls.Add(this.linkLabel_forgot_password);
            this.panel_login_window.Controls.Add(this.button_loggin_window);
            this.panel_login_window.Controls.Add(this.panel5);
            this.panel_login_window.Controls.Add(this.panel4);
            this.panel_login_window.Controls.Add(this.panel3);
            this.panel_login_window.Controls.Add(this.panel2);
            this.panel_login_window.Controls.Add(this.input_password_login_window);
            this.panel_login_window.Controls.Add(this.input_username_login_window);
            this.panel_login_window.Controls.Add(this.label_password_login_window);
            this.panel_login_window.Controls.Add(this.label_user_login_window);
            this.panel_login_window.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.panel_login_window.Location = new System.Drawing.Point(0, 0);
            this.panel_login_window.Name = "panel_login_window";
            this.panel_login_window.Size = new System.Drawing.Size(655, 404);
            this.panel_login_window.TabIndex = 0;
            // 
            // button_singup_login_window
            // 
            this.button_singup_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_singup_login_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_singup_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_singup_login_window.Location = new System.Drawing.Point(12, 333);
            this.button_singup_login_window.Name = "button_singup_login_window";
            this.button_singup_login_window.Size = new System.Drawing.Size(310, 50);
            this.button_singup_login_window.TabIndex = 13;
            this.button_singup_login_window.Text = "Sign up";
            this.button_singup_login_window.UseVisualStyleBackColor = false;
            this.button_singup_login_window.Click += new System.EventHandler(this.button_singup_login_window_Click);
            // 
            // button_exit_login_window
            // 
            this.button_exit_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_exit_login_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_exit_login_window.Location = new System.Drawing.Point(328, 333);
            this.button_exit_login_window.Name = "button_exit_login_window";
            this.button_exit_login_window.Size = new System.Drawing.Size(120, 50);
            this.button_exit_login_window.TabIndex = 12;
            this.button_exit_login_window.Text = "Close";
            this.button_exit_login_window.UseVisualStyleBackColor = false;
            this.button_exit_login_window.Click += new System.EventHandler(this.button_exit_login_window_Click);
            // 
            // label_failed_login_window
            // 
            this.label_failed_login_window.AutoSize = true;
            this.label_failed_login_window.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_failed_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_failed_login_window.Location = new System.Drawing.Point(88, 87);
            this.label_failed_login_window.Name = "label_failed_login_window";
            this.label_failed_login_window.Size = new System.Drawing.Size(464, 29);
            this.label_failed_login_window.TabIndex = 11;
            this.label_failed_login_window.Text = "incorrect username and/or password!";
            this.label_failed_login_window.Visible = false;
            // 
            // linkLabel_forgot_password
            // 
            this.linkLabel_forgot_password.AutoSize = true;
            this.linkLabel_forgot_password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel_forgot_password.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.linkLabel_forgot_password.Location = new System.Drawing.Point(325, 256);
            this.linkLabel_forgot_password.Name = "linkLabel_forgot_password";
            this.linkLabel_forgot_password.Size = new System.Drawing.Size(193, 18);
            this.linkLabel_forgot_password.TabIndex = 10;
            this.linkLabel_forgot_password.TabStop = true;
            this.linkLabel_forgot_password.Text = "Forgot your password?";
            this.linkLabel_forgot_password.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            // 
            // button_loggin_window
            // 
            this.button_loggin_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_loggin_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_loggin_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_loggin_window.Location = new System.Drawing.Point(454, 333);
            this.button_loggin_window.Name = "button_loggin_window";
            this.button_loggin_window.Size = new System.Drawing.Size(191, 50);
            this.button_loggin_window.TabIndex = 9;
            this.button_loggin_window.Text = "Log in";
            this.button_loggin_window.UseVisualStyleBackColor = false;
            this.button_loggin_window.Click += new System.EventHandler(this.button_loggin_window_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel5.Location = new System.Drawing.Point(298, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(297, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(92, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(92, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 1);
            this.panel2.TabIndex = 4;
            // 
            // input_password_login_window
            // 
            this.input_password_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_password_login_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_password_login_window.Location = new System.Drawing.Point(297, 201);
            this.input_password_login_window.Name = "input_password_login_window";
            this.input_password_login_window.Size = new System.Drawing.Size(262, 43);
            this.input_password_login_window.TabIndex = 3;
            this.input_password_login_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_password_login_window.UseSystemPasswordChar = true;
            this.input_password_login_window.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_password_login_window_KeyPress);
            // 
            // input_username_login_window
            // 
            this.input_username_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_username_login_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_username_login_window.Location = new System.Drawing.Point(297, 128);
            this.input_username_login_window.Name = "input_username_login_window";
            this.input_username_login_window.Size = new System.Drawing.Size(262, 43);
            this.input_username_login_window.TabIndex = 2;
            this.input_username_login_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_username_login_window.WordWrap = false;
            // 
            // label_password_login_window
            // 
            this.label_password_login_window.AutoSize = true;
            this.label_password_login_window.Location = new System.Drawing.Point(87, 201);
            this.label_password_login_window.Name = "label_password_login_window";
            this.label_password_login_window.Size = new System.Drawing.Size(171, 35);
            this.label_password_login_window.TabIndex = 1;
            this.label_password_login_window.Text = "Password";
            // 
            // label_user_login_window
            // 
            this.label_user_login_window.AutoSize = true;
            this.label_user_login_window.Location = new System.Drawing.Point(87, 131);
            this.label_user_login_window.Name = "label_user_login_window";
            this.label_user_login_window.Size = new System.Drawing.Size(179, 35);
            this.label_user_login_window.TabIndex = 0;
            this.label_user_login_window.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(657, 406);
            this.Controls.Add(this.panel_login_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel_login_window.ResumeLayout(false);
            this.panel_login_window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login_window;
        private System.Windows.Forms.Label label_password_login_window;
        private System.Windows.Forms.Label label_user_login_window;
        private System.Windows.Forms.TextBox input_username_login_window;
        private System.Windows.Forms.TextBox input_password_login_window;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_loggin_window;
        private System.Windows.Forms.LinkLabel linkLabel_forgot_password;
        private System.Windows.Forms.Label label_failed_login_window;
        private System.Windows.Forms.Button button_exit_login_window;
        private System.Windows.Forms.Button button_singup_login_window;
    }
}

