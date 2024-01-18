using MongoDB.Bson;
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

        public int TestData()
        {   
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = @"INSERT INTO test.test_table(album, author, song) VALUES (1, 'visual', 'ms song');";
            //cmd.ExecuteNonQuery();

            cmd.CommandText = @"SELECT * FROM test.test_table;";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return -1;
            List<SongData> songs = new List<SongData>();
            while (Reader.Read())
            {
                //Console.WriteLine(Reader["song"]);
                string songId = Reader["id"].ToString();
                string songName = Reader["song"].ToString();
                string songAuthor = Reader["author"].ToString();
                string songAlbum = Reader["album"].ToString();
                DateTime songReleaseDate = DateTime.Parse(Reader["releaseDate"].ToString());
                //songs.Add(Reader["song"].ToString());
                SongData song = new SongData{
                    Id = songId,
                    name = songName,
                    author = songAuthor,        
                    album = songAlbum,
                    releaseDate = songReleaseDate
                };
                songs.Add(song);
            }
            Reader.Close();
            Console.WriteLine("Listy: ");
            foreach (var item in songs)
            {
                Console.WriteLine(item.ToJson<SongData>());
            }
            return 0;
            //throw new NotImplementedException();
        }

        public List<SongData> GetSongData()
        {
            throw new NotImplementedException();
        }
        public List<SongData> GetSongDataFromAlbum(string albumId)
        {
            throw new NotImplementedException();
        }

        public List<AlbumData> GetAlbumData()
        {
            throw new NotImplementedException();
        }

        public List<AuthorData> GetAuthorData()
        {
            throw new NotImplementedException();
        }

        public List<UserData> GetUserData()
        {
            throw new NotImplementedException();
        }

        public int AddData(SongData x)
        {
            throw new NotImplementedException();
        }

        public int AddData(AlbumData x)
        {
            throw new NotImplementedException();
        }

        public int AddData(AuthorData x)
        {
            throw new NotImplementedException();
        }

        public int AddData(UserData x)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(SongData x, int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(AlbumData x, int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(AuthorData x, int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(UserData x, int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteData(SongData x, int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteData(AlbumData x, int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteData(AuthorData x, int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteData(UserData x, int id)
        {
            throw new NotImplementedException();
        }
    }
}
