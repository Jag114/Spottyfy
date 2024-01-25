﻿using MongoDB.Bson;
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
            db.connection.TestData();
            db.connection.Authenticate("me", "1");
            /*
            UserData user = new UserData{
                name = "user3",
                creationDate = DateTime.Now,
                password = "password",
                rank = "newbie"
            };
            db.connection.AddData(user);
            SongData song = new SongData
            {
                name = "song1",
                album = "1",
                author = "someone",
                releaseDate = DateTime.Now
            };
            db.connection.AddData(song);
            AlbumData album = new AlbumData
            {
                name = "aaaalbum",
                author = "somebody",
                releaseDate = DateTime.Now
            };
            db.connection.AddData(album);
            AuthorData author = new AuthorData
            {
                name = "author2",
            };
            db.connection.AddData(author);
            */
            /*
            var a = db.connection.GetSongData();
            Console.WriteLine("Songs:");
            foreach (var s in a)
            {
                Console.WriteLine(s.ToJson());
            }
            var b = db.connection.GetAlbumData();
            Console.WriteLine("Albums:");
            foreach (var s in b)
            {
                Console.WriteLine(s.ToJson());
            }
            var c = db.connection.GetAuthorData();
            Console.WriteLine("Authors:");
            foreach (var s in c)
            {
                Console.WriteLine(s.ToJson());
            }
            var d = db.connection.GetUserData();
            Console.WriteLine("Users:");
            foreach (var s in d)
            {
                Console.WriteLine(s.ToJson());
            }
            */
            //DataBaseConnect db2 = new DataBaseConnect(3);
            //db2.connection.TestData();


        }

        string placeholder_databaseuser = "test";
        string placeholder_databasepassword = "test123";



        private void button_loggin_window_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }
        private void PerformLogin()
        {
            if (input_username_login_window.Text == placeholder_databaseuser && input_password_login_window.Text == placeholder_databasepassword)
            {
                this.Hide();
                MainMenu MainMenuOpen = new MainMenu();
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
