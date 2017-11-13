using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            long result = Fibonacchi(num);
            Console.WriteLine(result);
        }

        public static long Fibonacchi(int num)
        {
            long firstNum = 0L;
            long secNum = 1L;
            long result = 0L;
            if (num == 0 || num == 1)
            {
                return num;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result = firstNum + secNum;
                    firstNum = secNum;
                    secNum = result;
                }
                return result;
            }
        }
    }
}
