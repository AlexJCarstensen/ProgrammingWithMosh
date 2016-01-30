using System;

namespace Post
{
    public class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime timeCreated { get; set; }
        private int Voting { get; set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Voting = 0;
            timeCreated = DateTime.Now;
        }
        public void UpVote()
        {
            Voting++;
        }
        public void DownVote()
        {
            Voting--;
        }

        public void DisplayPost()
        {
            Console.WriteLine($"Title: {Title}\n" +
                              $"Description: {Description}\n" +
                              $"Votes: {Voting}"); 
        }
    }
}