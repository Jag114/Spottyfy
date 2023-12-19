using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class MongoDB : IDB
    {
        MongoClient connection;
        readonly string login, password;

        public MongoDB(string login = "fellen", string password = "ljrpo7G8qbt6mAeK")
        {
            this.login = login;
            this.password = password;

            try
            {
                connection = new MongoClient($"mongodb+srv://{this.login}:{this.password}@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
                if (connection == null)
                {
                    Console.WriteLine("MongoClient returned null, no connection");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ConnectMongo methodd: " + e.Message);
                connection = null;
            }
            /*
             Console.WriteLine("DB type is: " + dbType);
             var dbList = mongoClient.ListDatabases().ToList();
             //Console.WriteLine(dbList);
             var db = mongoClient.GetDatabase("Spottyfy");
             Console.WriteLine("DB: " + db);
             var songs = db.GetCollection<SongData>("Songs");
             //Console.WriteLine(db.ToJson());     
            */
        }

        public int DeleteAlbum()
        {
            throw new NotImplementedException();
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
