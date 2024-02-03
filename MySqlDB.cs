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
        const string dbName = "test";
        const string songsTable = "songs";
        const string usersTable = "users";
        const string albumsTable = "albums";
        const string authorsTable = "authors";

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

            cmd.CommandText = $"SELECT * FROM test.{dbName};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return -1;
            List<SongData> songs = new List<SongData>();
            while (Reader.Read())
            {
                //Console.WriteLine(Reader["song"]);
                string songId = Reader["id"].ToString();
                string songName = Reader["name"].ToString();
                string songAuthor = Reader["author"].ToString();
                string songAlbum = Reader["album"].ToString();
                DateTime songReleaseDate = DateTime.Parse(Reader["releaseDate"].ToString());
                //songs.Add(Reader["song"].ToString());

                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                SongData song = new SongData {
                    Id = standardizedID,
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
                Console.WriteLine(item.ToJson());
            }
            return 0;
        }

        public List<SongData> GetSongData()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{songsTable};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;
            List<SongData> songs = new List<SongData>();
            while (Reader.Read())
            {
                string songId = Reader["id"].ToString();
                string songName = Reader["name"].ToString();
                string songAuthor = Reader["author"].ToString();
                string songAlbum = Reader["album"].ToString();
                DateTime songReleaseDate = DateTime.Parse(Reader["releaseDate"].ToString());

                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                SongData song = new SongData
                {
                    Id = standardizedID,
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
                Console.WriteLine(item.ToJson());
            }
            return songs;
        }

        public List<SongData> GetSongDataFromAlbum(string albumId)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{songsTable} WHERE id = {albumId};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;
            List<SongData> songs = new List<SongData>();
            while (Reader.Read())
            {
                string songId = Reader["id"].ToString();
                string songName = Reader["song"].ToString();
                string songAuthor = Reader["author"].ToString();
                string songAlbum = Reader["album"].ToString();
                DateTime songReleaseDate = DateTime.Parse(Reader["releaseDate"].ToString());

                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                SongData song = new SongData
                {
                    Id = standardizedID,
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
                Console.WriteLine(item.ToJson());
            }
            return songs;
        }

        public List<AlbumData> GetAlbumData()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{albumsTable};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;
            List<AlbumData> albums = new List<AlbumData>();
            while (Reader.Read())
            {
                string songId = Reader["id"].ToString();
                string songName = Reader["name"].ToString();
                string songAuthor = Reader["author"].ToString();
                
                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                AlbumData album = new AlbumData
                {
                    Id = standardizedID,
                    name = songName,
                    author = songAuthor,
                };
                albums.Add(album);
            }
            Reader.Close();
            Console.WriteLine("Listy: ");
            foreach (var item in albums)
            {
                Console.WriteLine(item.ToJson());
            }
            return albums;
        }

        public List<AuthorData> GetAuthorData()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{authorsTable};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;
            List<AuthorData> authors = new List<AuthorData>();
            while (Reader.Read())
            {
                string songId = Reader["id"].ToString();
                string songName = Reader["name"].ToString();

                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                AuthorData author = new AuthorData
                {
                    Id = standardizedID,
                    name = songName,
                };
                authors.Add(author);
            }
            Reader.Close();
            Console.WriteLine("Listy: ");
            foreach (var item in authors)
            {
                Console.WriteLine(item.ToJson());
            }
            return authors;
        }

        public List<UserData> GetUserData()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{usersTable};";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;
            List<UserData> users = new List<UserData>();
            while (Reader.Read())
            {
                string songId = Reader["id"].ToString();
                string songName = Reader["name"].ToString();
                string songAuthor = Reader["password"].ToString();
                string songAlbum = Reader["rank"].ToString();
                

                MongoIDStandardizer mongoIDStandardizer = new MongoIDStandardizer();
                string standardizedID = mongoIDStandardizer.StandardizeString(songId);

                UserData user = new UserData
                {
                    Id = standardizedID,
                    name = songName,
                    password = songAuthor,
                    rank = songAlbum,
                    //creationDate = songReleaseDate
                };
                users.Add(user);
            }
            Reader.Close();
            Console.WriteLine("Listy: ");
            foreach (var item in users)
            {
                Console.WriteLine(item.ToJson());
            }
            return users;
        }

        public int AddData(SongData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"INSERT INTO {dbName}.{songsTable}(album, author, song) VALUES ({x.album}, '{x.author}', '{x.name}');";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int AddData(AlbumData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"INSERT INTO {dbName}.{albumsTable}(name, author, releaseDate) VALUES ({x.name}, '{x.author}', '{x.releaseDate}');";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int AddData(AuthorData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"INSERT INTO {dbName}.{authorsTable}(name) VALUES ('{x.name}');";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int AddData(UserData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM {usersTable}";
                MySqlDataReader Reader = cmd.ExecuteReader();
                bool first = false;
                while (Reader.Read())
                {
                    if (Reader[0].ToString() == "0")
                    {
                        first = true;
                    }
                }
                if (first)
                {
                    cmd.CommandText = $"INSERT INTO {dbName}.{usersTable}(name, password, rank, creationDate) VALUES ({x.name}, '{x.password}', 'admin', '{x.creationDate});";
                }
                else
                {
                    cmd.CommandText = $"INSERT INTO {dbName}.{usersTable}(name, password, rank, creationDate) VALUES ({x.name}, '{x.password}', '{x.rank}', '{x.creationDate});";
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }
        
        public int UpdateData(SongData x, string id)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `{dbName}.{songsTable}` SET `name` = '{x.name}', author = {x.author}, album = {x.album}, releaseDate = '{x.releaseDate} WHERE `{songsTable}`.`id` = {id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int UpdateData(AlbumData x, string id)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `{dbName}.{albumsTable}` SET `name` = '{x.name}', author = {x.author}, releaseDate = '{x.releaseDate} WHERE `{albumsTable}`.`id` = {id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int UpdateData(AuthorData x, string id)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `{dbName}.{authorsTable}` SET `name` = '{x.name}' WHERE `{authorsTable}`.`id` = {id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }
        
        public int UpdateData(UserData x, string id)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `{usersTable}` SET `name` = '{x.name}', rank = '{x.rank}', password = '{x.password}', money = '{x.money}' WHERE `{usersTable}`.`id` = {id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update" + ex.Message);
                return -1;
            }
            return 0;
        }

        public int DeleteData(SongData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"DELETE FROM {dbName}.{songsTable} WHERE `songs`.`id` = {x.Id}";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int DeleteData(AlbumData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"DELETE FROM {dbName}.{albumsTable} WHERE `albums`.`id` = {x.Id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int DeleteData(AuthorData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"DELETE FROM {dbName}.{authorsTable} WHERE `authors`.`id` = {x.Id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int DeleteData(UserData x)
        {
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"DELETE FROM {dbName}.{usersTable} WHERE `users`.`id` = {x.Id};";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }

        public int Authenticate(string login, string password)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {dbName}.{songsTable} WHERE name = '{login}';";
            MySqlDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return -1;
            string pass = "";
            while (Reader.Read())
            {
                pass = Reader["password"].ToString();  
            }
            if(pass != password)
            {
                Console.WriteLine("Wrong password");
                return -1;
            }
            Reader.Close();
            return 0;
        }
    }
}
