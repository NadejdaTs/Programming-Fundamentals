using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool first = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        first = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}",i,first);
            }

        }
    }
}
