using System.Collections.Generic;
using MusicServiceMetaApp.Web.ViewModels;

namespace MusicServiceMetaApp.Web.Data
{
    internal class BeatsMusicIndexData
    {
        internal static ServiceIndexViewModel GetViewModel()
        {
            return new ServiceIndexViewModel
            {
                Title = "Beats Music",
                CssClass = "source-BeatsMusic",
                AlbumLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "A Very Special Christmas",
                        Action = "Album",
                        IdRouteAttribute = "al19690449"
                    }
                },
                ArtistLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Band of Horses",
                        Action = "Artist",
                        IdRouteAttribute = "ar273771"
                    },
                    new ActionLinkData
                    {
                        Title = "Calexico",
                        Action = "Artist",
                        IdRouteAttribute =  "ar163212"
                    },
                    new ActionLinkData
                    {
                        Title = "Kaizers Orchestra",
                        Action = "Artist",
                        IdRouteAttribute = "ar304256"
                    }
                }
            };
        }
    }
}