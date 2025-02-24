﻿using System.Diagnostics;

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
            this.components = new System.ComponentModel.Container();
            this.panel_top = new System.Windows.Forms.Panel();
            this.addSongs = new System.Windows.Forms.Button();
            this.button_shoppingcart = new System.Windows.Forms.Button();
            this.flowLayoutPanel_right = new System.Windows.Forms.FlowLayoutPanel();
            this.button_nightmode = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_viewsongs = new System.Windows.Forms.Button();
            this.panel_empty = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_usersett = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label_creditscore = new System.Windows.Forms.Label();
            this.label_creditinfo = new System.Windows.Forms.Label();
            this.label_section_line = new System.Windows.Forms.Label();
            this.panel_avatar = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.right_cilck_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nightmodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_top.SuspendLayout();
            this.flowLayoutPanel_right.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.right_cilck_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel_top.Controls.Add(this.addSongs);
            this.panel_top.Controls.Add(this.button_shoppingcart);
            this.panel_top.Controls.Add(this.flowLayoutPanel_right);
            this.panel_top.Controls.Add(this.button_viewsongs);
            this.panel_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_top.Location = new System.Drawing.Point(-4, -4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(807, 81);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // addSongs
            // 
            this.addSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.addSongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.addSongs.Location = new System.Drawing.Point(225, 27);
            this.addSongs.Margin = new System.Windows.Forms.Padding(2);
            this.addSongs.Name = "addSongs";
            this.addSongs.Size = new System.Drawing.Size(140, 34);
            this.addSongs.TabIndex = 6;
            this.addSongs.Text = "Add Songs";
            this.addSongs.UseVisualStyleBackColor = false;
            this.addSongs.Click += new System.EventHandler(this.addSongs_Click);
            // 
            // button_shoppingcart
            // 
            this.button_shoppingcart.BackgroundImage = global::Spottyfy.Properties.Resources.cart;
            this.button_shoppingcart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_shoppingcart.FlatAppearance.BorderSize = 0;
            this.button_shoppingcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shoppingcart.Location = new System.Drawing.Point(20, 24);
            this.button_shoppingcart.Margin = new System.Windows.Forms.Padding(7, 6, 13, 6);
            this.button_shoppingcart.Name = "button_shoppingcart";
            this.button_shoppingcart.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_shoppingcart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_shoppingcart.Size = new System.Drawing.Size(34, 34);
            this.button_shoppingcart.TabIndex = 6;
            this.button_shoppingcart.UseVisualStyleBackColor = true;
            this.button_shoppingcart.Click += new System.EventHandler(this.button_shoppingcart_Click);
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
            this.button_viewsongs.Location = new System.Drawing.Point(69, 27);
            this.button_viewsongs.Margin = new System.Windows.Forms.Padding(2);
            this.button_viewsongs.Name = "button_viewsongs";
            this.button_viewsongs.Size = new System.Drawing.Size(140, 34);
            this.button_viewsongs.TabIndex = 4;
            this.button_viewsongs.Text = "View Songs";
            this.button_viewsongs.UseVisualStyleBackColor = false;
            this.button_viewsongs.Click += new System.EventHandler(this.button_viewsongs_Click);
            // 
            // panel_empty
            // 
            this.panel_empty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_empty.Location = new System.Drawing.Point(-1, 102);
            this.panel_empty.Name = "panel_empty";
            this.panel_empty.Size = new System.Drawing.Size(804, 373);
            this.panel_empty.TabIndex = 2;
            this.panel_empty.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_empty_Paint);
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
            this.button_logout.Location = new System.Drawing.Point(-3, 230);
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
            this.button_usersett.Location = new System.Drawing.Point(0, 203);
            this.button_usersett.Name = "button_usersett";
            this.button_usersett.Size = new System.Drawing.Size(193, 31);
            this.button_usersett.TabIndex = 3;
            this.button_usersett.Text = "User Settings";
            this.button_usersett.UseVisualStyleBackColor = true;
            this.button_usersett.Click += new System.EventHandler(this.button_usersett_Click);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel_user.Controls.Add(this.label_creditscore);
            this.panel_user.Controls.Add(this.label_creditinfo);
            this.panel_user.Controls.Add(this.label_section_line);
            this.panel_user.Controls.Add(this.panel_avatar);
            this.panel_user.Controls.Add(this.label_username);
            this.panel_user.Controls.Add(this.button_usersett);
            this.panel_user.Controls.Add(this.button_logout);
            this.panel_user.Location = new System.Drawing.Point(602, 68);
            this.panel_user.Margin = new System.Windows.Forms.Padding(0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(193, 263);
            this.panel_user.TabIndex = 1;
            this.panel_user.Visible = false;
            // 
            // label_creditscore
            // 
            this.label_creditscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_creditscore.ForeColor = System.Drawing.Color.Yellow;
            this.label_creditscore.Location = new System.Drawing.Point(0, 155);
            this.label_creditscore.Name = "label_creditscore";
            this.label_creditscore.Size = new System.Drawing.Size(190, 33);
            this.label_creditscore.TabIndex = 9;
            this.label_creditscore.Text = "creditscore";
            this.label_creditscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_creditinfo
            // 
            this.label_creditinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_creditinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_creditinfo.Location = new System.Drawing.Point(0, 135);
            this.label_creditinfo.Name = "label_creditinfo";
            this.label_creditinfo.Size = new System.Drawing.Size(190, 20);
            this.label_creditinfo.TabIndex = 8;
            this.label_creditinfo.Text = "Your credit:";
            this.label_creditinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_section_line
            // 
            this.label_section_line.AutoSize = true;
            this.label_section_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label_section_line.Location = new System.Drawing.Point(3, 187);
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
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_username.Location = new System.Drawing.Point(0, 3);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(190, 26);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right_cilck_menu
            // 
            this.right_cilck_menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.right_cilck_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nightmodeToolStripMenuItem,
            this.userToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.right_cilck_menu.Name = "right_cilck_menu";
            this.right_cilck_menu.Size = new System.Drawing.Size(148, 76);
            // 
            // nightmodeToolStripMenuItem
            // 
            this.nightmodeToolStripMenuItem.Name = "nightmodeToolStripMenuItem";
            this.nightmodeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.nightmodeToolStripMenuItem.Text = "Nightmode";
            this.nightmodeToolStripMenuItem.Click += new System.EventHandler(this.nightmodeToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(834, 506);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.panel_empty);
            this.Controls.Add(this.panel_top);
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.panel_top.ResumeLayout(false);
            this.flowLayoutPanel_right.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.right_cilck_menu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip right_cilck_menu;
        private System.Windows.Forms.ToolStripMenuItem nightmodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button addSongs;
        private System.Windows.Forms.Label label_creditscore;
        private System.Windows.Forms.Label label_creditinfo;
        private System.Windows.Forms.Button button_shoppingcart;
    }
}