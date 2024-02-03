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
            int type = 2;
            DataBaseConnect db = new DataBaseConnect(type);//1-mongo, 2-mysql
            List<UserData> list = db.connection.GetUserData();
            UserData old = new UserData();
            MongoIDStandardizer standardizer = new MongoIDStandardizer();
            list[1].Id = standardizer.StandardizeString(list[1].Id);
            old = list[1];
            Console.WriteLine("Old money: " + old.money);
            List<SongData> songs = db.connection.GetSongData();
            old.Buy(songs[0]);
            Console.WriteLine("New money: " + old.money);
            UserData u = new UserData
            {
                name = "updateduser",
                password = old.password,
                rank = old.rank,
                creationDate = old.creationDate,
                money = old.money
            };
            db.connection.UpdateData(u, "2");
            
        }

        private void button_loggin_window_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        int type = 1; //database login

        //CHECKBOXS
        private void select_mysql_CheckedChanged(object sender, EventArgs e)
        {
            select_mongo.Checked = false;
            type = 2;
        }

        private void select_mongo_CheckedChanged(object sender, EventArgs e)
        {
            select_mysql.Checked = false;
            type = 1;
        }
        private void PerformLogin()
        {
            DataBaseConnect db = new DataBaseConnect(type);
            string getUser = input_username_login_window.Text;
            string getRank = "rank";

            if (db.connection.Authenticate(input_username_login_window.Text, input_password_login_window.Text)==0)
            {
                var username = db.connection.GetUserData();
                foreach (var item in username)
                {
                    if (item.name == input_username_login_window.Text)
                    {
                        getRank = item.rank;
                    }
                }

                this.Hide();
                List <UserData> userDatas = new List<UserData>();
                userDatas = db.connection.GetUserData();
                MainMenu MainMenuOpen = new MainMenu();
                MainMenuOpen.users = userDatas;
                MainMenuOpen.getUser = getUser;
                Console.WriteLine(userDatas.Count);
                Console.WriteLine(MainMenuOpen.users[0].ToJson());
                MainMenuOpen.getRank = getRank;
                MainMenuOpen.getTypeOfConnection = type;
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

        

    }
}
