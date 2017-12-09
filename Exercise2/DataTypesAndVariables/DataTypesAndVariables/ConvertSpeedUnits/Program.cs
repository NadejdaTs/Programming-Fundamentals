using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float metersPerSeconds = distInMeters/(seconds+(minutes*60.0f)+(hours*60.0f* 60.0f));
            float kilometersPerHours = (distInMeters / 1000.0f) /(hours+(minutes/ 60.0f) +(seconds/ 60.0f / 60.0f));
            float milesPerHours = (distInMeters/ 1609.0f) / (hours + (minutes / 60.0f) + (seconds / 60.0f / 60.0f));
            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHours);
            Console.WriteLine(milesPerHours);

        }
    }
}
