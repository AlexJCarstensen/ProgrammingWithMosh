using System;
using System.Linq;
using System.Linq.Expressions;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            // Action Movies sorted by name

            var actionVideos = context.Videos
                .Where(v=> v.Genre.Name == "Action")
                .OrderBy(v => v.Name)
                .Select(v => v.Name );

            foreach (var video in actionVideos)
            {
                Console.WriteLine(video);
            }
            Console.WriteLine();

            //Gold Drama Movies sorted by Releasedate 
            var goldMovies = context.Videos
                .Where(v => v.Classification == Classification.Gold)
                .Where(v => v.Genre.Name == "Drama")
                .OrderBy(v => v.ReleaseDate)
                .Select(v => v.Name);
            foreach (var video in goldMovies)
            {
                Console.WriteLine(video);
            }
            Console.WriteLine();

            //All Movies Genre and Name in anonymous type
            var allMovies = context.Videos
                .Select(v => new
                {
                    NameIs = v.Name,
                    TheGenre = v.Genre.Name
                });

            foreach (var allMovie in allMovies)
            {
                Console.WriteLine(allMovie);
            }
            Console.WriteLine();

            //All movies grouped by classification
            var groupedMovies = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key.ToString(),
                    Videos = g.OrderBy(v => v.Classification)
                });

            foreach (var groupedMovie in groupedMovies)
            {
                Console.WriteLine("Classification: {0}",groupedMovie.Classification);
                foreach (var video in groupedMovie.Videos)
                {
                    Console.WriteLine("\t" + video.Name);
                }
            }
            Console.WriteLine();

            // List of classifications sorted alpha and count of videos
            var classifications = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Name = g.Key.ToString(),
                    Count = g.Count()
                })
                .OrderBy(g => g.Name);
            foreach (var classification in classifications)
            {
                Console.WriteLine("{0} ({1})", classification.Name, classification.Count);
            }
            Console.WriteLine();
            // List of genres and number of videos they include, sorted by the number of videos

            var genresAndNumberVideos = context.Genres
                .GroupJoin(context.Videos, g => g.Id, v => v.GenreId, (genre, videos)
                 => new
                {
                    Name = genre.Name,
                    Count = videos.Count()
                })
                .OrderByDescending(g => g.Count);

            foreach (var numberVideo in genresAndNumberVideos)
            {
                Console.WriteLine("{0} ({1})", numberVideo.Name, numberVideo.Count);
            }
        }
    }
}
