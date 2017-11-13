using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            bool result = IsPrime(number);
            Console.WriteLine(result);
        }

        private static bool IsPrime(long num)
        {
            var isPrime = true;
            if (num == 0 || num == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
                return isPrime;
        }
    }
}
