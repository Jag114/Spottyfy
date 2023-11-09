using MongoDB.Bson;
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
    public class DataBaseConnect
    {
        int dbType;
        public DataBaseConnect(int db)
        {
            dbType = db;
        }

        public string Connect()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:password@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("DB type is: " + dbType);
            var dbList = dbClient.ListDatabases().ToList();
            //Console.WriteLine(dbList);
            var db = dbClient.GetDatabase("Spottyfy");
            Console.WriteLine("DB: " + db);
            var songs = db.GetCollection<SongData>("Songs");
            
            return "";
        } 

        //return a collection of songs from the mongoDB db in a List format, list itself
        //an each song in list can be ToJson'ed so they are easier to work with
        public List<SongData> GetSongs(IMongoCollection<SongData> collection)
        {
            List<SongData> songsList = collection.Find(song => true).ToList();
            return songsList;
        }

        //adds singular song to mongoDB db
        public void AddSong(IMongoCollection<SongData> collection, SongData newSong)
        {
            collection.InsertOne(newSong);
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
    }
}
