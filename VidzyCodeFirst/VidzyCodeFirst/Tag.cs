using System.Collections.Generic;

namespace VidzyCodeFirst.Migrations
{
    public class Tag
    {
        public Tag()
        {
            Videos = new HashSet<Video>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}