using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spottyfy
{
    public partial class TitleChange : Form
    {
        private Button button1;
        private TextBox textBox1;

        public TitleChange()
        {
            InitializeComponent();
        }
        private void InitializeComponent() { 
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleChange
            // 
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "TitleChange";
            this.Load += new System.EventHandler(this.TitleChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SetApplicationTitle(textBox1.Text);
            MainSettings.WriteToConfigFile("settings.cfg", "title", textBox1.Text);
            this.Hide();
        }

        private void TitleChange_Load(object sender, EventArgs e)
        {

        }
    }
}
