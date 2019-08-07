using System;
using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event
        // 3. Raise the event

        public VideoEncoder()
        {
        }

        // 1. Delegate
        // object Source = The source which is raising the event
        // EventArgs = Any additional data which we want to send with the event 
        public delegate void VideoEnocderEventHandler(object source, EventArgs args);

        // 2. Event
        public event VideoEnocderEventHandler VideoEncoded;

        // 3. Raise the event via a method
        // Convention states they should be marked as protected, virtual and named with 'on'
        protected virtual void OnVideoEncoded()
        {
            // We check if the video encoded has subscribers
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty); // Create the event, passing empty args
        }

        internal void Encode(Video video)
        {
            Console.WriteLine($"Writing video {video.Title}...");
            Thread.Sleep(3000);

            // This will alert of the subscribers that the event has occured.
            OnVideoEncoded();
        }
    }
}