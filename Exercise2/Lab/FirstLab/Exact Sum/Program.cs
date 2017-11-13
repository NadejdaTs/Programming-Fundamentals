using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal number = 0m;
            decimal result = 0m;
            for (int i = 1; i <= num; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
