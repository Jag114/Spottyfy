namespace Spottyfy
{
    partial class AlertBox
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
            this.panel_login_window = new System.Windows.Forms.Panel();
            this.label_error_message_alertbox = new System.Windows.Forms.Label();
            this.button_okay_alertbox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_title_alertbox = new System.Windows.Forms.Label();
            this.panel_login_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login_window
            // 
            this.panel_login_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel_login_window.Controls.Add(this.label_error_message_alertbox);
            this.panel_login_window.Controls.Add(this.button_okay_alertbox);
            this.panel_login_window.Controls.Add(this.panel3);
            this.panel_login_window.Controls.Add(this.label_title_alertbox);
            this.panel_login_window.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_login_window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.panel_login_window.Location = new System.Drawing.Point(12, 6);
            this.panel_login_window.Name = "panel_login_window";
            this.panel_login_window.Size = new System.Drawing.Size(574, 308);
            this.panel_login_window.TabIndex = 1;
            this.panel_login_window.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_window_Paint);
            // 
            // label_error_message_alertbox
            // 
            this.label_error_message_alertbox.AutoSize = true;
            this.label_error_message_alertbox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_error_message_alertbox.ForeColor = System.Drawing.Color.IndianRed;
            this.label_error_message_alertbox.Location = new System.Drawing.Point(65, 94);
            this.label_error_message_alertbox.MaximumSize = new System.Drawing.Size(450, 400);
            this.label_error_message_alertbox.Name = "label_error_message_alertbox";
            this.label_error_message_alertbox.Size = new System.Drawing.Size(444, 92);
            this.label_error_message_alertbox.TabIndex = 13;
            this.label_error_message_alertbox.Text = "error message goes here la la al Lorem ipsum dolor sit amet, consectetur adipisci" +
    "ng elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            // 
            // button_okay_alertbox
            // 
            this.button_okay_alertbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.button_okay_alertbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_okay_alertbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.button_okay_alertbox.Location = new System.Drawing.Point(232, 244);
            this.button_okay_alertbox.Name = "button_okay_alertbox";
            this.button_okay_alertbox.Size = new System.Drawing.Size(120, 50);
            this.button_okay_alertbox.TabIndex = 12;
            this.button_okay_alertbox.Text = "Okay";
            this.button_okay_alertbox.UseVisualStyleBackColor = false;
            this.button_okay_alertbox.Click += new System.EventHandler(this.button_okay_alertbox_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(70, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 1);
            this.panel3.TabIndex = 5;
            // 
            // label_title_alertbox
            // 
            this.label_title_alertbox.AutoSize = true;
            this.label_title_alertbox.Location = new System.Drawing.Point(64, 32);
            this.label_title_alertbox.Name = "label_title_alertbox";
            this.label_title_alertbox.Size = new System.Drawing.Size(425, 35);
            this.label_title_alertbox.TabIndex = 0;
            this.label_title_alertbox.Text = "Something went wrong...";
            this.label_title_alertbox.Click += new System.EventHandler(this.label_title_alertbox_Click);
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(578, 312);
            this.Controls.Add(this.panel_login_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertBox";
            this.panel_login_window.ResumeLayout(false);
            this.panel_login_window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login_window;
        private System.Windows.Forms.Button button_okay_alertbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_title_alertbox;
        private System.Windows.Forms.Label label_error_message_alertbox;
    }
}