namespace Spottyfy
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
            this.panel_avatar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_user_sett.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_change_profpic
            // 
            this.button_change_profpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_change_profpic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_change_profpic.FlatAppearance.BorderSize = 0;
            this.button_change_profpic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_change_profpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_profpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_change_profpic.ForeColor = System.Drawing.Color.Black;
            this.button_change_profpic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_change_profpic.Location = new System.Drawing.Point(3, 3);
            this.button_change_profpic.Name = "button_change_profpic";
            this.button_change_profpic.Size = new System.Drawing.Size(307, 34);
            this.button_change_profpic.TabIndex = 7;
            this.button_change_profpic.Text = "Change profile picture";
            this.button_change_profpic.UseVisualStyleBackColor = true;
            this.button_change_profpic.Click += new System.EventHandler(this.button_usersett_Click);
            // 
            // flowLayoutPanel_user_sett
            // 
            this.flowLayoutPanel_user_sett.Controls.Add(this.button_change_profpic);
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_changeinfo);
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_oldpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.input_oldpassword);
            this.flowLayoutPanel_user_sett.Controls.Add(this.label_newpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.input_newpass);
            this.flowLayoutPanel_user_sett.Controls.Add(this.button_changpassword);
            this.flowLayoutPanel_user_sett.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_user_sett.Location = new System.Drawing.Point(12, 196);
            this.flowLayoutPanel_user_sett.Name = "flowLayoutPanel_user_sett";
            this.flowLayoutPanel_user_sett.Size = new System.Drawing.Size(310, 246);
            this.flowLayoutPanel_user_sett.TabIndex = 8;
            // 
            // label_changeinfo
            // 
            this.label_changeinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_changeinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_changeinfo.Location = new System.Drawing.Point(3, 40);
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
            this.label_oldpass.Location = new System.Drawing.Point(35, 63);
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
            this.input_oldpassword.Location = new System.Drawing.Point(42, 89);
            this.input_oldpassword.Name = "input_oldpassword";
            this.input_oldpassword.Size = new System.Drawing.Size(228, 26);
            this.input_oldpassword.TabIndex = 9;
            this.input_oldpassword.UseSystemPasswordChar = true;
            // 
            // label_newpass
            // 
            this.label_newpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_newpass.Location = new System.Drawing.Point(35, 118);
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
            this.input_newpass.Location = new System.Drawing.Point(42, 144);
            this.input_newpass.Name = "input_newpass";
            this.input_newpass.Size = new System.Drawing.Size(228, 26);
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
            this.button_changpassword.Location = new System.Drawing.Point(3, 176);
            this.button_changpassword.Name = "button_changpassword";
            this.button_changpassword.Size = new System.Drawing.Size(307, 34);
            this.button_changpassword.TabIndex = 8;
            this.button_changpassword.Text = "Confirm change";
            this.button_changpassword.UseVisualStyleBackColor = true;
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.Black;
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
            this.label_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rank.Location = new System.Drawing.Point(117, 170);
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
            // panel_avatar
            // 
            this.panel_avatar.BackgroundImage = global::Spottyfy.Properties.Resources.blank_avatar;
            this.panel_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_avatar.Location = new System.Drawing.Point(108, 12);
            this.panel_avatar.Name = "panel_avatar";
            this.panel_avatar.Size = new System.Drawing.Size(120, 120);
            this.panel_avatar.TabIndex = 12;
            // 
            // UserSettings
            // 
            this.AcceptButton = this.button_changpassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(334, 454);
            this.Controls.Add(this.panel_avatar);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.flowLayoutPanel_user_sett);
            this.Name = "UserSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UserSettings";
            this.flowLayoutPanel_user_sett.ResumeLayout(false);
            this.flowLayoutPanel_user_sett.PerformLayout();
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
    }
}