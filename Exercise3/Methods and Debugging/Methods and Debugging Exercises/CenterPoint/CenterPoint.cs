using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y)

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstDistance = ClosestPoints(x1,y1);
            double secondDistance = ClosestPoints(x2,y2);

            var list = new List<double>(2);
            if (firstDistance> secondDistance)
            {
                list.Add(x2);
                list.Add(y2);
                //Console.WriteLine("({0}, {1})",x2,y2);
            }
            else
            {
                list.Add(x1);
                list.Add(y1);
                //Console.WriteLine("({0}, {1})",x1,y1);
            }

            Console.Write("(");
            Console.Write(String.Join(", ", list));
            Console.WriteLine(")");
        }

        private static double ClosestPoints(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            return result;
        }
    }
}
