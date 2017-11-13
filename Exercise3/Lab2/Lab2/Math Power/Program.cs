using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            RaiseToPower(number, power);
        }
        static double RaiseToPower(double number, int power)
        {
            double result = 1d;
            for (int i = 1; i <= power; i++)
            {
                result *= number;  
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
