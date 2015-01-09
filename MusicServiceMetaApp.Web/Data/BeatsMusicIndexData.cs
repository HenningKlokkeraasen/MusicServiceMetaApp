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
                //AlbumLinks = new List<ActionLinkData>
                //{
                //    new ActionLinkData
                //    {
                //        Title = "Bauta: En hyllest til Bjørn Eidsvåg",
                //        Action = "Album",
                //        IdRouteAttribute = "Various+Artists|Bauta:+En+hyllest+til+Bjørn+Eidsvåg"
                //    }
                //},
                ArtistLinks = new List<ActionLinkData>
                {
                    new ActionLinkData
                    {
                        Title = "Band of Horses",
                        Action = "Artist",
                        IdRouteAttribute = "ar273771"
                    },
                    //new ActionLinkData
                    //{
                    //    Title = "Calexico",
                    //    Action = "Artist",
                    //    IdRouteAttribute =  "Calexico"
                    //},
                    //new ActionLinkData
                    //{
                    //    Title = "Kaizers Orchestra",
                    //    Action = "Artist",
                    //    IdRouteAttribute = "Kaizers+Orchestra"
                    //}
                }
            };
        }
    }
}