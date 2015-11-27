using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VidzyDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();
            dbContext.AddVideo("Mission Impossible", new DateTime(1985, 7, 15), "Action");
            dbContext.AddVideo("Titanic", DateTime.Now, "Romance");

        }
    }
}
