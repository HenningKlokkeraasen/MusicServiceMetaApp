using System.Net;
using System.Text;
using System.Web.Mvc;
using MusicServiceMetaApp.Web.Models.Spotify;
using Newtonsoft.Json;

namespace MusicServiceMetaApp.Web.Controllers
{
    public class SpotifyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Artist(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            Artist artist = FetchSpotifyData<Artist>("https://api.spotify.com/v1/artists/" + id);

            ArtistAlbumCollection albums = FetchSpotifyData<ArtistAlbumCollection>("https://api.spotify.com/v1/artists/" + id + "/albums?market=NO&album_type=album");
            ArtistAlbumCollection singles = FetchSpotifyData<ArtistAlbumCollection>("https://api.spotify.com/v1/artists/" + id + "/albums?market=NO&album_type=single");
            ArtistAlbumCollection appearsOn = FetchSpotifyData<ArtistAlbumCollection>("https://api.spotify.com/v1/artists/" + id + "/albums?market=NO&album_type=appears_on");
            ArtistAlbumCollection compilations = FetchSpotifyData<ArtistAlbumCollection>("https://api.spotify.com/v1/artists/" + id + "/albums?market=NO&album_type=compilation");

            ArtistViewModel viewModel = new ArtistViewModel
            {
                Artist = artist,
                Albums = albums.Items,
                Singles = singles.Items,
                AppearsOn = appearsOn.Items,
                Compilations = compilations.Items
            };
            return View(viewModel);
        }

        public ActionResult Album(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            Album album = FetchSpotifyData<Album>("https://api.spotify.com/v1/albums/" + id);
            return View(album);
        }

        public ActionResult Track(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            Track track = FetchSpotifyData<Track>("https://api.spotify.com/v1/tracks/" + id);
            return View(track);
        }

        public ActionResult Playlist(string id)
        {
            return View();
        }

        public ActionResult User(string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("Error");

            User user = FetchSpotifyData<User>("https://api.spotify.com/v1/users/" + id);
            return View(user);
        }

        private static T FetchSpotifyData<T>(string url)
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string content = client.DownloadString(url);
            T model = JsonConvert.DeserializeObject<T>(content);
            return model;
        }
    }
}