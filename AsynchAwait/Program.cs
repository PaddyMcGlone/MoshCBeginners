using System;

namespace AsynchAwait
{
    class MainClass
    {
        public async static void Main()
        {
            var engine = new DownloadEngine();
            Console.WriteLine("Doing the first action, next i will download the page");

            //engine.DownloadHtml(@"https://www.thetimes.co.uk/");
            //engine.DownloadHtmlAsync(@"https://www.thetimes.co.uk/");

            var html = await engine.GetHtml("http://msdn.microsoft.com");

            Console.WriteLine(html.Substring(0,10));

            Console.WriteLine("The page has been downloaded!");

            Console.WriteLine("All done");
        }
    }
}
