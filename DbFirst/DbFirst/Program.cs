using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbFirst
{
    class Program
    {
        public enum Leveler : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }
        static void Main(string[] args)
        {   
            // First part

            //var dbContext = new PlutoDbContext();

            //var courses = dbContext.GetCourses();
            //foreach (var c in courses)
            //{
            //    Console.WriteLine(c.Title);
            //}

            // second part

            var course = new Course();
            course.Level = CourseLevel.Beginner;
        }
    }
}
