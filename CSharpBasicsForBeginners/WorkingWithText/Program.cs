using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Program1

            //Console.WriteLine("Please input a few numbers seperated by a hyphen.");
            //var input = Console.ReadLine();

            //var numbers = new List<int>();

            //foreach (var number in input.Split('-'))
            //{
            //    numbers.Add(Convert.ToInt32(number));
            //}

            //var consecutive = true;
            //for (int i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1 && numbers[i] != numbers[i - 1] - 1)
            //    {
            //        consecutive = false;
            //        break;
            //    }
            //}

            //var message = consecutive ? "Consecutive" : "Not Consecutive";
            //Console.WriteLine(message);


            #endregion

            #region Program2

            //Console.WriteLine("Please input a few numbers seperated by a hyphen.");
            //var input = Console.ReadLine();
            //if (string.IsNullOrWhiteSpace(input)) return;

            //var numbers = new List<int>();

            //foreach (var number in input.Split('-'))
            //{
            //    numbers.Add(Convert.ToInt32(number));
            //}

            //var uniqueNumbers = new List<int>();
            //var dublicates = false;

            //foreach (var number in numbers)
            //{
            //    if(!uniqueNumbers.Contains(number))
            //        uniqueNumbers.Add(number);
            //    else
            //    {
            //        dublicates = true;
            //        break;
            //    }
            //}
            //if(dublicates)
            //    Console.WriteLine("Duplicate");

            #endregion

            #region Program3

            //Console.WriteLine("please input a 24-hour format time");
            //var input = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //var time = input.Split(':');
            //if (time.Length != 2)
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //try
            //{
            //    var hour = Convert.ToInt32(time[0]);
            //    var minute = Convert.ToInt32(time[1]);

            //    if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            //        Console.WriteLine("OK");
            //    else
            //        Console.WriteLine("Invalid Time");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");

            //}

            #endregion

            #region Program4

            //Console.WriteLine("enter words");
            //var input = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("No input");
            //    return;
            //}

            //var variableName = "";
            //foreach (var word in input.Split(' '))
            //{
            //    var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    variableName += wordWithPascalCase;
            //}

            //Console.WriteLine(variableName);
            #endregion

            #region Program5

            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine();

            var vowels = new List<char>(new[] {'a','e','o','u','i'});
            var vowelsCount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            Console.WriteLine(vowelsCount);

            #endregion
        }
    }
}
