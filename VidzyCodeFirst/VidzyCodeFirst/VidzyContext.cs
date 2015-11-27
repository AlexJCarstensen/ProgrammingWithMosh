using System.Data.Entity;

namespace VidzyCodeFirst
{
    public partial class VidzyContext : DbContext
    {
        public VidzyContext()
            : base("name=VidzyConnection")
        {
            
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Video> Videos  { get; set; }
    }
}