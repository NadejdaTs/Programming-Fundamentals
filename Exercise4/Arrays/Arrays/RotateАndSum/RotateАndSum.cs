using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateАndSum
{
    class RotateАndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] result = Rotate(numbers, k);
            Console.WriteLine(String.Join(" ", result));


            //string[] numbers = Console.ReadLine().Split(' ');
            //int k = int.Parse(Console.ReadLine());
            //int[] result = new int[numbers.Length];
            //for (int i = 1; i < k; i++)
            //{
            //    Console.WriteLine(String.Join(" ", result));
            //}
        }
        public static int[] Rotate(int[] numbers, int k)
        {
            int[] sum = new int[numbers.Length];
            for (int i = 0; i < k%numbers.Length; i++)              //%numbers.Length - za da ne prevyrta masiva!!!
            {
                int numLast = numbers[numbers.Length - 1];
                for (int j = numbers.Length-1; j > 0; j--)
                {
                    numbers[j] = numbers[j-1];
                }
                numbers[0] = numLast;
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            return sum;
        }
    }
}
