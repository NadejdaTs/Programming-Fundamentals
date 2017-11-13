using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var dictionry = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionry.ContainsKey(word))
                {
                    dictionry[word] = 0;
                }
                dictionry[word]++;
            }

            var result = new List<string>();
            foreach (var item in dictionry)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
