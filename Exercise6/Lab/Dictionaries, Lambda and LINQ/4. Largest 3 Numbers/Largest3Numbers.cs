using System;
using System.Linq;

namespace _4.Largest_3_Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var listOfNumbers = list
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ",listOfNumbers));
        }
    }
}
