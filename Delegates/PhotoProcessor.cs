namespace Delegates
{
    // Creating a delegate, which will hold the pointer address
    // of all the methods that we wish to call.
    public delegate void PhotoFilterHander(Photo photo);

    public class PhotoProcessor
    {
        // Below we pass the delegate into our method as a param.
        public void Process(Photo photo, PhotoFilterHander photoFilterHander)
        {
            var filter = new PhotoFilter();
            photoFilterHander(photo); // Call the delegate with the photo.

            // Above the delegate is now incharge of handling all the photo filters to be applied.
        }
    }
}
