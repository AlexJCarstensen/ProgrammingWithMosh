using System.Data.Entity.ModelConfiguration;
using VidzyCodeFirst.Migrations;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class TagConfiguration :EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);
        } 
    }
}