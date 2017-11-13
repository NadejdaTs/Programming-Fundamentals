using System;
using System.Linq;

namespace _5.Sort_Numbers
{
    class SortNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();
            Console.Write(String.Join(" <= ", numbers));
            Console.WriteLine();
        }
    }
}
