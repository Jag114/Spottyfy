namespace Spottyfy
{
    partial class Shop
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
            this.label_shop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_shop
            // 
            this.label_shop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_shop.AutoSize = true;
            this.label_shop.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_shop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_shop.Location = new System.Drawing.Point(12, 9);
            this.label_shop.Name = "label_shop";
            this.label_shop.Size = new System.Drawing.Size(117, 38);
            this.label_shop.TabIndex = 2;
            this.label_shop.Text = "SHOP";
            this.label_shop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_shop);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_shop;
    }
}