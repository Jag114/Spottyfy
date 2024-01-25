﻿namespace Spottyfy
{
    partial class AppSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_main_settings = new System.Windows.Forms.Button();
            this.label_app_sett = new System.Windows.Forms.Label();
            this.button_shortcut_info = new System.Windows.Forms.Button();
            this.label_sett = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_app_info = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.button_shortcut_info, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_main_settings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_app_info, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_main_settings
            // 
            this.button_main_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_main_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_main_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_main_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_main_settings.Location = new System.Drawing.Point(3, 63);
            this.button_main_settings.Name = "button_main_settings";
            this.button_main_settings.Size = new System.Drawing.Size(215, 39);
            this.button_main_settings.TabIndex = 0;
            this.button_main_settings.Text = "Main Settings";
            this.button_main_settings.UseVisualStyleBackColor = false;
            this.button_main_settings.Click += new System.EventHandler(this.button_main_settings_Click);
            // 
            // label_app_sett
            // 
            this.label_app_sett.AutoSize = true;
            this.label_app_sett.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_app_sett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_app_sett.Location = new System.Drawing.Point(278, 75);
            this.label_app_sett.Name = "label_app_sett";
            this.label_app_sett.Size = new System.Drawing.Size(223, 37);
            this.label_app_sett.TabIndex = 1;
            this.label_app_sett.Text = "Main Settings";
            // 
            // button_shortcut_info
            // 
            this.button_shortcut_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_shortcut_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_shortcut_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shortcut_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_shortcut_info.Location = new System.Drawing.Point(3, 108);
            this.button_shortcut_info.Name = "button_shortcut_info";
            this.button_shortcut_info.Size = new System.Drawing.Size(215, 39);
            this.button_shortcut_info.TabIndex = 1;
            this.button_shortcut_info.Text = "Shortcut Information";
            this.button_shortcut_info.UseVisualStyleBackColor = false;
            this.button_shortcut_info.Click += new System.EventHandler(this.button_shortcut_info_Click);
            // 
            // label_sett
            // 
            this.label_sett.AutoSize = true;
            this.label_sett.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_sett.Location = new System.Drawing.Point(275, 12);
            this.label_sett.Name = "label_sett";
            this.label_sett.Size = new System.Drawing.Size(308, 55);
            this.label_sett.TabIndex = 2;
            this.label_sett.Text = "App Settings";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(285, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 318);
            this.panel1.TabIndex = 3;
            // 
            // button_app_info
            // 
            this.button_app_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_app_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_app_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_app_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_app_info.Location = new System.Drawing.Point(3, 153);
            this.button_app_info.Name = "button_app_info";
            this.button_app_info.Size = new System.Drawing.Size(215, 39);
            this.button_app_info.TabIndex = 2;
            this.button_app_info.Text = "App Information";
            this.button_app_info.UseVisualStyleBackColor = false;
            this.button_app_info.Click += new System.EventHandler(this.button_app_info_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_sett);
            this.Controls.Add(this.label_app_sett);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AppSettings";
            this.Text = "AppSettings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_main_settings;
        private System.Windows.Forms.Label label_app_sett;
        private System.Windows.Forms.Button button_shortcut_info;
        private System.Windows.Forms.Label label_sett;
        private System.Windows.Forms.Button button_app_info;
        private System.Windows.Forms.Panel panel1;
    }
}