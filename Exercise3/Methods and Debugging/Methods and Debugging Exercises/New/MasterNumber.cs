﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            CenterLine(x1, y1, x2, y2, x3, y3, x4, y4);
            if (LineLength(x1, y1, x2, y2) == LineLength(x3, y3, x4, y4))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        public static void CenterLine(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            double diagonal1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double diagonal3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double diagonal4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));


            if ((diagonal1 + diagonal2) > (diagonal3 + diagonal4))
            {
                if (diagonal1 > diagonal2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            if ((diagonal3 + diagonal4) > (diagonal1 + diagonal2))
            {
                if (diagonal3 > diagonal4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }

        }

        private static double LineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
