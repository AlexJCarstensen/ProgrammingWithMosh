namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidzy.VidzyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidzy.VidzyContext context)
        {
            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 1,
                Name = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24),
                Classification = Classification.Platinum,
                GenreId = 7
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 2,
                Name = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 9, 14),
                Classification = Classification.Gold,
                GenreId = 7
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 3,
                Name = "Schindler's List",
                ReleaseDate = new DateTime(1994, 2, 4),
                Classification = Classification.Gold,
                GenreId = 7
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 4,
                Name = "The Hangover",
                ReleaseDate = new DateTime(2009, 6, 11),
                Classification = Classification.Gold,
                GenreId = 1
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 5,
                Name = "Anchorman",
                ReleaseDate = new DateTime(2004, 4, 11),
                Classification = Classification.Silver,
                GenreId = 1
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 6,
                Name = "Die Hard",
                ReleaseDate = new DateTime(1988, 6, 13),
                Classification = Classification.Gold,
                GenreId = 2
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 7,
                Name = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 1, 5),
                Classification = Classification.Gold,
                GenreId = 2
            });

            context.Videos.AddOrUpdate(v => v.Id, new Video
            {
                Id = 8,
                Name = "Terminator 2: Judgment Day",
                ReleaseDate = new DateTime(1991, 5, 15),
                Classification = Classification.Platinum,
                GenreId = 2
            });
        }
    }
}
