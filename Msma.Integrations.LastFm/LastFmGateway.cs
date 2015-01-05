using Msma.Integrations.Common;
using Msma.Integrations.LastFm.Models;

namespace Msma.Integrations.LastFm
{
    public class LastFmGateway
    {
        private const string UriBase = "http://ws.audioscrobbler.com/2.0/";
        //private const string CountryCode = "NO";
        private static string _apiToken;

        private static readonly XmlFetcher Fetcher = new XmlFetcher();

        public LastFmGateway(string apiToken)
        {
            _apiToken = apiToken;
        }

        public Artist FetchArtist(string id)
        {
            return FetchLastFmData<Lfm>("artist.getInfo", id).Artist;
        }
        
        private static T FetchLastFmData<T>(string apiMethod, string id)
        {
            string url = UriBase + "?method=" + apiMethod + "&artist=" + id + "&api_key=" + _apiToken;
            return Fetcher.FetchXml<T>(url);
        }

    }
}
