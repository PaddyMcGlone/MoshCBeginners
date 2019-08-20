using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

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

        public async Task DownloadHtmlAsync(string url)
        {
            var client = new WebClient();
            // Await keyword inform the compilier of costly task and return execution.
            var html = await client.DownloadStringTaskAsync(url);            

            using (var streamWriter = new StreamWriter(@"/Users/patrickmcglone/Documents/html.txt"))
            {
                // Nearly all methods have an Aysnch alternative.
                await streamWriter.WriteAsync(html);
            }
        }
    }
}
