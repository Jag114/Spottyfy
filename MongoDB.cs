﻿using MongoDB.Bson;
using MongoDB.Driver;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class MongoDB : IDB
    {
        MongoClient connection;
        IMongoDatabase db;
        readonly string login, password, dbName;

        public MongoDB(string login = "fellen", string password = "ljrpo7G8qbt6mAeK", string dbName = "Spottyfy")
        {
            this.login = login;
            this.password = password;
            this.dbName = dbName;

            try
            {
                connection = new MongoClient($"mongodb+srv://{this.login}:{this.password}@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
                if (connection == null)
                {
                    Console.WriteLine("MongoClient returned null, no connection");
                    throw new Exception("NULL MongoClient");
                }
                db = connection.GetDatabase(dbName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in ConnectMongo methodd: " + e.Message);
                connection = null;
            }
        }

        public int TestData()
        {
            var db = connection.GetDatabase("Spottyfy");
            var songsCollection = db.GetCollection<SongData>("Songs");
            var albumsCollection = db.GetCollection<AlbumData>("Albums");

            //display data
            List<SongData> songs = new List<SongData>();
            var result = songsCollection.Find(Builders<SongData>.Filter.Empty).ToList();
            foreach (var doc in result)
            {
                Console.WriteLine(doc.ToBsonDocument());
            }
            Console.WriteLine("------ Filtered data ------");
            var filter = Builders<SongData>.Filter.Eq("name", "test1");
            result = songsCollection.Find(filter).ToList();
            foreach (var doc in result)
            {
                songs.Add(doc);
            }
            foreach(var song in songs)
            {
                Console.WriteLine(song.ToBsonDocument());
            }

            //add data
            SongData s = new SongData();
            s.name = "new me";
            //s.album = "idk";
            //Console.WriteLine(albumsCollection.Find(Builders<AlbumData>.Filter.Eq("name", "BestestAlbum")).ToList()[0].name.ToString());
            s.author = albumsCollection.Find(Builders<AlbumData>.Filter.Eq("name", "BestestAlbum")).ToList()[0].name.ToString();
            //s.releaseDate = DateTime.Now.ToString();
            //songsCollection.InsertOne(s);

            //delete data
            songsCollection.DeleteOne(Builders<SongData>.Filter.Eq("name", "testUPDATED"));

            //update data
            var f = Builders<SongData>.Filter.Eq(song => song.Id, "6543b61390758d44f6d17b62");
            var update = Builders<SongData>.Update.Set(song => song.name, "Updated song");
            songsCollection.UpdateOne(f, update);

            return 0;
        }

        public List<SongData> GetSongData()
        {
            List<SongData> songs = new List<SongData>();
            try
            {
                var collection = db.GetCollection<SongData>("Songs");
                var results = collection.Find(Builders<SongData>.Filter.Empty).ToList();
                foreach (var doc in results)
                {
                    songs.Add(doc);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return songs;
        }

        public List<AlbumData> GetAlbumData()
        {
            List<AlbumData> albums = new List<AlbumData>();
            try
            {
                var collection = db.GetCollection<AlbumData>("Albums");
                var results = collection.Find(Builders<AlbumData>.Filter.Empty).ToList();
                foreach (var doc in results)
                {
                    albums.Add(doc);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return albums;
        }

        public List<AuthorData> GetAuthorData()
        {
            List<AuthorData> authors = new List<AuthorData>();
            try
            {
                var collection = db.GetCollection<AuthorData>("Authors");
                var results = collection.Find(Builders<AuthorData>.Filter.Empty).ToList();
                foreach (var doc in results)
                {
                    authors.Add(doc);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return authors;
        }

        public List<UserData> GetUserData()
        {
            List<UserData> albums = new List<UserData>();
            try
            {
                var collection = db.GetCollection<UserData>("Users");
                var results = collection.Find(Builders<UserData>.Filter.Empty).ToList();
                foreach (var doc in results)
                {
                    albums.Add(doc);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return albums;
        }

        public int AddData(SongData x)
        {
            try
            {
                var collection = db.GetCollection<SongData>("Songs");
                collection.InsertOne(x);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 0;
        }

        public int AddData(AlbumData x)
        {
            try
            {
                var collection = db.GetCollection<AlbumData>("Albums");
                collection.InsertOne(x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 0;
        }

        public int AddData(AuthorData x)
        {
            try
            {
                var collection = db.GetCollection<AuthorData>("Authors");
                collection.InsertOne(x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 0;
        }

        public int AddData(UserData x)
        {
            try
            {
                var collection = db.GetCollection<UserData>("Users");
                if(collection.CountDocuments(Builders<UserData>.Filter.Empty) == 0)
                {
                    x.rank = "admin";
                } 
                collection.InsertOne(x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 0;
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
