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
            button_shortcut_info.Text = Program.GetLangInstance().Descendants("SInfo").FirstOrDefault()?.Value;
            button_app_info.Text = Program.GetLangInstance().Descendants("AInfo").FirstOrDefault()?.Value;
            button_main_settings.Text = Program.GetLangInstance().Descendants("Main").FirstOrDefault()?.Value;
            label_app_sett.Text = button_main_settings.Text;
            ShowMainSettings();
        }

        private void button_shortcut_info_Click(object sender, EventArgs e)
        {
            ShortcutInfo siForm = new ShortcutInfo() { TopLevel = false, TopMost = true };
            label_app_sett.Text=button_shortcut_info.Text;
            displayPanel.Controls.Clear();
            siForm.FormBorderStyle = FormBorderStyle.None;
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(siForm);
            siForm.BackColor = this.BackColor;
            siForm.Show();
        }

        private void button_main_settings_Click(object sender, EventArgs e)
        {
            ShowMainSettings();
        }
        private void ShowMainSettings() {
            MainSettings msForm = new MainSettings(displayPanel) { TopLevel = false, TopMost = true };
            label_app_sett.Text = button_main_settings.Text;
            msForm.FormBorderStyle = FormBorderStyle.None;
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(msForm);
            Console.WriteLine(this.BackColor);
            msForm.BackColor = this.BackColor;
            msForm.Show();
        }

        private void button_app_info_Click(object sender, EventArgs e)
        {
            label_app_sett.Text=button_app_info.Text;
            displayPanel.Controls.Clear();
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
