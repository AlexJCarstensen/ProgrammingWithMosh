
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Vidzy
{
    class Program
    {

        public static void AddVideo(Video video )
        {
            using (var context = new VidzyContext())
            {
                context.Videos.Add(video);
                context.SaveChanges();
            }
        }

        public static void AddTag(params string [] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();
                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.CurrentCultureIgnoreCase)))
                        context.Tags.Add(new Tag {Name = tagName });
                }
                context.SaveChanges();
            }
        }

        public static void AddTagToVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        tags.Add(new Tag {Name = tagName});
                    }
                    var video = context.Videos.Single(v => v.Id == videoId);
                    tags.ForEach(t => video.AddTag(t));
                    context.SaveChanges();
                }
            }
        }

        public static void RemoveTagFromVideo(int videoId, params string [] tagNames)
        {
            using (var context = new VidzyContext())
            {
                context.Tags.Where(t => tagNames.Contains(t.Name)).Load();

                var video = context.Videos.Single(v => v.Id == videoId);
                foreach (var tagName in tagNames)
                {
                    video.RemoveTag(tagName);
                }
                context.SaveChanges();
            }
        }

        public static void RemoveVideo(int videoId)
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.SingleOrDefault(v => v.Id == videoId);
                if (video == null) return;

                context.Videos.Remove(video);
                context.SaveChanges();
            }
        }

        public static void RemoveGenre(int genreId, bool enforceDeletingVideos )
        {
            using (var context = new VidzyContext())
            {
                var genre = context.Genres.Include(g => g.Videos).SingleOrDefault(g => g.Id == genreId);
                if (genre == null) return;

                if (enforceDeletingVideos)
                    context.Videos.RemoveRange(genre.Videos);
                context.Genres.Remove(genre);
                context.SaveChanges();

            }
        }
        static void Main(string[] args)
        {
           

            AddVideo(new Video
            {
                Classification = Classification.Silver,
                GenreId = 2,
                Name = "Terminator 1",
                ReleaseDate = new DateTime(1984,10,26)
            });

            AddTag("classics", "drama");

            AddTagToVideo(1, "classics", "drama", "comedy");

            RemoveTagFromVideo(1, "comedy");

            RemoveGenre(2, true);
        }
    }
}
