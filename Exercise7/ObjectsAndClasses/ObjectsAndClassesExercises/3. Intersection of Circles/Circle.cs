using System;

namespace _3.Intersection_of_Circles
{
    class Circle
    {
        public Circle(Point Center, int radius)
        {
            this.Center = Center;
            this.Radius = radius;
        }
        public Point Center { get; set; }
        public int Radius { get; set; }

        public bool Intercepts(Circle other)
        {
            var a = (double)(other.Center.X - this.Center.X);
            var b = (double)(other.Center.Y - this.Center.Y);

            var distanceBetweenCenters = Math.Sqrt(a * a + b * b);
            return distanceBetweenCenters <= this.Radius + other.Radius;
        }
    }
}
