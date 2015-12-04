using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Program1

            //Console.WriteLine("Please enter a number between 1 and 10");
            //var userInput = Console.ReadLine();
            //if (int.Parse(userInput) > 0 && int.Parse(userInput) < 11)
            //    Console.WriteLine("Valid");
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region Program2

            //Console.WriteLine("Please enter two numbers");
            //var userInput1 = Console.ReadLine();
            //var userInput2 = Console.ReadLine();

            //if (int.Parse(userInput2) > int.Parse(userInput1))
            //{
            //    Console.WriteLine("{0} is bigger that {1}", userInput2, userInput1);
            //}
            //else
            //{
            //    Console.WriteLine("{1} is bigger that {0}", userInput2, userInput1);

            //}
            #endregion

            #region Program3

            //Console.WriteLine("please enter height and then width");
            //var height = Console.ReadLine();
            //var width = Console.ReadLine();

            //if (int.Parse(height) > int.Parse(width))
            //{
            //    Console.WriteLine("It's a Portrait");
            //}
            //else
            //{
            //    Console.WriteLine("It's a Landscape");

            //}

            #endregion

            #region Program4

            Console.WriteLine("Enter speedlimit");
            var speedLimit = Console.ReadLine();

            Console.WriteLine("Speed of car?");
            var carSpeed = Console.ReadLine();

            if(int.Parse(carSpeed) > int.Parse(speedLimit))
            {
               var result = CalculateDemerit(int.Parse(carSpeed), int.Parse(speedLimit));
                if(result < 12)
                    Console.WriteLine(result);
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
            else
            {
                Console.WriteLine("Ok");
            }
             

           
        }

        private static int CalculateDemerit(int carSpeed, int speedLimit)
        {
            var result = 0;
            for (int i = speedLimit; i < carSpeed; i+=5)
            {
                result++;
            }
            return result;
        } 
            #endregion
    }
}
