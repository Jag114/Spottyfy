namespace Spottyfy
{
    partial class SongDetailView
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
            this.songTitle = new System.Windows.Forms.Label();
            this.songDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songReleaseDate = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songTitle
            // 
            this.songTitle.AutoSize = true;
            this.songTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.songTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.songTitle.Location = new System.Drawing.Point(40, 34);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(182, 46);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "songTitle";
            // 
            // songDetails
            // 
            this.songDetails.AutoSize = true;
            this.songDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.songDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.songDetails.Location = new System.Drawing.Point(43, 109);
            this.songDetails.Name = "songDetails";
            this.songDetails.Size = new System.Drawing.Size(166, 29);
            this.songDetails.TabIndex = 1;
            this.songDetails.Text = "author - album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(43, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "released";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // songReleaseDate
            // 
            this.songReleaseDate.AutoSize = true;
            this.songReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.songReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.songReleaseDate.Location = new System.Drawing.Point(148, 149);
            this.songReleaseDate.Name = "songReleaseDate";
            this.songReleaseDate.Size = new System.Drawing.Size(133, 29);
            this.songReleaseDate.TabIndex = 5;
            this.songReleaseDate.Text = "2020-04-30";
            this.songReleaseDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.backButton.Location = new System.Drawing.Point(668, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 50);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SongDetailView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.songReleaseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.songDetails);
            this.Controls.Add(this.songTitle);
            this.Name = "SongDetailView";
            this.Text = "Song View";
            this.Load += new System.EventHandler(this.SongDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label songDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label songReleaseDate;
        private System.Windows.Forms.Button backButton;
    }
}
