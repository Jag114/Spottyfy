using System.Diagnostics;

namespace Spottyfy
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    partial class MainMenu
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_right = new System.Windows.Forms.FlowLayoutPanel();
            this.button_nightmode = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_viewsongs = new System.Windows.Forms.Button();
            this.panel_empty = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_usersett = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label_section_line = new System.Windows.Forms.Label();
            this.panel_avatar = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.flowLayoutPanel_right.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel_top.Controls.Add(this.flowLayoutPanel_right);
            this.panel_top.Controls.Add(this.button_viewsongs);
            this.panel_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_top.Location = new System.Drawing.Point(-4, -4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(807, 81);
            this.panel_top.TabIndex = 0;
            // 
            // flowLayoutPanel_right
            // 
            this.flowLayoutPanel_right.Controls.Add(this.button_nightmode);
            this.flowLayoutPanel_right.Controls.Add(this.button_user);
            this.flowLayoutPanel_right.Controls.Add(this.button_settings);
            this.flowLayoutPanel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_right.Location = new System.Drawing.Point(584, 0);
            this.flowLayoutPanel_right.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_right.Name = "flowLayoutPanel_right";
            this.flowLayoutPanel_right.Padding = new System.Windows.Forms.Padding(7, 13, 7, 6);
            this.flowLayoutPanel_right.Size = new System.Drawing.Size(223, 81);
            this.flowLayoutPanel_right.TabIndex = 5;
            // 
            // button_nightmode
            // 
            this.button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_night;
            this.button_nightmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_nightmode.FlatAppearance.BorderSize = 0;
            this.button_nightmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nightmode.Location = new System.Drawing.Point(14, 19);
            this.button_nightmode.Margin = new System.Windows.Forms.Padding(7, 6, 13, 6);
            this.button_nightmode.Name = "button_nightmode";
            this.button_nightmode.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_nightmode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_nightmode.Size = new System.Drawing.Size(50, 50);
            this.button_nightmode.TabIndex = 1;
            this.button_nightmode.UseVisualStyleBackColor = true;
            this.button_nightmode.Click += new System.EventHandler(this.button_nightmode_Click);
            // 
            // button_user
            // 
            this.button_user.BackgroundImage = global::Spottyfy.Properties.Resources.user0;
            this.button_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_user.FlatAppearance.BorderSize = 0;
            this.button_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user.Location = new System.Drawing.Point(84, 19);
            this.button_user.Margin = new System.Windows.Forms.Padding(7, 6, 13, 6);
            this.button_user.Name = "button_user";
            this.button_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_user.Size = new System.Drawing.Size(50, 50);
            this.button_user.TabIndex = 2;
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackgroundImage = global::Spottyfy.Properties.Resources.settings;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Location = new System.Drawing.Point(154, 19);
            this.button_settings.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_settings.Name = "button_settings";
            this.button_settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_settings.Size = new System.Drawing.Size(50, 50);
            this.button_settings.TabIndex = 3;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_viewsongs
            // 
            this.button_viewsongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_viewsongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_viewsongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_viewsongs.Location = new System.Drawing.Point(27, 24);
            this.button_viewsongs.Margin = new System.Windows.Forms.Padding(2);
            this.button_viewsongs.Name = "button_viewsongs";
            this.button_viewsongs.Size = new System.Drawing.Size(91, 34);
            this.button_viewsongs.TabIndex = 4;
            this.button_viewsongs.Text = "View Songs";
            this.button_viewsongs.UseVisualStyleBackColor = false;
            this.button_viewsongs.Click += new System.EventHandler(this.button_viewsongs_Click);
            // 
            // panel_empty
            // 
            this.panel_empty.Location = new System.Drawing.Point(23, 95);
            this.panel_empty.Name = "panel_empty";
            this.panel_empty.Size = new System.Drawing.Size(573, 343);
            this.panel_empty.TabIndex = 2;
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.Location = new System.Drawing.Point(0, 177);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(193, 31);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_usersett
            // 
            this.button_usersett.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_usersett.FlatAppearance.BorderSize = 0;
            this.button_usersett.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_usersett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usersett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usersett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_usersett.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_usersett.Location = new System.Drawing.Point(0, 141);
            this.button_usersett.Name = "button_usersett";
            this.button_usersett.Size = new System.Drawing.Size(193, 31);
            this.button_usersett.TabIndex = 3;
            this.button_usersett.Text = "User Settings";
            this.button_usersett.UseVisualStyleBackColor = true;
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel_user.Controls.Add(this.label_section_line);
            this.panel_user.Controls.Add(this.panel_avatar);
            this.panel_user.Controls.Add(this.label_username);
            this.panel_user.Controls.Add(this.button_usersett);
            this.panel_user.Controls.Add(this.button_logout);
            this.panel_user.Location = new System.Drawing.Point(602, 68);
            this.panel_user.Margin = new System.Windows.Forms.Padding(0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(193, 211);
            this.panel_user.TabIndex = 1;
            this.panel_user.Visible = false;
            // 
            // label_section_line
            // 
            this.label_section_line.AutoSize = true;
            this.label_section_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label_section_line.Location = new System.Drawing.Point(4, 125);
            this.label_section_line.Name = "label_section_line";
            this.label_section_line.Size = new System.Drawing.Size(187, 13);
            this.label_section_line.TabIndex = 6;
            this.label_section_line.Text = "______________________________";
            // 
            // panel_avatar
            // 
            this.panel_avatar.BackgroundImage = global::Spottyfy.Properties.Resources.blank_avatar;
            this.panel_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_avatar.Location = new System.Drawing.Point(51, 32);
            this.panel_avatar.Name = "panel_avatar";
            this.panel_avatar.Size = new System.Drawing.Size(90, 90);
            this.panel_avatar.TabIndex = 5;
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_username.Location = new System.Drawing.Point(3, 9);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(190, 20);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "label1";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_empty);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.panel_top);
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.flowLayoutPanel_right.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_nightmode;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Panel panel_empty;
        private System.Windows.Forms.Button button_viewsongs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_right;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_usersett;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Panel panel_avatar;
        private System.Windows.Forms.Label label_section_line;
    }
}