using System.Collections.Generic;
using Msma.Integrations.Common;
using Msma.Integrations.Spotify.Models;

namespace Msma.Integrations.Spotify
{
    public class SpotifyGateway
    {
        private const string UriBase = "https://api.spotify.com/v1/";
        private const string CountryCode = "NO";
        private static string _apiToken;

        private static readonly JsonFetcher Fetcher = new JsonFetcher();

        public Artist FetchArtist(string id)
        {
            return FetchSpotifyData<Artist>("artists", id);
        }
        
        public IEnumerable<Album> FetchArtistAlbums(string id)
        {
            return FetchAlbums(id, "album").Items;
        }

        public IEnumerable<Album> FetchArtistSingles(string id)
        {
            return FetchAlbums(id, "single").Items;
        }

        public IEnumerable<Album> FetchArtistAppearsOn(string id)
        {
            return FetchAlbums(id, "appears_on").Items;
        }

        public IEnumerable<Album> FetchArtistCompilation(string id)
        {
            return FetchAlbums(id, "compilation").Items;
        }

        public Album FetchAlbum(string id)
        {
            return FetchSpotifyData<Album>("albums", id);
        }

        public Track FetchTrack(string id)
        {
            return FetchSpotifyData<Track>("tracks", id);
        }

        public User FetchUser(string id)
        {
            return FetchSpotifyData<User>("users", id);
        }

        private static T FetchSpotifyData<T>(string apiMethod, string id)
        {
            string url = UriBase + apiMethod + "/" + id;
            return Fetcher.FetchJson<T>(url);
        }

        private static ArtistAlbumCollection FetchAlbums(string id, string filter)
        {
            const string apiMethod = "artists";
            string url = UriBase + apiMethod + "/" + id + "/albums" + "?market=" + CountryCode + "&album_type=" + filter;
            return Fetcher.FetchJson<ArtistAlbumCollection>(url);
        }

    }
}
