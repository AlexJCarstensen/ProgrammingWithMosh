using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                DateTime = DateTime.Now,
                Description = "En sej app",
                Title = "Baby"
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine(post.Voting);

        }
    }
}
