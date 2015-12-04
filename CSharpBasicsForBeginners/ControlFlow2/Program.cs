using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ControlFlow2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Program1

            //var count = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%3 == 0)
            //        count++;
            //}
            //Console.WriteLine(count);

            #endregion

            #region Program2

            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number");
            //    Console.WriteLine("If you want to exit enter ok");
            //    var input = Console.ReadLine();

            //    if (input == "ok")
            //        break;

            //    sum += int.Parse(input);
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Program3

            //    Console.WriteLine("Please enter a number");
            //    var number = Console.ReadLine();
            //    var result = Factorial(int.Parse(number));
            //    Console.WriteLine(number + "! = " + result);



            //}

            //static int Factorial(int number)
            //{

            //    if (number <= 1)
            //    {
            //        number *= 1;
            //    }
            //    else
            //    {
            //        number *= Factorial(number - 1);
            //    }

            //    return number;
            #endregion

            #region Program4

            //var random = new Random();
            //const int numberOfGuesses = 4;

            //var rdn = random.Next(1, 10);
            //Console.WriteLine($"lucky number is {rdn}");

            //Console.WriteLine("Welcome to guess the number! The number is between 1 and 10, you have 4 guesses");
            //for (int i = numberOfGuesses; i > 0; i--)
            //{
            //    Console.WriteLine("ou have {0} guesses left", i);
            //    var guess = Console.ReadLine();

            //    if (int.Parse(guess) == rdn)
            //    {
            //        Console.WriteLine("You guessed it!");
            //        break;
            //    }
            //    if (i == 1)
            //    {
            //        Console.WriteLine("You lost");
            //    }

            //}


            #endregion

            #region Program5

            Console.WriteLine("Please enter a series of numbers separated by commas");
            var input = Console.ReadLine();
            var test = input.Split(Convert.ToChar(","));
            var max = test.AsEnumerable().Max();
            Console.WriteLine(max);

            #endregion
        }

    }
}
