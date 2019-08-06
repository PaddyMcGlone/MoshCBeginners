using System;
using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        public VideoEncoder()
        {
        }

        internal void Encode(Video video)
        {
            Console.WriteLine($"Writing video {video.Title}...");
            Thread.Sleep(3000);
        }
    }
}