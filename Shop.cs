using MySqlX.XDevAPI.Relational;
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
    public partial class Shop : Form
    {
        public string getUser {  get; set; }
        int type;
        public Shop(int getTypeOfConnection)
        {
            InitializeComponent();
            label_info1.Text = Program.GetLangInstance().Descendants("Album").FirstOrDefault()?.Value;
            label_info2.Text = Program.GetLangInstance().Descendants("Author").FirstOrDefault()?.Value;
            label_info3.Text = Program.GetLangInstance().Descendants("Song").FirstOrDefault()?.Value;
            label_info.Text = Program.GetLangInstance().Descendants("Price").FirstOrDefault()?.Value;
            label_shop.Text = Program.GetLangInstance().Descendants("Szop").FirstOrDefault()?.Value;
            Console.WriteLine("OWOWOWOWO");
            Console.WriteLine(type.ToString());
            Console.WriteLine(getTypeOfConnection);
            Console.WriteLine(getUser);

            
            DataBaseConnect db = Program.GetDBInstance();
            var songs = db.connection.GetSongData();
            var albums = db.connection.GetAlbumData();
            var users = db.connection.GetUserData();

            table_shop.RowCount = songs.Count+1;

            for (int i =1; i< songs.Count; i++) 
            {
                Label label_album = new Label();
                foreach (AlbumData item in albums) 
                {
                    if (songs[i].album == item.Id)
                    {
                        label_album.Text = item.name;
                    }

                }
                label_album.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_album, 0, i);

                Label label_author = new Label();
                label_author.Text = songs[i].author;
                label_author.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_author,1,i);

                Label label_song = new Label();
                label_song.Text = songs[i].name;
                label_song.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_song, 2, i);

                Label label_price = new Label();
                label_price.Text = songs[i].cost.ToString();
                label_price.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_price, 3, i);

                Button button = new Button();
                button.Name = "button" + i.ToString();
                button.Click += Button_Click;
                button.Text = "Buy";
                button.FlatStyle=FlatStyle.Flat;
                button.AutoSize = true;
                button.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                button.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                table_shop.Controls.Add(button, 4, i);
            }

            int newHeight = 40;

            for (int i = 0; i < table_shop.RowStyles.Count; i++)
            {
                table_shop.RowStyles[i] = new RowStyle(SizeType.Absolute, newHeight);
            }
            
        }

        public void getData()
        {
            getUser = this.getUser;
        }

        private void Button_Click(object sender, EventArgs e)
        { 
            
            DataBaseConnect db = Program.GetDBInstance();
            var users = db.connection.GetUserData();
            var songs = db.connection.GetSongData();

            int balance = 0;

            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Name;
            string numericPart = buttonName.Substring("button".Length);

            if (int.TryParse(numericPart, out int buttonNumber))
            {
                foreach (var item in users)
                {
                    if (item.name == getUser)
                    {
                        balance = item.money - songs[buttonNumber].cost;
                        if (balance > 0)
                        {
                            UserData user = new UserData();
                            user.Id = item.Id;
                            user.name = item.name;
                            user.password = item.password;
                            user.money = balance;
                            user.creationDate = item.creationDate;
                            user.rank = item.rank;
                            db.connection.UpdateData(user, item.Id);

                            string errorMessage = "You have bought this song";
                            AlertBox alertBox = new AlertBox();
                            alertBox.UpdateLabelTextAndCenterSUCCES(errorMessage);
                            alertBox.Show();

                            MainMenu main = new MainMenu();
                            main.getTheData();
                        }
                        else 
                        {
                            string errorMessage = "You don't have enough credit to buy this song";
                            AlertBox alertBox = new AlertBox();
                            alertBox.UpdateLabelTextAndCenterFAILED(errorMessage);
                            alertBox.Show();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Error extracting button number.");
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void label_info3_Click(object sender, EventArgs e)
        {

        }
    }
}
