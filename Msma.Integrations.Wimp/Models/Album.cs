using System.Runtime.Serialization;

namespace Msma.Integrations.Wimp.Models
{
    [DataContract]
    public class Album
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember]
        public string ReleaseDate { get; set; }

        [DataMember]
        public Artist Artist { get; set; }

        [DataMember]
        public string Cover { get; set; }

        public string ImageUrl
        {
            get
            {
                return !string.IsNullOrEmpty(Cover)
                    ? "http://resources.wimpmusic.com/images/" + Cover.Replace('-', '/') + "/160x160.jpg"
                    : string.Empty;
            }
        }
    }
}