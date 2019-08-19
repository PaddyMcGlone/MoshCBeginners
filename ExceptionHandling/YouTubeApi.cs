using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {        
        public List<string> GetUserVideos()
        {
            try
            {
                // Do some work here...

                throw new Exception("500 server error");
            }
            catch (System.Exception ex)
            {
                throw new YouTubeException("There has been a problem retrieving videos", ex);
            }
            
            return new List<string>();
        }
    }
}