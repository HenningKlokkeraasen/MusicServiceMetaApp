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
                CssClass = "source-MusicBrainz"
            };
        }
    }
}