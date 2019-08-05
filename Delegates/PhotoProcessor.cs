using System;

namespace Delegates
{    
    public class PhotoProcessor
    {
        // This below is a custom delegate
        // Creating a delegate, which will hold the pointer address
        // of all the methods that we wish to call.
        // public delegate void PhotoFilterHander(Photo photo);

        // Below we pass the delegate into our method as a param.
        public void Process(Photo photo, Action<Photo> photoFilterHander)
        {
            var filter = new PhotoFilter();
            photoFilterHander(photo); // Call the delegate with the photo.

            // Above the delegate is now incharge of handling all the photo filters to be applied.
        }
    }
}
