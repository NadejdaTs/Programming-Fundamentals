using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(n => n)
                .Distinct()
                .ToList();

            var result = new List<string>();
            foreach (var word in text)
            {
                if (word.Length < 5)
                {
                    result.Add(word);
                }
            }
               
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
