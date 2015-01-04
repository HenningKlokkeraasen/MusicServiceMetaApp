using System.Runtime.Serialization;

namespace Msma.Integrations.Wimp.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Picture { get; set; }

        public string ImageUrl
        {
            get
            {
                return !string.IsNullOrEmpty(Picture)
                    ? "http://resources.wimpmusic.com/images/" + Picture.Replace('-', '/') + "/160x160.jpg"
                    : string.Empty;
            }
        }
    }
}