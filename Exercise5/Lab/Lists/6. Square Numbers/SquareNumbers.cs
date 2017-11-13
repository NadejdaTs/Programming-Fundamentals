
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var resultList = new List<int>();
            numbers.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < numbers.Count; i++)
            {
                //var square = Math.Sqrt(numbers[i]);
                if (Math.Sqrt(numbers[i]) % 1 == 0)
                {
                    resultList.Add(numbers[i]);
                }
            }
            Console.Write(String.Join(" ", resultList));
            Console.WriteLine();
        }
    }
}
