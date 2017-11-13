using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int n = GetMultipleOfNum(Math.Abs(int.Parse(Console.ReadLine())));
            Console.WriteLine(n);
        }
        private static int GetMultipleOfNum(int num)
        {
            int sumEven = GetSumOfEven(num);
            int sumOdd = GetSumOfOdd(num);
            return sumEven * sumOdd;
        }
        private static int GetSumOfEven(int num)
        {
            int sum = 0;
            while (num>0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
        private static int GetSumOfOdd(int num)
        {
            int sum = 0;
            while (num >0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
