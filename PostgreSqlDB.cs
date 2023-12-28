using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Npgsql;
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
        readonly string login, password;

        public PostgreSqlDB(string login = "postgres", string password = "postgres")
        {
            this.login = login;
            this.password = password;

            try
            {
                string connectionString = $"Host=localhost;Username={login};Password={password};Database=test";
                connection = new NpgsqlConnection(connectionString);
                if (connection == null)
                {
                    Console.WriteLine("PostgreSQL returned null, no connection");
                }
                
                NpgsqlDataSource dataSource = NpgsqlDataSource.Create(connectionString);
                NpgsqlCommand command = dataSource.CreateCommand("SELECT * FROM table1");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    Console.WriteLine(reader.GetInt64(0));
                    Console.WriteLine(reader.GetString(1));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ConnectPostgresql: " + e.Message);
            }
        }

        public int DeleteAlbum()
        {
            return 0;
        }

        public JArray GetData(string dataType)
        {
            Console.WriteLine("AAAAAA");
            return new JArray();
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

        public int TestData()
        {
            throw new NotImplementedException();
        }
    }
}
