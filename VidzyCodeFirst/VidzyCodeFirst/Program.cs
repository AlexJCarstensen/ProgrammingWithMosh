using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VidzyCodeFirst.Migrations;

namespace VidzyCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           VidzyContext vidzyContext = new VidzyContext();
            var tags = new List<Tag>();

            Video video = new Video
            {
                Classification = Classification.Gold,
                Genre = new Genre {Name = "Action"},
                Name = "golsden eye",
                ReleaseDate = DateTime.Now,
            };
            vidzyContext.Videos.Add(video);
            vidzyContext.SaveChanges();
        }
    }
}
