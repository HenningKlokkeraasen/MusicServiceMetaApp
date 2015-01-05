using System;
using System.Collections.Generic;

namespace Msma.Domain.Models
{
    public class Track
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int TrackNumber { get; set; }

        public int DurationInSeconds { get; set; }

        public IEnumerable<Artist> Artists { get; set; }

        public string PreviewUrl { get; set; }

        public Album Album { get; set; }

        public string DurationFormatted
        {
            get
            {
                TimeSpan t = TimeSpan.FromSeconds(DurationInSeconds);
                return string.Format("{0:D1}:{1:D2}",
                    t.Minutes,
                    t.Seconds);
            }
        }
    }
}