using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;

namespace Spottyfy
{
    public class SongData
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //[BsonElement("basic-info")]
        public string name { get; set; }

        public string author { get; set; }

        public string album { get; set; }

        public DateTime releaseDate { get; set; }

        public static List<SongData> getSongsFromAlbum(string albumId) {
            /*
            List<SongData> songs;
            DataBaseConnect connection = new DataBaseConnect(2);//enum instead of magical number?
            connection.Connect();
            //connection.AddSong(connection.GetSongCollection());
            songs = connection.GetSongFromAlbum(connection.GetSongCollection(), albumId);
            return songs;
            */
            return null;
        }
    }
}
