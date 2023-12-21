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
        readonly string login, password;

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
                    //stop functions from going off if null
                }
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception in ConnectMysql: " + ex.Message);
                MessageBox.Show(ex.Message);
                connection = null;
            }
        }

        ~MySqlDB() 
        {
            connection.Close();
        }

        public int DeleteAlbum()
        {   
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM test.test_table;";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return -1;
            List<string> authors = new List<string>();
            List<SongData> songs = new List<SongData>();
            while (Reader.Read())
            {
                //Console.WriteLine(Reader["author"]);
                authors.Add(Reader["author"].ToString());
                //Console.WriteLine(Reader["song"]);
                string songId = Reader["id"].ToString();
                string songName = Reader["song"].ToString();
                string songAuthor = Reader["author"].ToString();
                string songAlbum = Reader["album"].ToString();
                //songs.Add(Reader["song"].ToString());
                SongData song = new SongData();
                song.Id = songId;
                song.name = songName;
                song.author = songAuthor;
                song.album = songAlbum;
                songs.Add(song);
            }
            Reader.Close();
            Console.WriteLine("Listy: ");
            //authors.ForEach(e => Console.WriteLine(e.ToString()));  
            //songs.ForEach(e => Console.WriteLine(e.ToString()));
            //JArray Jauthors = JArray.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(authors.AsQueryable()));
            JArray Jsongs = JArray.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(songs.AsQueryable()));
            //Console.WriteLine(Jauthors);

            Console.WriteLine(Jsongs);
            return 0;
            //throw new NotImplementedException();
        }

        public int DeleteAlbums()
        {
            throw new NotImplementedException();
        }

        public int DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        public int DeleteAuthors()
        {
            throw new NotImplementedException();
        }

        public int DeleteSong()
        {
            throw new NotImplementedException();
        }

        public int DeleteSongs()
        {
            throw new NotImplementedException();
        }

        public int DeleteUser()
        {
            throw new NotImplementedException();
        }

        public int DeleteUsers()
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

        public int UpdateAlbum()
        {
            throw new NotImplementedException();
        }

        public int UpdateAlbums()
        {
            throw new NotImplementedException();
        }

        public int UpdateAuthor()
        {
            throw new NotImplementedException();
        }

        public int UpdateAuthors()
        {
            throw new NotImplementedException();
        }

        public int UpdateSong()
        {
            throw new NotImplementedException();
        }

        public int UpdateSongs()
        {
            throw new NotImplementedException();
        }

        public int UpdateUser()
        {
            throw new NotImplementedException();
        }

        public int UpdateUsers()
        {
            throw new NotImplementedException();
        }
    }
}
