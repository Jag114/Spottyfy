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

            Console.WriteLine("AAAAAAAAAAAAAAAA");
            DataBaseConnect connection = new DataBaseConnect(1);//enum instead of magical number?
            connection.Connect("admin", "password");
            var collection = connection.GetSongCollection();
            Console.WriteLine(connection.GetSongs(collection).ToJson());

            //connection.AddSong(collection);

            string[] titles = { "Album1", "Album2" };
            string[] artists = { "Artist1", "Artist2" };
            for(int i=0; i<titles.Length; i++)
            {
                albums.Add(new Album() { 
                    title = titles[i], artist = artists[i] 
                });
            }

            return albums;
        }
        

    }
}

