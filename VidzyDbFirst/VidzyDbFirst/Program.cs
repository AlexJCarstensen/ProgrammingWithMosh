using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace VidzyDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new VidzyDbContext();
            
            
            context.AddVideo("Hunger Games", DateTime.Now, "Action",  1);





        }
    }
}
