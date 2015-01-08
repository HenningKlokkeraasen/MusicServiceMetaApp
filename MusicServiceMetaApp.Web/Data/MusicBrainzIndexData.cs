using System.Collections.Generic;
using MusicServiceMetaApp.Web.ViewModels;

namespace MusicServiceMetaApp.Web.Data
{
    internal class MusicBrainzIndexData
    {
        internal static ServiceIndexViewModel GetViewModel()
        {
            return new ServiceIndexViewModel
            {
                Title = "MusicBrainz",
                CssClass = "source-MusicBrainz",
                AlbumLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Bauta: En hyllest til Bjørn Eidsvåg",
                        Action = "Album",
                        IdRouteAttribute = "a02f23b5-486b-4499-afff-eb260b1d63a0"
                    }
                },
                ArtistLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Band of Horses",
                        Action = "Artist",
                        IdRouteAttribute = "07b6020a-c539-4d68-aeef-f159f3befc76"
                    },
                    new ActionLinkData
                    {
                        Title = "Calexico",
                        Action = "Artist",
                        IdRouteAttribute =  "5e372a49-5672-4fb8-ba14-18c90780c4f9"
                    },
                    new ActionLinkData
                    {
                        Title = "Kaizers Orchestra",
                        Action = "Artist",
                        IdRouteAttribute = "2c3bac0a-5158-442f-b50b-056aae52138c"
                    }
                }
            };
        }
    }
}