using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }
        static void PrintSign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number 2 is positive.");
            }
            else
            {
                Console.WriteLine("The number -5 is negative.");
            }
        }
    }
}
