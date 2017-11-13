using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool result = false;
            for (int num = 1; num <= number; num++)
            {
                digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {result}");
                sum = 0;
                num = digit;
            }
        }
    }
}
