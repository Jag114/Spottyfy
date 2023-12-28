using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public interface IDB
    {
        //delete can be one method, takes table as argument
        //update too? should receive new Data object, properties of it are used 
        //in query
        JArray GetData(string dataType);
        int AddData(SongData x);
        int AddData(AlbumData x);
        int AddData(AuthorData x);
        int AddData(UserData x);

        int UpdateData(SongData x, int id);
        int UpdateData(AlbumData x, int id);
        int UpdateData(AuthorData x, int id);
        int UpdateData(UserData x, int id);

        int DeleteData(SongData x, int id);
        int DeleteData(AlbumData x, int id);
        int DeleteData(AuthorData x, int id);
        int DeleteData(UserData x, int id);

        int TestData();
        /*
        JArray GetSong();
        int UpdateSong();
        int DeleteSong();
        JArray GetSongs();
        int UpdateSongs();
        int DeleteSongs();

        JArray GetAlbum();
        int UpdateAlbum();
        int DeleteAlbum();
        JArray GetAlbums();
        int UpdateAlbums();
        int DeleteAlbums();

        JArray GetAuthor();
        int UpdateAuthor();
        int DeleteAuthor();
        JArray GetAuthors();
        int UpdateAuthors();
        int DeleteAuthors();

        JArray GetUser();
        int UpdateUser();
        int DeleteUser();
        JArray GetUsers();
        int UpdateUsers();
        int DeleteUsers();

        JArray GetUserSettings();
        */
    }
}
