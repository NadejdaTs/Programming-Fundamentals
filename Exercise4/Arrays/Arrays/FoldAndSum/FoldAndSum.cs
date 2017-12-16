using System;
using System.Linq;

namespace Fold_And_Sum
{
    class FoldАndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            var firstRowLeft = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstRowLeft
                .Concat(firstRowRight)
                .ToArray();

            var secondRow = numbers
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            //firstRow
            //    .Zip(secondRow, (x, y) => x + y)
            //    .ToList()
            //    .ForEach(Console.WriteLine);
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
