using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Program1

            var names = new List<string>();
            while (true)
            {
                Console.Write("Please enter a friend name: ");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                   break;

                names.Add(name);
            }

            #endregion
        }
    }
}
