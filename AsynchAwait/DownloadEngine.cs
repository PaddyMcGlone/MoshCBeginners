using System.IO;
using System.Net;

namespace AsynchAwait
{
    public class DownloadEngine
    {
        public void DownloadHtml(string url)
        {
            var client = new WebClient();
            var html = client.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"/Users/patrickmcglone/Documents/html.txt"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
