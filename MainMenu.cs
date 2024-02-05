using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MongoDB.Bson;

namespace Spottyfy
{
    public partial class MainMenu : Form
    {
        static bool nightmode = true;
        public string getUser { get; set; }
        public int getTypeOfConnection { get; set; }
        public string getRank { get; set; }
        public int getMoney { get; set; }

        public List <UserData> users { get; set; }

        public void getTheData()
        {
            getUser = this.getUser;
            getMoney = this.getMoney;
            getTypeOfConnection = this.getTypeOfConnection;
        }
        public void resize()
        {
            panel_user.BringToFront();
            panel_top.Width = this.Width;
            int size_width = this.Width;
            panel_user.Location = new Point(size_width - 215, 75);
            //panel_empty.Location = new Point((this.ClientSize.Width / 2) - (panel_empty.Width / 2), 120);
            //panel_empty.Size = new Size((int)(this.ClientSize.Width*0.9), (int)(this.ClientSize.Height*0.9));
            panel_empty.Location = new Point((this.ClientSize.Width/2)-(panel_empty.Width/2),120);
            
        }

        public MainMenu()
        {
            //this.FormBorderStyle= FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            InitializeComponent();
            button_viewsongs.Text = Program.GetLangInstance().Descendants("ViewSongs").FirstOrDefault()?.Value;
            button_usersett.Text = Program.GetLangInstance().Descendants("UserSettings").FirstOrDefault()?.Value;
            button_logout.Text = Program.GetLangInstance().Descendants("Logout").FirstOrDefault()?.Value;
            addSongs.Text = Program.GetLangInstance().Descendants("AddSongs").FirstOrDefault()?.Value;
            label_creditinfo.Text = Program.GetLangInstance().Descendants("Credit").FirstOrDefault()?.Value;
            resize();
        }

        public void SetProfilePicture(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                panel_avatar.BackgroundImage = Image.FromFile(imagePath);
            }
        }
        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            resize();
        }

        public void nightmode_toggle()
        {
            Color bg, fg;
            if (nightmode)
            {
                 bg = ColorTranslator.FromHtml("#E8F9A3");
                 fg = ColorTranslator.FromHtml("#343035");
                this.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                nightmode = false;
            }
            else
            {
                 bg = ColorTranslator.FromHtml("#1A181B");
                 fg = ColorTranslator.FromHtml("#E8F9A3");
                this.BackColor = ColorTranslator.FromHtml("#1A181B");
                nightmode = true;
            }
            ReloadForms(bg, fg);
        }
        public static void ReloadForms(Color bg, Color fg)
        {
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name != "MainMenu" && form.GetType().Name != "Login")
                {
                    formsToClose.Add(form);
                }
            }
            foreach (Form form in formsToClose)
            {
                RecursiveColorChange(form, bg, fg);
            }
        }
        private static void RecursiveColorChange(Control control, Color backColor, Color foreColor)
        {
            if (control is Form || control is Panel || control is Label) {
                control.BackColor = backColor;
            }

            foreach (Control child in control.Controls)
            {
                if (child is Label || child is RadioButton)
                {
                    child.ForeColor = foreColor;
                }
                else if (child is LinkLabel linkLabel) {
                    linkLabel.ForeColor = foreColor;
                    linkLabel.LinkColor = foreColor;
                }

                RecursiveColorChange(child, backColor, foreColor);
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
            moneyupdate();

            if (panel_user.Visible == true)
            {
                panel_user.Visible = false;
            }
            else panel_user.Visible = true;
        }

        private void moneyupdate()
        {
            DataBaseConnect db =Program.GetDBInstance();
            var username = db.connection.GetUserData();
            foreach (var item in username)
            {
                if (item.name == label_username.Text)
                {
                    getMoney = item.money;
                }
            }
            label_creditscore.Text = getMoney.ToString();
        }

        //OTWIERANIE FORMSOW W PANELU

        AppSettings AppSett = new AppSettings() { TopLevel = false, TopMost = true };
        private void button_viewsongs_Click(object sender, EventArgs e)
        {
            SongView Song = new SongView() { TopLevel = false, TopMost = true };
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

        private void button_shoppingcart_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(getTypeOfConnection) { TopLevel = false, TopMost = true };
            shop.FormBorderStyle = FormBorderStyle.None;
            panel_empty.Controls.Clear();
            panel_empty.Controls.Add(shop);
            shop.getUser = getUser;
            shop.getData();
            Console.WriteLine("TUTAJ MAIN MENU SHOP DEKLARACJA PRZEKAZANIA DANYCH OWO");
            nightmode_toggle();
            nightmode_toggle();
            shop.Show();

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
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button_usersett_Click(object sender, EventArgs e)
        {
            //string newgetuser = this.getUser;
            UserSettings userSettings = new UserSettings();
            userSettings.getUsername = label_username.Text;
            userSettings.getRank = getRank;
            userSettings.users = users;
            Console.WriteLine(users.Count());
            Console.WriteLine(userSettings.users.Count());
            Console.WriteLine(userSettings.users[0].ToJson());
            Console.WriteLine("TUTAJ MAIN MENU USER DEKLARACJA PRZEKAZANIA DANYCH OWO");
            Console.WriteLine(getTypeOfConnection);
            Console.WriteLine(userSettings.getUsername);
            userSettings.getTheData();
            userSettings.ShowDialog();
        }

        

        private void nightmodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nightmode_toggle();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            right_cilck_menu.Visible = true;
        }

        private void addSongs_Click(object sender, EventArgs e)
        {
            AddSong asForm = new AddSong();
            asForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            asForm.MaximizeBox = false;
            asForm.MinimizeBox = false;
            asForm.BackColor = ColorTranslator.FromHtml("#1A181B");
            asForm.Show();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
