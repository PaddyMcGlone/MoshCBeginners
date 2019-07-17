using System;
using System.IO;

namespace Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.
            //var file = File.ReadAllText("/Users/patrickmcglone/Documents/sampletext");
            //Console.WriteLine($"There are {file.Split(' ').Length} words in this file");

            //2 - Write a program that reads a text file and displays the longest word in the file.
            var myFile = File.ReadAllText("/Users/patrickmcglone/Documents/sampletext");
            var longestWord = "";

            foreach (var word in myFile.Split(' '))
                longestWord = longestWord.Length < word.Length ? word : longestWord;

            Console.WriteLine($"The longest word within your file is : {longestWord}");
        }
    }
}
