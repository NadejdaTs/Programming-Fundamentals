using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                double result = num * num * num;
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
