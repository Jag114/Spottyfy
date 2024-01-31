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
    public partial class UserSettings : Form
    {
        public string getUsername { get; set; }
        public string getRank { get; set; }
        public UserSettings()
        {       
            InitializeComponent();            
        }
        public void getTheData()
        {
            label_username.Text = this.getUsername;
            label_rank.Text = this.getRank;
        }
        private void button_usersett_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
