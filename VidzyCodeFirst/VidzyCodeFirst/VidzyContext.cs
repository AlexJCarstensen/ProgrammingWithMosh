using System.Data.Entity;
using VidzyCodeFirst.EntityConfigurations;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}