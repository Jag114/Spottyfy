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
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //[BsonElement("basic-info")]
        public string name { get; set; }

        public string author { get; set; }

        public string album { get; set; }

        public DateTime releaseDate { get; set; }
    }
}
