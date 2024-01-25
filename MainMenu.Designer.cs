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
            this.panel_top.Location = new System.Drawing.Point(-6, -6);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1210, 125);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // flowLayoutPanel_right
            // 
            this.flowLayoutPanel_right.Controls.Add(this.button_nightmode);
            this.flowLayoutPanel_right.Controls.Add(this.button_user);
            this.flowLayoutPanel_right.Controls.Add(this.button_settings);
            this.flowLayoutPanel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_right.Location = new System.Drawing.Point(875, 0);
            this.flowLayoutPanel_right.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_right.Name = "flowLayoutPanel_right";
            this.flowLayoutPanel_right.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.flowLayoutPanel_right.Size = new System.Drawing.Size(335, 125);
            this.flowLayoutPanel_right.TabIndex = 5;
            // 
            // button_nightmode
            // 
            this.button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_night;
            this.button_nightmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_nightmode.FlatAppearance.BorderSize = 0;
            this.button_nightmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nightmode.Location = new System.Drawing.Point(20, 30);
            this.button_nightmode.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.button_nightmode.Name = "button_nightmode";
            this.button_nightmode.Padding = new System.Windows.Forms.Padding(10);
            this.button_nightmode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_nightmode.Size = new System.Drawing.Size(75, 77);
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
            this.button_user.Location = new System.Drawing.Point(125, 30);
            this.button_user.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.button_user.Name = "button_user";
            this.button_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_user.Size = new System.Drawing.Size(75, 77);
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
            this.button_settings.Location = new System.Drawing.Point(230, 30);
            this.button_settings.Margin = new System.Windows.Forms.Padding(10);
            this.button_settings.Name = "button_settings";
            this.button_settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_settings.Size = new System.Drawing.Size(75, 77);
            this.button_settings.TabIndex = 3;
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_viewsongs
            // 
            this.button_viewsongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_viewsongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_viewsongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_viewsongs.Location = new System.Drawing.Point(40, 37);
            this.button_viewsongs.Name = "button_viewsongs";
            this.button_viewsongs.Size = new System.Drawing.Size(136, 52);
            this.button_viewsongs.TabIndex = 4;
            this.button_viewsongs.Text = "View Songs";
            this.button_viewsongs.UseVisualStyleBackColor = false;
            this.button_viewsongs.Click += new System.EventHandler(this.button_viewsongs_Click);
            // 
            // panel_empty
            // 
            this.panel_empty.Location = new System.Drawing.Point(34, 146);
            this.panel_empty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_empty.Name = "panel_empty";
            this.panel_empty.Size = new System.Drawing.Size(860, 528);
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
            this.button_logout.Location = new System.Drawing.Point(0, 272);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(290, 48);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = true;
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
            this.button_usersett.Location = new System.Drawing.Point(0, 215);
            this.button_usersett.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_usersett.Name = "button_usersett";
            this.button_usersett.Size = new System.Drawing.Size(290, 48);
            this.button_usersett.TabIndex = 3;
            this.button_usersett.Text = "User Settings";
            this.button_usersett.UseVisualStyleBackColor = true;
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel_user.Controls.Add(this.button_usersett);
            this.panel_user.Controls.Add(this.button_logout);
            this.panel_user.Location = new System.Drawing.Point(903, 105);
            this.panel_user.Margin = new System.Windows.Forms.Padding(0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(290, 325);
            this.panel_user.TabIndex = 1;
            this.panel_user.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel_empty);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.panel_top);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainMenu_SizeChanged);
            this.panel_top.ResumeLayout(false);
            this.flowLayoutPanel_right.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
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
    }
}