using System;
using System.IO;

namespace _02.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("2.IndexOfLetters.txt");

            //string word = Console.ReadLine();
            for (int l = 0; l < file.Length; l++)
            {
                var currRow = file[l];
                char[] alphabet = new char[26];

                for (int i = 0; i < alphabet.Length; i++)
                {
                    alphabet[i] = (char)('a' + i);
                }
                for (int i = 0; i < currRow.Length; i++)
                {
                    Console.WriteLine(currRow[i] + " -> " + Array.IndexOf(alphabet, currRow[i]));
                }
            }
        }
    }
}
