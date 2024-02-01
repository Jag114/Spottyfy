using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spottyfy
{
    public partial class UserSettings : Form
    {
        public string getUsername { get; set; }
        public int getTypeOfConnection { get; set; }
        public string getRank { get; set; }

        private int type;

        public UserSettings()
        {   
            InitializeComponent();
            
        }
        public void getTheData()
        {
            label_username.Text = this.getUsername;
            label_rank.Text = this.getRank;
            type = this.getTypeOfConnection;
            
        }

        private void button_usersett_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                panel_avatar.BackgroundImage=Image.FromFile(openFileDialog.FileName);
            }
        }

    }
}
