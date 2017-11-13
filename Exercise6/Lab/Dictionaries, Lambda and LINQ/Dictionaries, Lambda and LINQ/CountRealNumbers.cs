using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries__Lambda_and_LINQ
{
    class CountRealNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .OrderBy(n => n)
                .Select(double.Parse)
                .ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            } 
        }
    }
}
