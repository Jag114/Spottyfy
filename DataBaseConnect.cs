using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    //return jsons, and get jsons in parameters
    public class DataBaseConnect
    {
        int dbType;
        MongoClient mongoClient;

        public DataBaseConnect(int db)
        {
            dbType = db;
        }

        public int Connect(string login = "admin", string pass = "loHs1lSZ788mv0HK")
        {
            if (pass == "") return -1;

            switch (dbType)
            {
                case 1://mongo
                    try
                    {
                        mongoClient = new MongoClient($"mongodb+srv://{login}:{pass}@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
                        Console.WriteLine("DB type is: " + dbType);
                        var dbList = mongoClient.ListDatabases().ToList();
                        //Console.WriteLine(dbList);
                        var db = mongoClient.GetDatabase("Spottyfy");
                        Console.WriteLine("DB: " + db);
                        var songs = db.GetCollection<SongData>("Songs");
                        //Console.WriteLine(db.ToJson());
                        return 0;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception in DataBaseConnect: " + e.Message);
                        return -1;
                    }

                case 2://firebase

                    return -1;

                case 3://azuresql

                    return -1;

                default:
                    return 0;
            }


        } 

        public IMongoCollection<SongData> GetSongCollection()
        {
            var db = mongoClient.GetDatabase("Spottyfy");
            var songsCollection = db.GetCollection<SongData>("Songs");
            return songsCollection;
        }

        public IMongoCollection<UserData> GetUserCollection()
        {
            var db = mongoClient.GetDatabase("Spottyfy");
            var userCollection = db.GetCollection<UserData>("Users");
            return userCollection;
        }

        public IMongoCollection<AlbumData> GetAlbumCollection()
        {
            var db = mongoClient.GetDatabase("Spottyfy");
            var albumCollection = db.GetCollection<AlbumData>("Albums");
            return albumCollection;
        }

        //song
        //return a collection of songs from the mongoDB db in a List format, list itself
        //an each song in list can be ToJson'ed so they are easier to work with
        public List<SongData> GetSongs(IMongoCollection<SongData> collection)
        {
            List<SongData> songsList = collection.Find(song => true).ToList();
            return songsList;
        }

        public List<SongData> GetSongFromAlbum(IMongoCollection<SongData> collection, string albumId)
        {
            var song = collection.Find(s => s.album == albumId).ToList();
            return song;
        }

        //adds singular song to mongoDB db
        //chekc if possible withou id
        public void AddSong(IMongoCollection<SongData> collection, SongData newSong)
        {
            //create new song with json
            collection.InsertOne(newSong);
        }

        public void AddSong(IMongoCollection<SongData> collection)
        {
            SongData songTest = new SongData()
            {
                name = "test1",
                author = "me",
                album = "the-best",
                releaseDate = DateTime.Now.ToString("h:mm:ss tt")
            };
            collection.InsertOne(songTest);
        }

        //updates singular song in the mongoDB db based on the ID given in parameters 
        //how to get the same id for both of them
        public void UpdateSong(IMongoCollection<SongData> collection, SongData updatedSong, string songId)
        {
            collection.ReplaceOne(song => song.Id == songId, updatedSong);
        }

        //deletes singular song from mongoDB db based on the ID given in parameters
        public void DeleteSong(IMongoCollection<SongData> collection, string songId)
        {
            collection.DeleteOne(song => song.Id == songId);
        }


        //user
        //useless?
        public List<UserData> GetUser(IMongoCollection<UserData> collection, string userId)
        {
            var user = collection.Find(u => u.Id == userId).ToList();
            return user;
        }

        public void AddUser(IMongoCollection<UserData> collection, UserData user)
        {
            collection.InsertOne(user);
        }

        public void UpdateUser(IMongoCollection<UserData> collection, UserData updatedUser, string userId)
        {
            collection.ReplaceOne(u => u.Id == userId, updatedUser);
        }

        public void DeleteUser(IMongoCollection<UserData> collection, string userId)
        {
            collection.DeleteOne(u => u.Id == userId);
        }

        //album
        public List<AlbumData> GetAlbum(IMongoCollection<AlbumData> collection, string albumId)
        {
            var album = collection.Find(a => a.Id == albumId).ToList();
            return album;
        }

        public void AddAlbum(IMongoCollection<AlbumData> collection, AlbumData album)
        {
            collection.InsertOne(album);
        }

        public void UpdateAlbum(IMongoCollection<AlbumData> collection, AlbumData updatedAlbum, string albumId)
        {
            collection.ReplaceOne(a => a.Id == albumId, updatedAlbum);
        }

        public void DeleteAlbum(IMongoCollection<AlbumData> collection, string albumId)
        {
            collection.DeleteOne(a => a.Id == albumId);
        }
    }
}
