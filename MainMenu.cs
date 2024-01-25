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
        public MainMenu()
        {
            InitializeComponent();
            //this.AutoScaleMode = AutoScaleMode.Dpi;
            panel_top.Width = this.Width;

            //ni dziala dodawanie obrazu do przycisku ze zmiana size
            //ImageList imageList1 = new ImageList();
            //imageList1.ImageSize = new Size(25,25);
            //imageList1.Images.Add(global::Spottyfy.Properties.Resources.logout);
            //button_logout.ImageList = imageList1;
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            panel_top.Width = this.Width;
        }
        private void button_nightmode_Click(object sender, EventArgs e)
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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            song.FormBorderStyle = FormBorderStyle.None;
            panel_empty.Controls.Add(song);
            song.Show();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
