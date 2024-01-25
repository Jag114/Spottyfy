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
                button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_day;
                //button_user.BackgroundImage = global::Spottyfy.Properties.Resources.user1;
                this.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                nightmode = false;
            }
            else 
            {
                button_nightmode.BackgroundImage = global::Spottyfy.Properties.Resources.to_night;
                //button_user.BackgroundImage = global::Spottyfy.Properties.Resources.user0;
                this.BackColor = ColorTranslator.FromHtml("#1A181B");
                nightmode = true;
            }
        }

        private void button_user_MouseHover(object sender, EventArgs e)
        {
            panel_user.Visible = true;
        }

        static void Delay(int ms, EventHandler action)
        {
            var tmp = new System.Windows.Forms.Timer { Interval = ms };
            tmp.Tick += new EventHandler((o, e) => tmp.Enabled = false);
            tmp.Tick += action;
            tmp.Enabled = true;
        }
        private void panel_user_MouseLeave(object sender, EventArgs e)
        {
            Delay(3000, (o, a) => panel_user.Visible = false);
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
