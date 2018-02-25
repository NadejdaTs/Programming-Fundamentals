using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double secNumber = double.Parse(Console.ReadLine());
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
