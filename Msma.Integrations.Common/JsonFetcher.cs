using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Msma.Integrations.Common
{
    public class JsonFetcher
    {
        public T FetchJson<T>(string url)
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string content = client.DownloadString(url);
            T model = JsonConvert.DeserializeObject<T>(content);
            return model;
        }
    }
}