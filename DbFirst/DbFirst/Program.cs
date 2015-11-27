using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }
        }
    }
}
