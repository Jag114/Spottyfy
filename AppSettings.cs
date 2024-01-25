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
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void button_shortcut_info_Click(object sender, EventArgs e)
        {
            label_app_sett.Text=button_shortcut_info.Text;
        }

        private void button_main_settings_Click(object sender, EventArgs e)
        {
            label_app_sett.Text= button_main_settings.Text;
        }

        private void button_app_info_Click(object sender, EventArgs e)
        {
            label_app_sett.Text=button_app_info.Text;
        }
    }
}
