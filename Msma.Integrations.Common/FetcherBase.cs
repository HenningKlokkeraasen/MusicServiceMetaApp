using System.Net;
using System.Text;

namespace Msma.Integrations.Common
{
    public abstract class FetcherBase
    {
        protected static string HttpGetFromUri(string url)
        {
            var client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            var content = client.DownloadString(url);
            return content;
        }
    }
}
