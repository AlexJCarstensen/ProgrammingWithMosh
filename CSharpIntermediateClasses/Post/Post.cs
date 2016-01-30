using System;

namespace Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        public int Voting { get; private set; }

        public void UpVote()
        {
            Voting++;
        }
        public void DownVote()
        {
            Voting--;
        }
    }
}