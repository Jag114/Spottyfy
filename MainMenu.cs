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

        public void resize()
        {
            panel_user.BringToFront();
            panel_top.Width = this.Width;
            int size_width = this.Width;
            int size_height = this.Height;
            panel_user.Location = new Point(size_width - 215, 75);
            panel_empty.Location = new Point(50, 100);
            panel_empty.Width = size_width - 100;
            panel_empty.Height = size_height - 175;
        }
        public MainMenu()
        {
            InitializeComponent();
            //this.KeyDown += MainMenu_KeyDown;
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
                //button_user.BackgroundImage = global::Spottyfy.Properties.Resources.user1;
                this.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                song.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                nightmode = false;
            }
            else
            {
                button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_night;
                //button_user.BackgroundImage = global::Spottyfy.Properties.Resources.user0;
                this.BackColor = ColorTranslator.FromHtml("#1A181B");
                song.BackColor = ColorTranslator.FromHtml("#1A181B");
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

        private void button_user_Click(object sender, EventArgs e)
        {
            if (panel_user.Visible == true)
            {
                panel_user.Visible = false;
            }
            else panel_user.Visible = true;

        }

        SongView song = new SongView() { TopLevel = false, TopMost = true };
        private void button_viewsongs_Click(object sender, EventArgs e)
        {
            song.FormBorderStyle = FormBorderStyle.None;
            panel_empty.Controls.Add(song);
            song.Show();
        }

        //SKROTY KLAWISZOWE
        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                nightmode_toggle();
            }
        }
    }
}
