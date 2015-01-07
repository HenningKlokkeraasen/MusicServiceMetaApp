using System.Collections.Generic;
using MusicServiceMetaApp.Web.ViewModels;

namespace MusicServiceMetaApp.Web.Data
{
    internal class WimpIndexData
    {
        internal static ServiceIndexViewModel GetViewModel()
        {
            return new ServiceIndexViewModel
            {
                Title = "WiMP",
                CssClass = "source-Wimp",
                AlbumLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Bauta - En hyllest til Bjørn Eidsvåg",
                        Action = "Album",
                        IdRouteAttribute = 27027486
                    }
                },
                ArtistLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Band of Horses",
                        Action = "Artist",
                        IdRouteAttribute = 63223
                    },
                    new ActionLinkData
                    {
                        Title = "Calexico",
                        Action = "Artist",
                        IdRouteAttribute =  9244
                    },
                    new ActionLinkData
                    {
                        Title = "Kaizers Orchestra",
                        Action = "Artist",
                        IdRouteAttribute = 20940
                    }
                }
            };
        }
    }
}