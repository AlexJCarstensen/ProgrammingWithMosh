using System.Collections.Generic;

namespace Vidzy
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; private set; }

        public Tag()
        {
            Videos = new HashSet<Video>();
        }
    }
}