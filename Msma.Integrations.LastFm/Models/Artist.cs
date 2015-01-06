using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember(Name = "mbid")]
        public string MusicBrainzId { get; set; }

        [DataMember(Name = "image")]
        public IEnumerable<Image> Images { get; set; }

        [DataMember]
        public ArtistBio Bio { get; set; }

        public string Id
        {
            get { return LastFmIdHelper.ConvertNameToId(Name); }
        }

        public string ImageUrl
        {
            get
            {
                if (Images == null || !Images.Any())
                    return string.Empty;
                var extraLargeImage = Images.FirstOrDefault(i => i.Size == "extralarge");
                if (extraLargeImage != null)
                    return extraLargeImage.Url;
                var largeImage = Images.FirstOrDefault(i => i.Size == "large");
                return largeImage != null
                    ? largeImage.Url
                    : string.Empty;
            }
        }
    }
}
