using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine();
            double result = (double)CalculateFigureArea(figureType);
            Console.WriteLine("{0:f2}",result);
        }

        private static double CalculateFigureArea(string type)
        {
            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    return side * height / 2;
                case "square":
                    double sideOfSquare = double.Parse(Console.ReadLine());
                    return sideOfSquare * sideOfSquare;
                case "rectangle":
                    double sideOfRectangle = double.Parse(Console.ReadLine());
                    double secsideOfRectangle = double.Parse(Console.ReadLine());
                    return sideOfRectangle * secsideOfRectangle;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    return Math.PI * radius * radius;
                default:
                    return 0.0;
            }
        }
    }
}
