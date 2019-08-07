using System;
using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        // Steps: 
        // 1. Define a delegate
        // 2. Define an event
        // 3. Raise the event


        // 1. Delegate
        // object Source = The source which is raising the event
        // EventArgs = Any additional data which we want to send with the event (Or additional custom class)
        //public delegate void VideoEnocderEventHandler(object source, VideoArgs args);


        // 2. Event
        //public event VideoEnocderEventHandler VideoEncoded;
        public EventHandler<VideoArgs> VideoEncoded; // Using handler, removing the need for a custom delegate.

        // 3. Raise the event via a method
        // Convention states they should be marked as protected, virtual and named with 'on'
        protected virtual void OnVideoEncoded(Video video)
        {
            // We check if the video encoded has subscribers
            if (VideoEncoded != null)            
                VideoEncoded(this, new VideoArgs { video = video }); // Create the event, passing empty args            
        }

        internal void Encode(Video video)
        {
            Console.WriteLine($"Writing video {video.Title}...");
            Thread.Sleep(3000);

            // This will alert of the subscribers that the event has occured.
            OnVideoEncoded(video);
        }
    }
}