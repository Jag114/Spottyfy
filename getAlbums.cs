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
        string[] titles = { "Album1", "Album2" };
        string[] artists = { "Artist1", "Artist2" };
        for(int i=0; i<titles.Length; i++)
        {
                albums.Add(new Album() { title = titles[i], artist = artists[i] });
        }
            return albums;
        }

}
}

