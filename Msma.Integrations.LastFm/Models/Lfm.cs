using System;
using System.Xml.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [Serializable]
    [XmlRoot("lfm")]
    public class Lfm
    {
        [XmlElement("artist")]
        public Artist Artist { get; set; }
    }
}
