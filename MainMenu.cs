using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spottyfy
{
    public partial class MainMenu : Form
    {
        static bool nightmode = true;
        public string getUser { get; set; }
        public int getTypeOfConnection { get; set; }
        public string getRank { get; set; }
        public void resize()
        {
            panel_user.BringToFront();
            panel_top.Width = this.Width;
            int size_width = this.Width;
            panel_user.Location = new Point(size_width - 215, 75);
            panel_empty.Location = new Point((this.ClientSize.Width/2)-(panel_empty.Width/2),120);
        }

        public MainMenu()
        {
            InitializeComponent();
            resize();
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            resize();
        }

        public void nightmode_toggle()
        {
            if (nightmode)
            {
                button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.whitemoon;
                this.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                foreach (Control control in panel_empty.Controls)
                {
                    if (control is Form)
                    {
                        Form form = (Form)control;
                        form.BackColor = ColorTranslator.FromHtml("#E8F9A3");

                        foreach (Control innerControl in form.Controls)
                        {
                            if (innerControl is Label ||  innerControl is TextBox)
                            {
                                innerControl.ForeColor = ColorTranslator.FromHtml("#343035");
                            }

                            /* NI DZIALA FF
                            if (innerControl.HasChildren)
                            {
                                foreach (Control nestedControl in innerControl.Controls)
                                {
                                    if (nestedControl is Label || nestedControl is TextBox) { nestedControl.ForeColor = ColorTranslator.FromHtml("#D7F75B"); }
                                }
                            }
                            */
                        }
                    }
                }

                nightmode = false;
            }
            else
            {
                button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_night;
                this.BackColor = ColorTranslator.FromHtml("#1A181B");
                foreach (Control control in panel_empty.Controls)
                {
                    if (control is Form)
                    {
                        Form form = (Form)control;
                        form.BackColor = ColorTranslator.FromHtml("#1A181B");

                        foreach (Control innerControl in form.Controls)
                        {
                            if (innerControl is Label || innerControl is TextBox)
                            {
                                innerControl.ForeColor = ColorTranslator.FromHtml("#D7F75B");
                            }
                            /* NI DZIALA FF
                            if (innerControl.HasChildren)
                            {
                                foreach (Control nestedControl in innerControl.Controls)
                                {
                                    if (nestedControl is Label || nestedControl is TextBox) { nestedControl.ForeColor = ColorTranslator.FromHtml("#D7F75B"); }
                                }
                            }
                            */
                        }

                    }

                }

                nightmode = true;
            }
        }
        private void button_nightmode_Click(object sender, EventArgs e)
        {
            nightmode_toggle();
        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //USER PANEL HERE
        private void button_user_Click(object sender, EventArgs e)
        {
            label_username.Text = this.getUser;

            if (panel_user.Visible == true)
            {
                panel_user.Visible = false;
            }
            else panel_user.Visible = true;
        }

        //OTWIERANIE FORMSOW W PANELU

        SongView Song = new SongView() { TopLevel = false, TopMost = true };
        AppSettings AppSett = new AppSettings() { TopLevel = false, TopMost = true };
        private void button_viewsongs_Click(object sender, EventArgs e)
        {
            panel_empty.Controls.Clear();
            Song.FormBorderStyle = FormBorderStyle.None;
            panel_empty.Controls.Add(Song);
            nightmode_toggle();
            nightmode_toggle();
            Song.Show();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            panel_empty.Controls.Clear();
            AppSett.FormBorderStyle = FormBorderStyle.None;
            panel_empty.Controls.Add(AppSett);
            nightmode_toggle();
            nightmode_toggle();
            AppSett.Show();

        }

        //SKROTY KLAWISZOWE
        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                nightmode_toggle();
            }
            if (e.KeyCode == Keys.U)
            {
                button_user_Click(sender, e);
            }
            if (e.KeyCode == Keys.V)
            {
                button_viewsongs_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                button_settings_Click(sender, e);
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_usersett_Click(object sender, EventArgs e)
        {
            //string newgetuser = this.getUser;
            UserSettings userSettings = new UserSettings();
            userSettings.getUsername = label_username.Text;
            userSettings.getRank = getRank;
            userSettings.getTypeOfConnection = getTypeOfConnection;
            userSettings.getTheData();
            userSettings.ShowDialog();
        }

        private void nightmodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nightmode_toggle();
        }
    }
}
