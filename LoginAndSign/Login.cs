using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Spottyfy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //test
            /*
            int type = 2;
            DataBaseConnect db = new DataBaseConnect(type);//1-mongo, 2-mysql
            List<UserData> users = db.connection.GetUserData();
            UserData user = users[2];
            List<SongData> songs = db.connection.GetSongData();
            SongData song = songs[0];
            user.Buy(song);
            Console.WriteLine(user.money);
            user.money = 10;
            user.Buy(song);
            Console.WriteLine(user.money);
            */
        }

        private void button_loggin_window_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        int type = 1; //database login

        //CHECKBOXS
        private void select_mysql_CheckedChanged(object sender, EventArgs e)
        {
            if (select_mysql.Checked)
            {
                type = 2;
            }
        }

        private void select_mongo_CheckedChanged(object sender, EventArgs e)
        {
            if (select_mongo.Checked)
            {
                type = 1;
            }
        }

        private void PerformLogin()
        {
            Program.InitializeDB(type);
            DataBaseConnect db = Program.GetDBInstance();
            string getUser = input_username_login_window.Text;
            string getRank = "rank";
            int getMoney = 0;

            if (db.connection.Authenticate(input_username_login_window.Text, input_password_login_window.Text)==0)
            {
                var username = db.connection.GetUserData();
                foreach (var item in username)
                {
                    if (item.name == input_username_login_window.Text)
                    {
                        getRank = item.rank;
                        getMoney = item.money;
                    }
                }

                this.Hide();
                List <UserData> userDatas = new List<UserData>();
                userDatas = db.connection.GetUserData();
                MainMenu MainMenuOpen = Program.GetMainMenuInstance();
                MainMenuOpen.users = userDatas;
                MainMenuOpen.getUser = getUser;
                Console.WriteLine(userDatas.Count);
                Console.WriteLine(MainMenuOpen.users[0].ToJson());
                MainMenuOpen.getRank = getRank;
                MainMenuOpen.getMoney = getMoney;
                MainMenuOpen.getTypeOfConnection = type;
                MainMenuOpen.getTheData();
                MainMenuOpen.ShowDialog();
            }
            else
            {
                label_failed_login_window.Visible = true;
            }
        }
        private void input_password_login_window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void button_exit_login_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button_singup_login_window_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SignUpOpen = new SignUp();
            SignUpOpen.ShowDialog();
        }

        private void label_failed_login_window_Click(object sender, EventArgs e)
        {

        }

        private void panel_login_window_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
