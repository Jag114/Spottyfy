using MongoDB.Bson;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            connection.Connect();
            var collectionS = connection.GetSongCollection();
            var collectionA = connection.GetAlbumCollection();
            var collectionU = connection.GetUserCollection();
            AlbumData album = new AlbumData()
            {
                name = "BestestAlbum",
                author = "me",
                releaseDate = DateTime.Now.ToString("h:mm:ss tt")
            };
            //connection.AddAlbum(collectionA, album);
            album = new AlbumData()
            {
                Id = "654fccd3011b99f6672b6115",
                name = "BestestestAlbum",
                author = "me",
                releaseDate = DateTime.Now.ToString("h:mm:ss tt")
            };
            //connection.UpdateAlbum(collectionA, album, album.Id);
            //connection.DeleteAlbum(collectionA, album.Id);


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

