using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Spottyfy
{
    public class Album
    {
        public string id { get; set; }
        public string title { get; set; }
        public string artist { get; set; }

        public static List<Album> getAlbumsMethod() {
            /*
            List<Album> albums = new List<Album>();
            DataBaseConnect connectionSQL = new DataBaseConnect(2);//test for postgresql
            connectionSQL.Connect();
            DataBaseConnect connection = new DataBaseConnect(2);//enum instead of magical number?
            connection.Connect();
            JArray rawAlbums = JArray.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(connection.GetAlbumCollection().AsQueryable()));
            Console.WriteLine(rawAlbums.ToString());
            return albums;
            //AlbumData album = new AlbumData()
            //{
            //    name = "BestestAlbum",
            //    author = "me",
            //    releaseDate = DateTime.Now.ToString("h:mm:ss tt")
            //};
            //connection.AddAlbum(collectionA, album);
            //album = new AlbumData()
            //{
            //    Id = "654fccd3011b99f6672b6115",
            //    name = "BestestestAlbum",
            //    author = "me",
            //    releaseDate = DateTime.Now.ToString("h:mm:ss tt")
            //};
            //connection.UpdateAlbum(collectionA, album, album.Id);
            //connection.DeleteAlbum(collectionA, album.Id);
            foreach (JObject item in rawAlbums)
            {
                albums.Add(new Album() { 
                    title = item.GetValue("name").ToString(), artist = item.GetValue("author").ToString(), id=item.GetValue("Id").ToString()
                });
            }

            return albums;
            */
            return null;
        }
        

    }
}

