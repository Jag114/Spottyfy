﻿namespace Spottyfy
{
    partial class UserSettings
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
            this.button_change_profpic = new System.Windows.Forms.Button();
            this.flowLayoutPanel_user_sett = new System.Windows.Forms.FlowLayoutPanel();
            this.label_changeinfo = new System.Windows.Forms.Label();
            this.label_oldpass = new System.Windows.Forms.Label();
            this.input_oldpassword = new System.Windows.Forms.TextBox();
            this.label_newpass = new System.Windows.Forms.Label();
            this.input_newpass = new System.Windows.Forms.TextBox();
            this.button_changpassword = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_rank = new System.Windows.Forms.Label();
            this.openFile_picutre = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.flowLayout_admin = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirmchange = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.panel_avatar = new System.Windows.Forms.Panel();
            this.checkBox_user = new System.Windows.Forms.RadioButton();
            this.checkBox_admin = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel_user_sett.SuspendLayout();
            this.flowLayout_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_change_profpic
            // 
            this.button_change_profpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_change_profpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.button_change_profpic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_change_profpic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_change_profpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_profpic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_change_profpic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_change_profpic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_change_profpic.Location = new System.Drawing.Point(15, 207);
            this.button_change_profpic.Name = "button_change_profpic";
            this.button_change_profpic.Size = new System.Drawing.Size(300, 34);
            this.button_change_profpic.TabIndex = 7;
            this.button_change_profpic.Text = "Change profile picture";
            this.button_change_profpic.UseVisualStyleBackColor = false;
            this.button_change_profpic.Click += new System.EventHandler(this.button_usersett_Click);
            // 
            // flowLayoutPanel_user_sett
            // 
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_changeinfo);
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_oldpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.input_oldpassword);
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_newpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.input_newpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.button_changpassword);
            this.flowLayoutPanel_user_sett.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_user_sett.Location = new System.Drawing.Point(21, 424);
            this.flowLayoutPanel_user_sett.Name = "flowLayoutPanel_user_sett";
            this.flowLayoutPanel_user_sett.Size = new System.Drawing.Size(310, 249);
            this.flowLayoutPanel_user_sett.TabIndex = 8;
            this.flowLayoutPanel_user_sett.Visible = false;
            // 
            // label_changeinfo
            // 
            this.label_changeinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_changeinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_changeinfo.Location = new System.Drawing.Point(3, 0);
            this.label_changeinfo.Name = "label_changeinfo";
            this.label_changeinfo.Size = new System.Drawing.Size(307, 23);
            this.label_changeinfo.TabIndex = 13;
            this.label_changeinfo.Text = "Change your password: ";
            this.label_changeinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_oldpass
            // 
            this.label_oldpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_oldpass.Location = new System.Drawing.Point(35, 23);
            this.label_oldpass.Name = "label_oldpass";
            this.label_oldpass.Size = new System.Drawing.Size(242, 23);
            this.label_oldpass.TabIndex = 10;
            this.label_oldpass.Text = "Old password:";
            this.label_oldpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_oldpassword
            // 
            this.input_oldpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_oldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_oldpassword.Location = new System.Drawing.Point(42, 49);
            this.input_oldpassword.Name = "input_oldpassword";
            this.input_oldpassword.Size = new System.Drawing.Size(228, 28);
            this.input_oldpassword.TabIndex = 9;
            this.input_oldpassword.UseSystemPasswordChar = true;
            // 
            // label_newpass
            // 
            this.label_newpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_newpass.Location = new System.Drawing.Point(35, 80);
            this.label_newpass.Name = "label_newpass";
            this.label_newpass.Size = new System.Drawing.Size(242, 23);
            this.label_newpass.TabIndex = 12;
            this.label_newpass.Text = "New password:";
            this.label_newpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_newpass
            // 
            this.input_newpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_newpass.Location = new System.Drawing.Point(42, 106);
            this.input_newpass.Name = "input_newpass";
            this.input_newpass.Size = new System.Drawing.Size(228, 28);
            this.input_newpass.TabIndex = 11;
            this.input_newpass.UseSystemPasswordChar = true;
            // 
            // button_changpassword
            // 
            this.button_changpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_changpassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_changpassword.FlatAppearance.BorderSize = 0;
            this.button_changpassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_changpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_changpassword.ForeColor = System.Drawing.Color.Black;
            this.button_changpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_changpassword.Location = new System.Drawing.Point(3, 140);
            this.button_changpassword.Name = "button_changpassword";
            this.button_changpassword.Size = new System.Drawing.Size(307, 34);
            this.button_changpassword.TabIndex = 8;
            this.button_changpassword.Text = "Confirm change";
            this.button_changpassword.UseVisualStyleBackColor = true;
            this.button_changpassword.Click += new System.EventHandler(this.button_changpassword_Click);
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_username.Location = new System.Drawing.Point(12, 135);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(310, 35);
            this.label_username.TabIndex = 9;
            this.label_username.Text = "username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rank
            // 
            this.label_rank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_rank.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_rank.Location = new System.Drawing.Point(116, 169);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(100, 23);
            this.label_rank.TabIndex = 10;
            this.label_rank.Text = "rank";
            this.label_rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile_picutre
            // 
            this.openFile_picutre.FileName = "openFileDialog1";
            // 
            // comboBox_users
            // 
            this.comboBox_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.comboBox_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Location = new System.Drawing.Point(4, 29);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(300, 30);
            this.comboBox_users.TabIndex = 13;
            // 
            // flowLayout_admin
            // 
            this.flowLayout_admin.Controls.Add(this.label1);
            this.flowLayout_admin.Controls.Add(this.comboBox_users);
            this.flowLayout_admin.Controls.Add(this.checkBox_user);
            this.flowLayout_admin.Controls.Add(this.checkBox_admin);
            this.flowLayout_admin.Controls.Add(this.button_confirmchange);
            this.flowLayout_admin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_admin.Location = new System.Drawing.Point(12, 253);
            this.flowLayout_admin.Name = "flowLayout_admin";
            this.flowLayout_admin.Size = new System.Drawing.Size(319, 165);
            this.flowLayout_admin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose user to edit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_confirmchange
            // 
            this.button_confirmchange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_confirmchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.button_confirmchange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_confirmchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_confirmchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmchange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_confirmchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_confirmchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_confirmchange.Location = new System.Drawing.Point(311, 3);
            this.button_confirmchange.Name = "button_confirmchange";
            this.button_confirmchange.Size = new System.Drawing.Size(300, 34);
            this.button_confirmchange.TabIndex = 15;
            this.button_confirmchange.Text = "Confirm user change";
            this.button_confirmchange.UseVisualStyleBackColor = false;
            this.button_confirmchange.Click += new System.EventHandler(this.button_confirmchange_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // panel_avatar
            // 
            this.panel_avatar.BackgroundImage = global::Spottyfy.Properties.Resources.blank_avatar;
            this.panel_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_avatar.Location = new System.Drawing.Point(108, 12);
            this.panel_avatar.Name = "panel_avatar";
            this.panel_avatar.Size = new System.Drawing.Size(120, 120);
            this.panel_avatar.TabIndex = 12;
            // 
            // checkBox_user
            // 
            this.checkBox_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_user.AutoSize = true;
            this.checkBox_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_user.Font = new System.Drawing.Font("Verdana", 12F);
            this.checkBox_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.checkBox_user.Location = new System.Drawing.Point(119, 65);
            this.checkBox_user.Name = "checkBox_user";
            this.checkBox_user.Size = new System.Drawing.Size(69, 27);
            this.checkBox_user.TabIndex = 17;
            this.checkBox_user.TabStop = true;
            this.checkBox_user.Text = "user";
            this.checkBox_user.UseVisualStyleBackColor = true;
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_admin.Font = new System.Drawing.Font("Verdana", 12F);
            this.checkBox_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.checkBox_admin.Location = new System.Drawing.Point(110, 98);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(87, 27);
            this.checkBox_admin.TabIndex = 18;
            this.checkBox_admin.TabStop = true;
            this.checkBox_admin.Text = "admin";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // UserSettings
            // 
            this.AcceptButton = this.button_changpassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(334, 474);
            this.Controls.Add(this.flowLayout_admin);
            this.Controls.Add(this.flowLayoutPanel_user_sett);
            this.Controls.Add(this.button_change_profpic);
            this.Controls.Add(this.panel_avatar);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.label_username);
            this.Name = "UserSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UserSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettings_FormClosing);
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.flowLayoutPanel_user_sett.ResumeLayout(false);
            this.flowLayoutPanel_user_sett.PerformLayout();
            this.flowLayout_admin.ResumeLayout(false);
            this.flowLayout_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_change_profpic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_user_sett;
        private System.Windows.Forms.Button button_changpassword;
        private System.Windows.Forms.TextBox input_oldpassword;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_oldpass;
        private System.Windows.Forms.Label label_newpass;
        private System.Windows.Forms.TextBox input_newpass;
        private System.Windows.Forms.Label label_changeinfo;
        private System.Windows.Forms.Label label_rank;
        private System.Windows.Forms.OpenFileDialog openFile_picutre;
        private System.Windows.Forms.Panel panel_avatar;
        private System.Windows.Forms.ComboBox comboBox_users;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirmchange;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.RadioButton checkBox_user;
        private System.Windows.Forms.RadioButton checkBox_admin;
    }
}