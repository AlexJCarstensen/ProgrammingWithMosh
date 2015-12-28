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

            Console.WriteLine("Please input a few numbers seperated by a hyphen.");
            var input = Console.ReadLine();

            var consecutive = IsConsecutiveList(input);

            var message = consecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);


            #endregion

            #region Program2

            //Console.WriteLine("Please input a few numbers seperated by a hyphen.");
            //var input = Console.ReadLine();

            //var dublicates = ContainsDublicate(input);
            //if (dublicates)
            //    Console.WriteLine("Duplicate");

            #endregion

            #region Program3

            //Console.WriteLine("please input a 24-hour format time");
            //var input = Console.ReadLine();

            //var result = CorrectTimeFormat(input);

            //Console.WriteLine(result ? "Ok" : "Invalid Time");

            #endregion

            #region Program4

            //Console.WriteLine("enter words");
            //var input = Console.ReadLine();


            //var pascalCase = WordsToPascalCase(input);

            //Console.WriteLine(pascalCase);

            #endregion

            #region Program5

            //Console.WriteLine("Enter a word: ");
            //var input = Console.ReadLine();

            //var vowelsCount = CountVowels(input);

            //Console.WriteLine(vowelsCount);

            #endregion
        }

        public static bool IsConsecutiveList(string input)
        {
            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var consecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1 && numbers[i] != numbers[i - 1] - 1)
                {
                    consecutive = false;
                }
            }
            return consecutive;
        }
        public static bool ContainsDublicate(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var uniqueNumbers = new List<int>();
            var dublicates = false;

            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
                else
                {
                    dublicates = true;
                    
                }
            }
            return dublicates;
        }
        public static bool CorrectTimeFormat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var time = input.Split(':');
            if (time.Length != 2)
            {
                return false;
            }

            try
            {
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);

                return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string WordsToPascalCase(string input )
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                return "";
            }
            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }
            return variableName;
        }
        public static int CountVowels(string input)
        {
            var vowels = new List<char>(new[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            foreach (var character in input.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            return vowelsCount;
        }
    }
}
