using MongoDB.Bson;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class Album
    {
        public string title { get; set; }
        public string artist { get; set; }

        public static List<Album> getAlbumsMethod() {
        List<Album> albums = new List<Album>();

        //tu beda dane z bazy
        DataBaseConnect DB = new DataBaseConnect(1);
        string data = DB.Connect();

        string[] titles = { "Album1", "Album2" };
        string[] artists = { "Artist1", "Artist2" };
            for(int i=0; i<titles.Length; i++)
            {
                
                albums.Add(new Album() { 
                    title = data, artist = artists[i] 
                });
                
                
            }
            return albums;
        }
        

    }
}

