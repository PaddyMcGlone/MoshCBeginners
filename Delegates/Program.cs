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

            // Add another filter into our process
            handler += filters.AutoFilter;

            // Adding our new red eye reduction filter
            handler += ApplyRedEyeReduction; // Note the lack of Filters. prefix

            processor.Process(photo, handler);
        }

        // Some new filter which the dev has added
        static void ApplyRedEyeReduction(Photo photo)
        {
            Console.WriteLine("Applying Red Eye Reduction.");
        }
    }
}
