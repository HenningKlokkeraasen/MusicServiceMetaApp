using System.Collections.Generic;
using Msma.Integrations.BeatsMusic.Models;
using Msma.Integrations.Common;

namespace Msma.Integrations.BeatsMusic
{
    public class BeatsMusicGateway
    {
        private const string UriBase = "https://partner.api.beatsmusic.com/v1/api/";
        
        private static string _apiToken;

        private static readonly JsonFetcher Fetcher = new JsonFetcher();

        public BeatsMusicGateway(string apiToken)
        {
            _apiToken = apiToken;
        }

        public Artist FetchArtist(string id)
        {
            return FetchBeatsMusicData<GetArtistWrapper>("artists", id).Artist;
        }

        public IEnumerable<Album> FetchAlbums(string artistId)
        {
            var queryStringParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("refs", string.Empty)
            };

            return FetchBeatsMusicData<GetAlbumsWrapper>("artists", artistId, "/albums", queryStringParameters).Albums;
        }

        public string FetchArtistImageUrl(string artistId)
        {
            return UriBase + "artists" + "/" + artistId + "/images/default" + "?client_id=" + _apiToken;
        }

        public Album FetchAlbum(string albumId)
        {
            return FetchBeatsMusicData<GetAlbumWrapper>("albums", albumId).Album;
        }

        private static T FetchBeatsMusicData<T>(string apiMethod, string id, string sub = "", IEnumerable<KeyValuePair<string, string>> queryStringParameters = null)
        {
            string url = UriBase + apiMethod + "/" + id + sub + "?client_id=" + _apiToken + QueryStringParameterHelper.FlattenQueryStringParameters(queryStringParameters);
            return Fetcher.FetchJson<T>(url);
        }
    }
}
