using System;

namespace AsynchAwait
{
    class MainClass
    {
        public static void Main()
        {
            var engine = new DownloadEngine();
            Console.WriteLine("Doing the first action, next i will download the page");

            //engine.DownloadHtml(@"https://www.thetimes.co.uk/");
            engine.DownloadHtmlAsync(@"https://www.thetimes.co.uk/");

            Console.WriteLine("The page has been downloaded!");

            Console.WriteLine("All done");
        }
    }
}
