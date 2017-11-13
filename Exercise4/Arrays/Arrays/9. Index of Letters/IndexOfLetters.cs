using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a'+i);
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]+" -> "+ Array.IndexOf(alphabet, word[i]));
            }
        }
    }
}
