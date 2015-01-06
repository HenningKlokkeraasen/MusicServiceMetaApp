using System.Collections.Generic;
using Msma.Integrations.Common;
using Msma.Integrations.LastFm.Models;

namespace Msma.Integrations.LastFm
{
    public class LastFmGateway
    {
        private const string UriBase = "http://ws.audioscrobbler.com/2.0/";
        //private const string CountryCode = "NO";
        private static string _apiToken;

        private static readonly JsonFetcher Fetcher = new JsonFetcher();

        public LastFmGateway(string apiToken)
        {
            _apiToken = apiToken;
        }

        public Artist FetchArtist(string mbid)
        {
            return FetchLastFmData<GetArtistWrapper>("artist.getInfo", mbid).Artist;
        }

        public Artist FetchArtistByName(string name)
        {
            const string apiMethod = "artist.getInfo";
            string url = UriBase + "?method=" + apiMethod + "&artist=" + name + "&api_key=" + _apiToken + "&format=json";
            return Fetcher.FetchJson<GetArtistWrapper>(url).Artist;
        }

        public IEnumerable<AlbumInTopAlbums> FetchTopAlbums(string id)
        {
            return FetchLastFmData<GetTopAlbumsWrapper>("artist.getTopAlbums", id).TopAlbumsInnerWrapper.Albums;
        }

        public Album FetchAlbum(string mbid)
        {
            return FetchLastFmData<GetAlbumWrapper>("album.getInfo", mbid).Album;
        }
        
        public Track FetchTrack(string mbid)
        {
            return FetchLastFmData<GetTrackWrapper>("track.getInfo", mbid).Track;
        }

        private static T FetchLastFmData<T>(string apiMethod, string mbid)
        {
            string url = UriBase + "?method=" + apiMethod + "&mbid=" + mbid + "&api_key=" + _apiToken + "&format=json";
            return Fetcher.FetchJson<T>(url);
        }
    }
}
