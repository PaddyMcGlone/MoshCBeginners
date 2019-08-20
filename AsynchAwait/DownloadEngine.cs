using System.IO;
using System.Net;
using System.Threading;

namespace AsynchAwait
{
    public class DownloadEngine
    {
        public void DownloadHtml(string url)
        {
            var client = new WebClient();
            var html = client.DownloadString(url);

            Thread.Sleep(5000);

            using (var streamWriter = new StreamWriter(@"/Users/patrickmcglone/Documents/html.txt"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
