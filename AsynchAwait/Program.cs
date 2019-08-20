using System;

namespace AsynchAwait
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var engine = new DownloadEngine();
            Console.WriteLine("Doing the first action, next i will download the page");
            engine.DownloadHtml(@"http://www.google.com");
            Console.WriteLine("The page has been downloaded!");
            Console.WriteLine("All done");
        }
    }
}
