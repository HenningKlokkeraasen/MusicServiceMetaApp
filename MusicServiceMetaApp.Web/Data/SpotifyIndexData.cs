using System.Collections.Generic;
using MusicServiceMetaApp.Web.ViewModels;

namespace MusicServiceMetaApp.Web.Data
{
    internal class SpotifyIndexData
    {
        internal static ServiceIndexViewModel GetViewModel()
        {
            return new ServiceIndexViewModel
            {
                Title = "Spotify",
                CssClass = "source-Spotify",
                AlbumLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Bauta - En hyllest til Bjørn Eidsvåg",
                        Action = "Album",
                        IdRouteAttribute = "1cj2bGhHCxMdx3wNr9u5OF"
                    }
                },
                ArtistLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Band of Horses",
                        Action = "Artist",
                        IdRouteAttribute = "0OdUWJ0sBjDrqHygGUXeCF"
                    },
                    new ActionLinkData
                    {
                        Title = "Calexico",
                        Action = "Artist",
                        IdRouteAttribute = "1OmdWpAh1pucAuZPzJaxIJ"
                    },
                    new ActionLinkData
                    {
                        Title = "Kaizers Orchestra",
                        Action = "Artist",
                        IdRouteAttribute = "1s1DnVoBDfp3jxjjew8cBR" 
                    }
                },
                UserLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Wizzler",
                        Action = "User",
                        IdRouteAttribute = "wizzler"
                    }
                },
            };
        }
    }
}