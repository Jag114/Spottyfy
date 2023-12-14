using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spottyfy
{
    public class MySqlDB : IDB
    {
        MySqlConnection connection;
        string login, password;

        public MySqlDB(string login = "admin", string password = "admin123")
        {
            this.login = login;
            this.password = password;

            string myConnectionString = $"server=127.0.0.1;uid={this.login};pwd={this.password};database=test";
            try
            {
                connection = new MySqlConnection(myConnectionString);
                if (connection == null)
                {
                    Console.WriteLine("MySqlConnection returned null, no connection");
                }
                connection.Open();
                //mySqlConn.Close();//might not be needed?
                /*
                 MySqlCommand cmd = conn.CreateCommand();
                 cmd.CommandText = @"SELECT * FROM test.test_table;";
                 MySqlDataReader Reader = cmd.ExecuteReader();
                 if (!Reader.HasRows) return -1;
                 while (Reader.Read())
                 {
                    Console.WriteLine(Reader["author"]);
                    Console.WriteLine(Reader["song"]);
                 }
                 Reader.Close();

                */
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception in ConnectMysql: " + ex.Message);
                MessageBox.Show(ex.Message);
                connection = null;
            }
            finally
            {
                connection.Close();
            }
        }

        ~MySqlDB() 
        {
            connection.Close();
        }

        public JArray DeleteAlbum()
        {
            Console.WriteLine("MYSQL");
            Console.WriteLine(connection.Database);
            throw new NotImplementedException();
        }

        public JArray DeleteAlbums()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteAuthors()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteSong()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteSongs()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteUser()
        {
            throw new NotImplementedException();
        }

        public JArray DeleteUsers()
        {
            throw new NotImplementedException();
        }

        public JArray GetAlbum()
        {
            throw new NotImplementedException();
        }

        public JArray GetAlbums()
        {
            throw new NotImplementedException();
        }

        public JArray GetAuthor()
        {
            throw new NotImplementedException();
        }

        public JArray GetAuthors()
        {
            throw new NotImplementedException();
        }

        public JArray GetSong()
        {
            throw new NotImplementedException();
        }

        public JArray GetSongs()
        {
            throw new NotImplementedException();
        }

        public JArray GetUser()
        {
            throw new NotImplementedException();
        }

        public JArray GetUsers()
        {
            throw new NotImplementedException();
        }

        public JArray GetUserSettings()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateAlbum()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateAlbums()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateAuthor()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateAuthors()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateSong()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateSongs()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateUser()
        {
            throw new NotImplementedException();
        }

        public JArray UpdateUsers()
        {
            throw new NotImplementedException();
        }
    }
}
