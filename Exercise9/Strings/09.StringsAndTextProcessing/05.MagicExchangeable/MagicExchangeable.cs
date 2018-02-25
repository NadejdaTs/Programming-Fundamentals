using System;
using System.Collections.Generic;

namespace _5.MagicExchangeable
{
    class MagicExchangeable
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Trim()
                .Split(' ');

            var firstWord = text[0];
            var secWord = text[1];

            if (firstWord.Length >= secWord.Length)
            {
                MapWords(firstWord, secWord);
            }
            else
            {
                MapWords(secWord, firstWord);
            }
        }
//razgledaai ot tuk
        private static void MapWords(string word1, string word2)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            for (int i = 0; i < word2.Length; i++)
            {
                char firstWordChar = word1[i];
                char secondWordChar = word2[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    map[firstWordChar] = secondWordChar;
                }
                else if (map[firstWordChar] != secondWordChar)
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            for (int i = word2.Length; i < word1.Length; i++)
            {
                char firstWordChar = word1[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}
