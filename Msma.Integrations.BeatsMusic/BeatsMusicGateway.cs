﻿using System.Collections.Generic;
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
                new KeyValuePair<string, string>("refs", string.Empty),
                new KeyValuePair<string, string>("order_by", "release_date+desc"),
            };
            
            return FetchBeatsMusicData<GetAlbumsWrapper>("artists", artistId, "/albums", queryStringParameters).Albums;
        }

        public IEnumerable<Album> FetchEssentialAlbums(string artistId)
        {
            //var queryStringParameters = new List<KeyValuePair<string, string>>
            //{
            //    new KeyValuePair<string, string>("refs", string.Empty)
            //};

            return FetchBeatsMusicData<GetAlbumsWrapper>("artists", artistId, "/essential_albums").Albums;
        }

        public string FetchArtistImageUrl(string artistId)
        {
            return UriBase + "artists" + "/" + artistId + "/images/default" + "?client_id=" + _apiToken;
        }

        public Album FetchAlbum(string albumId)
        {
            var queryStringParameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("refs", "artists")//TODO add label
            };

            return FetchBeatsMusicData<GetAlbumWrapper>("albums", albumId, string.Empty, queryStringParameters).Album;
        }

        public string FetchAlbumImageUrl(string albumId)
        {
            return UriBase + "albums" + "/" + albumId + "/images/default" + "?client_id=" + _apiToken;
        }

        public IEnumerable<Track> FetchTracks(string albumId)
        {
            return FetchBeatsMusicData<GetTracksWrapper>("albums", albumId, "/tracks").Tracks;
        }

        public Track FetchTrack(string trackId)
        {
            return FetchBeatsMusicData<GetTrackWrapper>("tracks", trackId).Track;
        }

        private static T FetchBeatsMusicData<T>(string apiMethod, string id, string sub = "", IEnumerable<KeyValuePair<string, string>> queryStringParameters = null)
        {
            string url = UriBase + apiMethod + "/" + id + sub + "?client_id=" + _apiToken + QueryStringParameterHelper.FlattenQueryStringParameters(queryStringParameters);
            return Fetcher.FetchJson<T>(url);
        }
    }
}
