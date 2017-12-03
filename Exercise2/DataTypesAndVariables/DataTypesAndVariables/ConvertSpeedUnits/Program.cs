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

            float metersPerSeconds = distInMeters/(seconds+(minutes*60)+(hours*60*60));
            float kilometersPerHours = (distInMeters / 1000) /(hours+(minutes/60)+(seconds/60/60));
            double milesPerHours = ((distInMeters/1000)* 0.62137)/ (hours + (minutes / 60) + (seconds / 60 / 60));
            Console.WriteLine(Math.Round(metersPerSeconds,5));
            Console.WriteLine(Math.Round(kilometersPerHours, 5));
            Console.WriteLine(Math.Round(milesPerHours, 5));

        }
    }
}
