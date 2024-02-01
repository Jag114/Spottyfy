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
            this.select_mysql = new System.Windows.Forms.CheckBox();
            this.select_mongo = new System.Windows.Forms.CheckBox();
            this.label_selectdb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_repeatpassword_signup_window = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.input_repeatpassword_signup_window = new System.Windows.Forms.TextBox();
            this.button_signup_login_window = new System.Windows.Forms.Button();
            this.button_exit_signup_window = new System.Windows.Forms.Button();
            this.label_failed_signup_window = new System.Windows.Forms.Label();
            this.button_cancel_signup_window = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.input_password_signup_window = new System.Windows.Forms.TextBox();
            this.input_username_signup_window = new System.Windows.Forms.TextBox();
            this.label_password_signup_window = new System.Windows.Forms.Label();
            this.label_user_signup_window = new System.Windows.Forms.Label();
            this.panel_signup_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_signup_window
            // 
            this.panel_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel_signup_window.Controls.Add(this.select_mysql);
            this.panel_signup_window.Controls.Add(this.select_mongo);
            this.panel_signup_window.Controls.Add(this.label_selectdb);
            this.panel_signup_window.Controls.Add(this.panel5);
            this.panel_signup_window.Controls.Add(this.label_repeatpassword_signup_window);
            this.panel_signup_window.Controls.Add(this.panel6);
            this.panel_signup_window.Controls.Add(this.input_repeatpassword_signup_window);
            this.panel_signup_window.Controls.Add(this.button_signup_login_window);
            this.panel_signup_window.Controls.Add(this.button_exit_signup_window);
            this.panel_signup_window.Controls.Add(this.label_failed_signup_window);
            this.panel_signup_window.Controls.Add(this.button_cancel_signup_window);
            this.panel_signup_window.Controls.Add(this.panel4);
            this.panel_signup_window.Controls.Add(this.panel2);
            this.panel_signup_window.Controls.Add(this.panel1);
            this.panel_signup_window.Controls.Add(this.panel3);
            this.panel_signup_window.Controls.Add(this.input_password_signup_window);
            this.panel_signup_window.Controls.Add(this.input_username_signup_window);
            this.panel_signup_window.Controls.Add(this.label_password_signup_window);
            this.panel_signup_window.Controls.Add(this.label_user_signup_window);
            this.panel_signup_window.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.panel_signup_window.Location = new System.Drawing.Point(0, 0);
            this.panel_signup_window.Name = "panel_signup_window";
            this.panel_signup_window.Size = new System.Drawing.Size(670, 440);
            this.panel_signup_window.TabIndex = 1;
            // 
            // select_mysql
            // 
            this.select_mysql.AutoSize = true;
            this.select_mysql.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.select_mysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_mysql.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.select_mysql.Location = new System.Drawing.Point(476, 308);
            this.select_mysql.Name = "select_mysql";
            this.select_mysql.Size = new System.Drawing.Size(98, 29);
            this.select_mysql.TabIndex = 19;
            this.select_mysql.Text = "MySQL";
            this.select_mysql.UseVisualStyleBackColor = true;
            this.select_mysql.CheckedChanged += new System.EventHandler(this.select_mysql_CheckedChanged);
            // 
            // select_mongo
            // 
            this.select_mongo.AutoSize = true;
            this.select_mongo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.select_mongo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_mongo.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.select_mongo.Location = new System.Drawing.Point(344, 308);
            this.select_mongo.Name = "select_mongo";
            this.select_mongo.Size = new System.Drawing.Size(123, 29);
            this.select_mongo.TabIndex = 18;
            this.select_mongo.Text = "MongoDB";
            this.select_mongo.UseVisualStyleBackColor = true;
            this.select_mongo.CheckedChanged += new System.EventHandler(this.select_mongo_CheckedChanged);
            // 
            // label_selectdb
            // 
            this.label_selectdb.AutoSize = true;
            this.label_selectdb.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_selectdb.Location = new System.Drawing.Point(146, 309);
            this.label_selectdb.Name = "label_selectdb";
            this.label_selectdb.Size = new System.Drawing.Size(191, 25);
            this.label_selectdb.TabIndex = 17;
            this.label_selectdb.Text = "Select database:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel5.Location = new System.Drawing.Point(22, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 1);
            this.panel5.TabIndex = 5;
            // 
            // label_repeatpassword_signup_window
            // 
            this.label_repeatpassword_signup_window.AutoSize = true;
            this.label_repeatpassword_signup_window.Location = new System.Drawing.Point(16, 224);
            this.label_repeatpassword_signup_window.Name = "label_repeatpassword_signup_window";
            this.label_repeatpassword_signup_window.Size = new System.Drawing.Size(294, 35);
            this.label_repeatpassword_signup_window.TabIndex = 15;
            this.label_repeatpassword_signup_window.Text = "Repeat Password";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel6.Location = new System.Drawing.Point(346, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 1);
            this.panel6.TabIndex = 8;
            // 
            // input_repeatpassword_signup_window
            // 
            this.input_repeatpassword_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_repeatpassword_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_repeatpassword_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_repeatpassword_signup_window.Location = new System.Drawing.Point(345, 222);
            this.input_repeatpassword_signup_window.Name = "input_repeatpassword_signup_window";
            this.input_repeatpassword_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_repeatpassword_signup_window.TabIndex = 3;
            this.input_repeatpassword_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_repeatpassword_signup_window.UseSystemPasswordChar = true;
            this.input_repeatpassword_signup_window.TextChanged += new System.EventHandler(this.input_repeatpassword_signup_window_TextChanged);
            // 
            // button_signup_login_window
            // 
            this.button_signup_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_signup_login_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signup_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_signup_login_window.Location = new System.Drawing.Point(345, 368);
            this.button_signup_login_window.Name = "button_signup_login_window";
            this.button_signup_login_window.Size = new System.Drawing.Size(310, 50);
            this.button_signup_login_window.TabIndex = 4;
            this.button_signup_login_window.Text = "Sign up";
            this.button_signup_login_window.UseVisualStyleBackColor = false;
            this.button_signup_login_window.Click += new System.EventHandler(this.button_signup_login_window_Click);
            // 
            // button_exit_signup_window
            // 
            this.button_exit_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_exit_signup_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_exit_signup_window.Location = new System.Drawing.Point(219, 368);
            this.button_exit_signup_window.Name = "button_exit_signup_window";
            this.button_exit_signup_window.Size = new System.Drawing.Size(120, 50);
            this.button_exit_signup_window.TabIndex = 5;
            this.button_exit_signup_window.Text = "Close";
            this.button_exit_signup_window.UseVisualStyleBackColor = false;
            this.button_exit_signup_window.Click += new System.EventHandler(this.button_exit_signup_window_Click);
            // 
            // label_failed_signup_window
            // 
            this.label_failed_signup_window.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_failed_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_failed_signup_window.Location = new System.Drawing.Point(146, 29);
            this.label_failed_signup_window.Name = "label_failed_signup_window";
            this.label_failed_signup_window.Size = new System.Drawing.Size(464, 29);
            this.label_failed_signup_window.TabIndex = 11;
            this.label_failed_signup_window.Text = "error";
            this.label_failed_signup_window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_failed_signup_window.Visible = false;
            // 
            // button_cancel_signup_window
            // 
            this.button_cancel_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_cancel_signup_window.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_cancel_signup_window.Location = new System.Drawing.Point(22, 368);
            this.button_cancel_signup_window.Name = "button_cancel_signup_window";
            this.button_cancel_signup_window.Size = new System.Drawing.Size(191, 50);
            this.button_cancel_signup_window.TabIndex = 6;
            this.button_cancel_signup_window.Text = "Login";
            this.button_cancel_signup_window.UseVisualStyleBackColor = false;
            this.button_cancel_signup_window.Click += new System.EventHandler(this.button_cancel_signup_window_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel4.Location = new System.Drawing.Point(346, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(345, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(144, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(144, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 1);
            this.panel3.TabIndex = 4;
            // 
            // input_password_signup_window
            // 
            this.input_password_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_password_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_password_signup_window.Location = new System.Drawing.Point(345, 148);
            this.input_password_signup_window.Name = "input_password_signup_window";
            this.input_password_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_password_signup_window.TabIndex = 2;
            this.input_password_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_password_signup_window.UseSystemPasswordChar = true;
            this.input_password_signup_window.TextChanged += new System.EventHandler(this.input_password_signup_window_TextChanged);
            // 
            // input_username_signup_window
            // 
            this.input_username_signup_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.input_username_signup_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username_signup_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.input_username_signup_window.Location = new System.Drawing.Point(345, 75);
            this.input_username_signup_window.Name = "input_username_signup_window";
            this.input_username_signup_window.Size = new System.Drawing.Size(262, 43);
            this.input_username_signup_window.TabIndex = 1;
            this.input_username_signup_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_username_signup_window.WordWrap = false;
            this.input_username_signup_window.TextChanged += new System.EventHandler(this.input_username_signup_window_TextChanged);
            // 
            // label_password_signup_window
            // 
            this.label_password_signup_window.AutoSize = true;
            this.label_password_signup_window.Location = new System.Drawing.Point(139, 148);
            this.label_password_signup_window.Name = "label_password_signup_window";
            this.label_password_signup_window.Size = new System.Drawing.Size(171, 35);
            this.label_password_signup_window.TabIndex = 13;
            this.label_password_signup_window.Text = "Password";
            // 
            // label_user_signup_window
            // 
            this.label_user_signup_window.AutoSize = true;
            this.label_user_signup_window.Location = new System.Drawing.Point(139, 78);
            this.label_user_signup_window.Name = "label_user_signup_window";
            this.label_user_signup_window.Size = new System.Drawing.Size(179, 35);
            this.label_user_signup_window.TabIndex = 12;
            this.label_user_signup_window.Text = "Username";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(672, 442);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox input_password_signup_window;
        private System.Windows.Forms.TextBox input_username_signup_window;
        private System.Windows.Forms.Label label_password_signup_window;
        private System.Windows.Forms.Label label_user_signup_window;
        private System.Windows.Forms.Label label_repeatpassword_signup_window;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox input_repeatpassword_signup_window;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox select_mysql;
        private System.Windows.Forms.CheckBox select_mongo;
        private System.Windows.Forms.Label label_selectdb;
    }
}