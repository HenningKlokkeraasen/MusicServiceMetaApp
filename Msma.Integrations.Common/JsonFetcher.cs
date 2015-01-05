using Newtonsoft.Json;


namespace Msma.Integrations.Common
{
    public class JsonFetcher : FetcherBase
    {
        public T FetchJson<T>(string url)
        {
            var content = HttpGetFromUri(url);
            T model = JsonConvert.DeserializeObject<T>(content);
            return model;
        }
    }
}