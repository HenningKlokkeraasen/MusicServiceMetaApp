using System;
using System.Xml.Serialization;

namespace Msma.Integrations.LastFm.Models
{
    [Serializable]
    public class Artist
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
