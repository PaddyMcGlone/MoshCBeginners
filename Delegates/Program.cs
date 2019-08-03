using System;

namespace Delegates
{
        

    class MainClass
    {
        public static void Main(string[] args)
        {
            // A new photo
            var photo = new Photo();

            // A photo filter to apply
            var filters = new PhotoFilter();

            // Create an instance of our photo processor class
            var processor = new PhotoProcessor();

            // A new delegate
            PhotoProcessor.PhotoFilterHander handler = filters.GreyScale;
            processor.Process(photo, handler);
        }
    }
}
