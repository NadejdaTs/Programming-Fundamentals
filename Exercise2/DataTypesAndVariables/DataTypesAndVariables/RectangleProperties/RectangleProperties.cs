using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = (a + b) * 2;
            double area = a * b;
            double diagonal = Math.Sqrt(a * a + b * b);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);//ot flashkata
        }
    }
}
