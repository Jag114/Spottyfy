using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Npgsql;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spottyfy
{
    public class PostgreSqlDB : IDB
    {
        NpgsqlConnection connection;
        string connectionString;
        readonly string login, password;

        public PostgreSqlDB(string login = "postgres", string password = "postgres")
        {
            this.login = login;
            this.password = password;

            try
            {
                connectionString = $"Host=localhost;Username={this.login};Password={this.password};Database=test";
                connection = new NpgsqlConnection(connectionString);
                if (connection == null)
                {
                    Console.WriteLine("PostgreSQL returned null, no connection");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ConnectPostgresql: " + e.Message);
            }
        }


        public int TestData()
        {
            connection.Open();
            string query = "SELECT * FROM songs";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<SongData> songs = new List<SongData>();
            while (reader.Read())
            {
                SongData song = new SongData();
                song.Id = reader["id"].ToString();
                song.name = reader["name"].ToString();
                song.author = reader["author"].ToString();
                song.album = reader["album"].ToString();
                //song.releaseDate = reader["release-date"].ToString();
                songs.Add(song);
            }
            reader.Close();
            connection.Close();
            Console.WriteLine(songs.Count);
            foreach (var s in songs)
            {
                Console.WriteLine(s.name);
            }
            return 0;
        }

        public List<SongData> GetSongData()
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
