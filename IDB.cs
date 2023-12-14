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
        JArray GetSong();
        JArray UpdateSong();
        JArray DeleteSong();
        JArray GetSongs();
        JArray UpdateSongs();
        JArray DeleteSongs();

        JArray GetAlbum();
        JArray UpdateAlbum();
        JArray DeleteAlbum();
        JArray GetAlbums();
        JArray UpdateAlbums();
        JArray DeleteAlbums();

        JArray GetAuthor();
        JArray UpdateAuthor();
        JArray DeleteAuthor();
        JArray GetAuthors();
        JArray UpdateAuthors();
        JArray DeleteAuthors();

        JArray GetUser();
        JArray UpdateUser();
        JArray DeleteUser();
        JArray GetUsers();
        JArray UpdateUsers();
        JArray DeleteUsers();

        JArray GetUserSettings();

    }
}
