using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            var list = FindPrimesInRange(firstNum, secNum);
            Console.WriteLine(String.Join(", ", list));
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
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

