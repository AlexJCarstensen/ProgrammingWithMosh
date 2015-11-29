using System;
using System.Linq;
namespace Queries
{
    class Program
    {
        private static void Main(string[] args)
        {
            var context = new PlutoContext();
            //LINQ syntax
            var query =
                from c in context.Courses
                where c.Name.Contains("C#")
                orderby c.Name
                select c;

            foreach (var course in query)
            {
                Console.WriteLine(course.Name);
            }

            //// Extension methods
            //var courses = context.Courses
            //    .Where(c => c.Name.Contains("C#"))
            //    .OrderBy(c => c.Name);

            //foreach (var cource in courses)
            //{
            //    Console.WriteLine(cource.Name);
            //}





        }
    }
}
