using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] ==numbers[i])
                {
                    sum = numbers[i-1] + numbers[i];
                    numbers[i] = sum;
                    numbers.RemoveAt(i-1);
                    i = 0;
                }  
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
