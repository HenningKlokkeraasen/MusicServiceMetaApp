using System.Collections.Generic;
using System.Text;
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

        //public Artist FetchArtist(string mbid)
        //{
        //    return FetchLastFmData<GetArtistWrapper>("artist.getInfo", mbid).Artist;
        //}

        public Artist FetchArtist(string artistName)
        {
            var identificationParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("artist", artistName)
            };
            return FetchLastFmData<GetArtistWrapper>("artist.getInfo", identificationParameters).Artist;
        }

        public IEnumerable<AlbumInTopAlbums> FetchTopAlbums(string artistName)
        {
            var identificationParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("artist", artistName)
            };
            return FetchLastFmData<GetTopAlbumsWrapper>("artist.getTopAlbums", identificationParameters).TopAlbumsInnerWrapper.Albums;
        }

        public Album FetchAlbum(string albumName, string artistName)
        {
            var identificationParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("album", albumName),
                new KeyValuePair<string, string>("artist", artistName)
            };
            return FetchLastFmData<GetAlbumWrapper>("album.getInfo", identificationParameters).Album;
        }

        public Track FetchTrack(string trackName, string artistName)
        {
            var identificationParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("track", trackName),
                new KeyValuePair<string, string>("artist", artistName)
            };
            return FetchLastFmData<GetTrackWrapper>("track.getInfo", identificationParameters).Track;
        }

        private static T FetchLastFmData<T>(string apiMethod, IEnumerable<KeyValuePair<string, string>> identificationParameters)
        {
            string url = UriBase + "?method=" + apiMethod + FlattenIdentificationParameters(identificationParameters) + "&api_key=" + _apiToken + "&format=json";
            return Fetcher.FetchJson<T>(url);
        }

        private static string FlattenIdentificationParameters(IEnumerable<KeyValuePair<string, string>> identificationParameters)
        {
            var sb = new StringBuilder();
            foreach (var x in identificationParameters)
            {
                sb.Append("&" + x.Key + "=" + x.Value);
            }
            return sb.ToString();
        }
    }
}
