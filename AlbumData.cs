using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class AlbumData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //[BsonElement("basic-info")]
        public string name { get; set; } 

        public string author { get; set; }

        public string releaseDate { get; set; }
    }
}
