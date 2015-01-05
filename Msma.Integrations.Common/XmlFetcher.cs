using System.IO;
using System.Xml.Serialization;

namespace Msma.Integrations.Common
{
    public class XmlFetcher : FetcherBase
    {
        public T FetchXml<T>(string url)
        {
            var content = HttpGetFromUri(url);
            T model = (T)new XmlSerializer(typeof(T)).Deserialize(new StringReader(content));
            return model;
        }
    }
}
