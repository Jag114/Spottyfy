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
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:XtdGTzNozKUTkjAh@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("DB type is: " + dbType);
            var dbList = dbClient.ListDatabases().ToList();
            //Console.WriteLine(dbList);
            var db = dbClient.GetDatabase("Spottyfy");
            Console.WriteLine("DB: " + db);
            var songs = db.GetCollection<SongData>("Songs");

            //ADD
            SongData songTest = new SongData()
            {
                name = "test1",
                author = "me",
                album = "the-best",
                releaseDate = "today"
            };
            //songs.InsertOne(songTest);

            //UPDATE
            SongData songTestUpdated = new SongData()
            {
                Id = "6543b5de247e76261186eeb4",
                name = "testUPDATED",
                author = "future-me",
                album = "the-bestest",
                releaseDate = "tomorrow"
            };
            songs.ReplaceOne(song => song.Id == "6543b5de247e76261186eeb4", songTestUpdated);

            //DISPLAY
            List<SongData>songsList = songs.Find(song => true).ToList();
            Console.WriteLine("Song numero uno: " + songsList.First().ToJson());
            foreach(var songDoc in songsList)
            {
                Console.WriteLine(songDoc.ToJson());
            }

            //DELETE
            songs.DeleteOne(song => song.Id == "some id");

            //string data[] = string.Join(" ", dbList[0]);
            Console.WriteLine("DB list: " + dbList.ToJson());
            //Console.WriteLine("Data: " + data.ToJson());
            string data = dbList.ToJson();
            
            return data;
        } 
    }
}
