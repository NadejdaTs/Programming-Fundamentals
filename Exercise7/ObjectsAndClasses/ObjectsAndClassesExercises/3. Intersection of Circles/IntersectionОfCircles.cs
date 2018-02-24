using System;
using System.Linq;

namespace _3.Intersection_of_Circles
{
    class IntersectionОfCircles
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ', '\r', '\n')
                .Select(int.Parse)
                .ToArray();

            var input2 = Console.ReadLine()
                .Split(' ', '\r', '\n')
                .Select(int.Parse)
                .ToArray();

            var firstPointX = input[0];
            var firstPointY = input[1];
            var firstRadius = input[2];

            var secPointX  = input2[0];
            var sectPointY = input2[1];
            var sectRadius = input2[2];

            var firstCircleCenter = new Point(firstPointX, firstPointY);
            var secCircleCenter = new Point(secPointX, sectPointY);

            var firstCyrcle = new Circle(firstCircleCenter, firstRadius);
            var secCyrcle = new Circle(secCircleCenter, sectRadius);

            var result = firstCyrcle.Intercepts(secCyrcle) ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }
}
