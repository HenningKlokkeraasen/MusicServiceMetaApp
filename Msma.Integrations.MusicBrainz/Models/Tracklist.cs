using System.Collections.Generic;

namespace Msma.Integrations.MusicBrainz.Models
{
    public class Tracklist
    {
        public IEnumerable<Track> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private IEnumerable<Track> _items = new List<Track>();
    }
}