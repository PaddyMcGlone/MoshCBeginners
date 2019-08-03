using System;

namespace Delegates
{
    public class PhotoFilter
    {
        public void GreyScale(Photo photo)
        {
            Console.WriteLine("Applying Grayscale");
        }

        public void AutoFilter(Photo photo)
        {
            Console.WriteLine("Applying Auto filter");
        }
    }
}
