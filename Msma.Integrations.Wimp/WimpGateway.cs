using System.Collections.Generic;
using Msma.Integrations.Common;
using Msma.Integrations.Wimp.Models;

namespace Msma.Integrations.Wimp
{
    public class WimpGateway
    {
        private const string UriBase = "https://play.wimpmusic.com/v1/";
        private const string CountryCode = "NO";
        private static string _apiToken;

        private static readonly JsonFetcher Fetcher = new JsonFetcher();

        public WimpGateway(string apiToken)
        {
            _apiToken = apiToken;
        }

        public Artist FetchArtist(int id)
        {
            return FetchWimpData<Artist>("artists", id);
        }

        public IEnumerable<Album> FetchArtistAlbums(int id)
        {
            return FetchAlbums(id, "ALBUMS").Items;
        }

        public IEnumerable<Album> FetchArtistSingles(int id)
        {
            return FetchAlbums(id, "EPSANDSINGLES").Items;
        }

        public IEnumerable<Album> FetchArtistAppearsOn(int id)
        {
            return FetchAlbums(id, "COMPILATIONS").Items;
        }

        public Album FetchAlbum(int id)
        {
            return FetchWimpData<Album>("albums", id);
        }

        public Tracklist FetchTracklist(int id)
        {
            const string apiMethod = "albums";
            string url = UriBase + apiMethod + "/" + id + "/tracks" + "?countryCode=" + CountryCode + "&token=" + _apiToken;
            return Fetcher.FetchJson<Tracklist>(url);
        }

        public Track FetchTrack(int id)
        {
            return FetchWimpData<Track>("tracks", id);
        }

        //public User FetchUser(string id)
        //{
        //    return FetchSpotifyData<User>("users", id);
        //}

        private static T FetchWimpData<T>(string apiMethod, int id)
        {
            string url = UriBase + apiMethod + "/" + id + "?countryCode=" + CountryCode + "&token=" + _apiToken;
            return Fetcher.FetchJson<T>(url);
        }

        private static ArtistAlbumCollection FetchAlbums(int id, string filter)
        {
            const string apiMethod = "artists";
            const int limit = 50;
            string url = UriBase + apiMethod + "/" + id + "/albums" + "?countryCode=" + CountryCode + "&token=" + _apiToken + "&limit=" + limit + "&filter=" + filter;
            return Fetcher.FetchJson<ArtistAlbumCollection>(url);
        }
    }
}