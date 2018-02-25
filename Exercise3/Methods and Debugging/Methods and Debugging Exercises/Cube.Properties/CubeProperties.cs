using System;

namespace Cube.Properties
{
    class CubeProperties
    {
        static void Main()
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = (double)CubeParameters(sideOfCube, parameter);
            Console.WriteLine("{0:f2}", result);
        }

        private static double CubeParameters(double num, string parameter)
        {
            if (parameter == "face")
            {
                double result = Math.Sqrt(2 * Math.Pow(num, 2));
                return result;
            }
            else if (parameter == "space")
            {
                double result = Math.Sqrt(3 * Math.Pow(num, 2));
                return result;
            }
            else if (parameter == "volume")
            {
                double result = Math.Pow(num,3);
                return result;
            }
            else
            {
                double result = 6 * Math.Pow(num, 2);
                return result;
            }
        }
    }
}
