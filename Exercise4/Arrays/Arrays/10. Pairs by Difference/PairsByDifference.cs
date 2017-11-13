using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class PairsByDifference
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length-1; j >i ; j--)
                {
                    if (numbers[i] - numbers[j] == n || numbers[j] - numbers[i] == n)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
