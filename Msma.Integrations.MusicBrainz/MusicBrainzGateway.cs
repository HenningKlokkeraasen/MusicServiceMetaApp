using System.Collections.Generic;
using Msma.Integrations.Common;
using Msma.Integrations.MusicBrainz.Models;

namespace Msma.Integrations.MusicBrainz
{
    public class MusicBrainzGateway
    {
        private const string UriBase = "http://musicbrainz.org/ws/2/";
        private const string CountryCode = "NO";


        private static readonly JsonFetcher Fetcher = new JsonFetcher();

        public Artist FetchArtist(string mbid)
        {
            //var entitiesToInclude = new List<KeyValuePair<string, string>>
            //{
            //    new KeyValuePair<string, string>("inc", "releases+media")
            //};

            var artist = FetchMusicBrainzData<Artist>("artist", mbid, null);
            EnsureNotNulls(ref artist);
            return artist;
        }

        private static T FetchMusicBrainzData<T>(string apiMethod, string mbid, IEnumerable<KeyValuePair<string, string>> entitiesToInclude)
        {
            var flattenedEntitiesToInclude = QueryStringParameterHelper.FlattenQueryStringParameters(entitiesToInclude, true);
            var formatSeparator = string.IsNullOrEmpty(flattenedEntitiesToInclude)
                ? '?'
                : '&';

            string url = UriBase + apiMethod + "/" + mbid + flattenedEntitiesToInclude + formatSeparator + "fmt=json";
            return Fetcher.FetchJson<T>(url);
        }

        private static void EnsureNotNulls(ref Artist artist)
        {
            if (artist.BeginArea == null)
                artist.BeginArea = new Area();
            if (artist.LifeSpan == null)
                artist.LifeSpan = new LifeSpan();
        }
    }
}
