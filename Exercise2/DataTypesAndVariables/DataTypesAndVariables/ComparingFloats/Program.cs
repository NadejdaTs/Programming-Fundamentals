using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(System.Console.ReadLine());
            double secNumber = double.Parse(System.Console.ReadLine());
            double eps = 0.000001d;
            if (Math.Abs(number - secNumber) <= eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
