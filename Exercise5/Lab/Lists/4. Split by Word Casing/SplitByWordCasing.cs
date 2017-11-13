using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { '.', ',', ':', ';', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerList = new List<string>();
            List<string> mixedList = new List<string>();
            List<string> upperList = new List<string>();

            bool isUpper=false;
            bool isLower=false;
            bool mixed=false;
            bool digit = false;
            foreach (var word in text)
            {
                if (word != word.ToLower()&& word !=word.ToUpper())
                {
                    foreach (var letter in word)
                    {
                        if (char.IsDigit(letter)||!char.IsLetter(letter))
                        {
                            digit = true;
                        }
                        if (char.IsLetter(letter))
                        {
                            mixed = true;
                        }
                    }
                    if (mixed==true||digit ==true)
                    {
                        mixedList.Add(word);
                    }
                    
                }
                else if (word == word.ToUpper())
                {
                    foreach (var letter in word)
                    {
                        if (char.IsLetter(letter)&&!char.IsDigit(letter))
                        {
                            isUpper = true;
                        }
                    }
                    if (isUpper)
                    {
                        upperList.Add(word);
                    }
                    
                }
                else 
                {
                    foreach (var letter in word)
                    {
                        if (char.IsLetter(letter))
                        {
                            isLower = true;
                        }
                    }
                    if (isLower)
                    {
                        lowerList.Add(word);
                    }
                }
                
            }

            Console.WriteLine("Lower -case: {0}", string.Join(", ", lowerList));
            Console.WriteLine("Mixed -case: {0}", string.Join(", ", mixedList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperList));
        }
    }
}
