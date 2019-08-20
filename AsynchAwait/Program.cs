using System;

namespace AsynchAwait
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var engine = new DownloadEngine();
            engine.DownloadHtml(@"http://www.google.com");
        }
    }
}
