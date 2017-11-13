using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length/4;

            var firstLeftPart = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRightPart = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstLeftPart
                .Concat(firstRightPart)
                .ToArray();

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var result = 0;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                result = firstRow[i] + secondRow[i];
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
    }
}

