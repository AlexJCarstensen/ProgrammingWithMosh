using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stopwatch!");
            Console.WriteLine("To start press 1 \nTo stop press 2\nTo end program press 3");
            var run = true;
            while (run)
            {
                var input = Console.ReadKey();
                Console.WriteLine();

                switch (input.KeyChar)
                {
                    case (char)49:
                        Stopwatch.Start();
                        break;
                    case (char)50:
                        Stopwatch.Stop();
                        break;
                    case (char)51:
                        run = false;
                        break;

                }

            }

        }
    }
}
