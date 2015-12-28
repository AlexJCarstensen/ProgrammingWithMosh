using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // var countWords = WordsInTextFile(Directory.GetCurrentDirectory() + @"\text.txt");
            // Console.WriteLine(countWords);

            var repeatedWords = MostRepeatedWords(Directory.GetCurrentDirectory() + @"\text.txt");
            foreach (var repeatedWord in repeatedWords)
            {
                Console.WriteLine(repeatedWord);
            }
        }

        public static int WordsInTextFile(string path)
        {
            var words = File.ReadAllText(path);
            var count = 0;
            foreach (var word in words.Split(' '))
            {
                count++;
            }
            return count;
        }

        public static List<string> MostRepeatedWords(string path)
        {
            var words = File.ReadAllText(path);
            var wordArray = words.Split(' ');
            var repeatedWords = new List<string>();
            var uniqueWords = new List<string>();

            foreach (var word in wordArray)
            {
                if (!uniqueWords.Contains(word))
                    uniqueWords.Add(word);
                else
                {
                    if(!repeatedWords.Contains(word))
                        repeatedWords.Add(word);
                }
            }

            var numString = new List<string>();
            foreach (var repeatedWord in repeatedWords)
            {
                var count = 0;
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (wordArray[i].Contains(repeatedWord))
                        count++;
                }

                var strBuild = new StringBuilder();
                var str = "";
                str = strBuild.Append(Convert.ToString(count) + ' ' + repeatedWord).ToString();
                numString.Add(str);
                numString.Sort();
            }
            foreach (var item in numString)
            {
                Console.WriteLine(item);
            }
            var mostRepeated = new List<string>
            {
                numString.ElementAt(numString.Count - 1).Remove(0, 2),
                numString.ElementAt(numString.Count - 2).Remove(0, 2),
                numString.ElementAt(numString.Count - 3).Remove(0, 2)
            };
            return mostRepeated;
        }
    }
}
