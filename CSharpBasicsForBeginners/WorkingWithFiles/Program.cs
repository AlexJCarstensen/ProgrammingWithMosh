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
            var countWords = WordsInTextFile(Directory.GetCurrentDirectory() + @"\text.txt");

            Console.WriteLine(countWords);
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

        public static string MostRepeatedWords(string path)
        {
            return "";
        }
    }
}
