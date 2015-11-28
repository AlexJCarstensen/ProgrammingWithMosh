using System;
using System.Collections.Generic;
using VidzyCodeFirst.Migrations;

namespace VidzyCodeFirst
{
    public class Video
    {
        public Video()
        {
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Name  { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Classification Classification { get; set; }

        public byte GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Tag> Tags { get; set; }
        
    }
}