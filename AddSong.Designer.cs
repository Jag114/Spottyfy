namespace Spottyfy
{
    partial class AddSong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.songDate = new System.Windows.Forms.DateTimePicker();
            this.songAuthor = new System.Windows.Forms.TextBox();
            this.songName = new System.Windows.Forms.TextBox();
            this.albumList = new System.Windows.Forms.ListBox();
            this.addSongBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.songCost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.songCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(80, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(80, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // songDate
            // 
            this.songDate.Location = new System.Drawing.Point(159, 134);
            this.songDate.Name = "songDate";
            this.songDate.Size = new System.Drawing.Size(200, 20);
            this.songDate.TabIndex = 4;
            // 
            // songAuthor
            // 
            this.songAuthor.Location = new System.Drawing.Point(159, 99);
            this.songAuthor.Name = "songAuthor";
            this.songAuthor.Size = new System.Drawing.Size(100, 20);
            this.songAuthor.TabIndex = 5;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(159, 20);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(100, 20);
            this.songName.TabIndex = 6;
            // 
            // albumList
            // 
            this.albumList.FormattingEnabled = true;
            this.albumList.Location = new System.Drawing.Point(159, 60);
            this.albumList.Name = "albumList";
            this.albumList.ScrollAlwaysVisible = true;
            this.albumList.Size = new System.Drawing.Size(120, 30);
            this.albumList.TabIndex = 7;
            this.albumList.SelectedIndexChanged += new System.EventHandler(this.albumList_SelectedIndexChanged);
            // 
            // addSongBtn
            // 
            this.addSongBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.addSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addSongBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.addSongBtn.Location = new System.Drawing.Point(346, 230);
            this.addSongBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addSongBtn.Name = "addSongBtn";
            this.addSongBtn.Size = new System.Drawing.Size(140, 34);
            this.addSongBtn.TabIndex = 8;
            this.addSongBtn.Text = "Add Song";
            this.addSongBtn.UseVisualStyleBackColor = false;
            this.addSongBtn.Click += new System.EventHandler(this.addSongBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(88, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost";
            // 
            // songCost
            // 
            this.songCost.Location = new System.Drawing.Point(159, 170);
            this.songCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.songCost.Name = "songCost";
            this.songCost.Size = new System.Drawing.Size(120, 20);
            this.songCost.TabIndex = 11;
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 275);
            this.Controls.Add(this.songCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addSongBtn);
            this.Controls.Add(this.albumList);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.songAuthor);
            this.Controls.Add(this.songDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSong";
            this.Text = "AddSong";
            this.Load += new System.EventHandler(this.AddSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker songDate;
        private System.Windows.Forms.TextBox songAuthor;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.ListBox albumList;
        private System.Windows.Forms.Button addSongBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown songCost;
    }
}