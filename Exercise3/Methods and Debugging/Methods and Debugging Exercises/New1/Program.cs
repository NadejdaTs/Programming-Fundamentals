using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            GetZeroes(factorial);
        }
        static void GetZeroes(BigInteger num)
        {
            BigInteger timesZero = 0;
            while (num % 10 == 0)
            {
                timesZero++;
                num = num / 10;
            }
            Console.WriteLine(timesZero);
        }
    }
}

