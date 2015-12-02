using System.Data.Entity;
using System;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();
            var videos = context.Videos.ToList();

            //Console.WriteLine("LAZY LOADING");
            //foreach (var video in videos)
            //{
            //    Console.WriteLine($"VideoName: {video.Name}, Genre is: {video.Genre.Name}");
            //}

            //var videosWithGenres = context.Videos.Include(v => v.Genre).ToList();
            //Console.WriteLine();
            //Console.WriteLine("Eager loading");
            //foreach (var videosWithGenre in videosWithGenres)
            //{
            //    Console.WriteLine($"VideoName: {videosWithGenre.Name}, Genre is: {videosWithGenre.Genre.Name}");
            //}


            context.Genres.Load();
            Console.WriteLine();
            Console.WriteLine("Explicit loading");
            foreach (var video in videos)
            {
                Console.WriteLine($"VideoName: {video.Name}, Genre is: {video.Genre.Name}");
            }
        }
    }
}
