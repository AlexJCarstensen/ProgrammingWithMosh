using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Program1

            //var names = new List<string>();
            //while (true)
            //{
            //    Console.Write("Please enter a friend name: ");
            //    var name = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(name))
            //        break;

            //    names.Add(name);

            //    if (names.Count > 2)
            //    {
            //        Console.WriteLine(names.ElementAt(0) + ", " + names.ElementAt(1) + " and " + (names.Count - 2) + " others like your post.");
            //    }
            //    else
            //    {
            //        if (names.Count == 1 && names.Count < 2)
            //            Console.WriteLine($"{names.ElementAt(0)} likes your post.");
            //        else
            //        {
            //            Console.WriteLine($"{names.ElementAt(0)} and {names.ElementAt(1)} like your post.");
            //        }
            //    }
            //}
            #endregion

            #region Program2

            //Console.WriteLine("Please enter your name and let me do my magic!");
            //var input = Console.ReadLine();
            //var charArray = input.ToCharArray();


            //Array.Reverse(charArray);
            //// new string because of array.
            //var newString = new string(charArray);
            //Console.WriteLine(newString);

            #endregion

            #region Program3

            //Console.WriteLine("please enter five unique numbers and then I will sort them");
            //var myArray = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    var input = Console.ReadLine();
            //    if (myArray.Contains(int.Parse(input)))
            //    {
            //        Console.WriteLine($"You have already putted in {input}");
            //        i--;
            //        continue;
            //    }
            //    myArray[i] = int.Parse(input);
            //}

            //Array.Sort(myArray);
            //foreach (var i in myArray)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Program4
            //var myList = new List<int>();

            //Console.WriteLine("Input the numbers you like if you want to end write Quit");
            
            //while (true)
            //{
            //    Console.Write("Next number: ");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //        break;
            //    if (string.IsNullOrWhiteSpace(input))
            //        continue;

            //    myList.Add(int.Parse(input));
            //}

            //myList.Sort();

            //foreach (var source in myList.Distinct())
            //{
            //    Console.WriteLine(source);
            //}

            #endregion
            
            #region Program5

            Console.WriteLine("Please input 5 numbers separated by comma");

            var myList = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                var returnString = input.Split(Convert.ToChar(","));
                myList.AddRange(returnString.Select(int.Parse));
                
                if (myList.Count == 0 || myList.Count < 5)
                {
                    Console.WriteLine("Invalid list try again");
                    continue;
                }
                break;
            }

            myList.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myList.ElementAt(i).ToString());
            }





            #endregion
        }


       

    }
}

