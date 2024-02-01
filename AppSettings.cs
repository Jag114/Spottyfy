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
        public static MainMenu m;
        public AppSettings()
        {
            InitializeComponent();
        }

        private void button_shortcut_info_Click(object sender, EventArgs e)
        {
            ShortcutInfo siForm = new ShortcutInfo() { TopLevel = false, TopMost = true };
            label_app_sett.Text=button_shortcut_info.Text;
            panel1.Controls.Clear();
            siForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(siForm);
            siForm.BackColor = this.BackColor;
            siForm.Show();
        }

        private void button_main_settings_Click(object sender, EventArgs e)
        {
            MainSettings msForm = new MainSettings(panel1) { TopLevel = false, TopMost = true };
            label_app_sett.Text= button_main_settings.Text;
            msForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(msForm);
            msForm.BackColor = this.BackColor;
            msForm.Show();
        }

        private void button_app_info_Click(object sender, EventArgs e)
        {
            label_app_sett.Text=button_app_info.Text;
            panel1.Controls.Clear();
        }

        private void label_app_sett_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppSettings_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
