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
            this.table_shop = new System.Windows.Forms.TableLayoutPanel();
            this.label_info = new System.Windows.Forms.Label();
            this.label_info3 = new System.Windows.Forms.Label();
            this.label_info2 = new System.Windows.Forms.Label();
            this.label_info1 = new System.Windows.Forms.Label();
            this.table_shop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_shop
            // 
            this.label_shop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_shop.AutoSize = true;
            this.label_shop.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_shop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_shop.Location = new System.Drawing.Point(54, 9);
            this.label_shop.Name = "label_shop";
            this.label_shop.Size = new System.Drawing.Size(117, 38);
            this.label_shop.TabIndex = 2;
            this.label_shop.Text = "SHOP";
            this.label_shop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_shop
            // 
            this.table_shop.ColumnCount = 5;
            this.table_shop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_shop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_shop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_shop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_shop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_shop.Controls.Add(this.label_info, 3, 0);
            this.table_shop.Controls.Add(this.label_info3, 2, 0);
            this.table_shop.Controls.Add(this.label_info2, 1, 0);
            this.table_shop.Controls.Add(this.label_info1, 0, 0);
            this.table_shop.Location = new System.Drawing.Point(19, 50);
            this.table_shop.Name = "table_shop";
            this.table_shop.RowCount = 1;
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.table_shop.Size = new System.Drawing.Size(547, 368);
            this.table_shop.TabIndex = 3;
            // 
            // label_info
            // 
            this.label_info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_info.Location = new System.Drawing.Point(352, 172);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(58, 24);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Price";
            // 
            // label_info3
            // 
            this.label_info3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_info3.AutoSize = true;
            this.label_info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_info3.Location = new System.Drawing.Point(243, 172);
            this.label_info3.Name = "label_info3";
            this.label_info3.Size = new System.Drawing.Size(59, 24);
            this.label_info3.TabIndex = 2;
            this.label_info3.Text = "Song";
            this.label_info3.Click += new System.EventHandler(this.label_info3_Click);
            // 
            // label_info2
            // 
            this.label_info2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_info2.AutoSize = true;
            this.label_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_info2.Location = new System.Drawing.Point(127, 172);
            this.label_info2.Name = "label_info2";
            this.label_info2.Size = new System.Drawing.Size(72, 24);
            this.label_info2.TabIndex = 1;
            this.label_info2.Text = "Author";
            // 
            // label_info1
            // 
            this.label_info1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_info1.AutoSize = true;
            this.label_info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.label_info1.Location = new System.Drawing.Point(19, 172);
            this.label_info1.Name = "label_info1";
            this.label_info1.Size = new System.Drawing.Size(70, 24);
            this.label_info1.TabIndex = 0;
            this.label_info1.Text = "Album";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.table_shop);
            this.Controls.Add(this.label_shop);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.table_shop.ResumeLayout(false);
            this.table_shop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_shop;
        private System.Windows.Forms.TableLayoutPanel table_shop;
        private System.Windows.Forms.Label label_info1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_info3;
        private System.Windows.Forms.Label label_info2;
    }
}