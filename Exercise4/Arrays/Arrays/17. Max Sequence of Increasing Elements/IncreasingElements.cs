using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class IncreasingElements
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int maxCount = 0;
            int start = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i+1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        start = i - count; //zapazva nomera na elementa ot masiwa, s poredica
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = start + 1; i <= start + maxCount + 1; i++) //zaradi masiva i =0 - start
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
