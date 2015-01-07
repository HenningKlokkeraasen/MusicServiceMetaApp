using System.Collections.Generic;

namespace MusicServiceMetaApp.Web.ViewModels
{
    public class ServiceIndexViewModel
    {
        public string Title { get; set; }
        public string CssClass { get; set; }

        public IEnumerable<ActionLinkData> AlbumLinks
        {
            get { return _albumLinks; }
            set { _albumLinks = value; }
        }

        public IEnumerable<ActionLinkData> ArtistLinks
        {
            get { return _artistLinks; }
            set { _artistLinks = value; }
        }

        public IEnumerable<ActionLinkData> UserLinks
        {
            get { return _userLinks; }
            set { _userLinks = value; }
        }

        private IEnumerable<ActionLinkData> _albumLinks = new List<ActionLinkData>();
        private IEnumerable<ActionLinkData> _artistLinks = new List<ActionLinkData>();
        private IEnumerable<ActionLinkData> _userLinks = new List<ActionLinkData>();
    }
}