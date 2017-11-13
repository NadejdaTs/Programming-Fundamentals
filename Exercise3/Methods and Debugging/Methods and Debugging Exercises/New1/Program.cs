using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
                num = num / 10;
                timesZero++;
            }
            Console.WriteLine(timesZero);
        }
    }
}

