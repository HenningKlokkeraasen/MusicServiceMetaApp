using System.Runtime.Serialization;

namespace Msma.Integrations.Wimp.Models
{
    [DataContract]
    public class Track
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Name { get; set; }

        [DataMember]
        public int TrackNumber { get; set; }

        [DataMember]
        public int Duration { get; set; }

        [DataMember]
        public Artist Artist { get; set; }

        [DataMember]
        public Album Album { get; set; }

        public int DurationInSeconds
        {
            get { return Duration; }
        }

        public string PreviewUrl
        {
            get { return "http://wdc.aspiro.com/dc/pser/" + Id + "/12/NO"; }
        }
    }
}