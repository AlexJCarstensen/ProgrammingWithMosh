using System;
using System.Collections.Generic;

namespace VidzyCodeFirst
{
    public class Video
    {
        public Video()
        {
            
        }
        public int Id { get; set; }
        public string Name  { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification  { get; set; }
        
    }
}