using System.Collections.Generic;

namespace VidzyCodeFirst
{
    public class Genre
    {
        public Genre()
        {
            Videos = new HashSet<Video>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Video> Videos;
    }
}