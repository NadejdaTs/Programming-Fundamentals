using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            float firstTime = (float)(sec + (((hours*60f)+min)*60f));
            float secTime = (float)(hours + (((sec/60f)+min)/60f));
            float thirdTime = (float)secTime/ 0.621371f;
            float meterPerSec = distance/firstTime;
            float kmPerHour = (distance/1000)/secTime;
            float mph = (distance/1609f)/ (float)secTime;
            Console.WriteLine(meterPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(mph);
        }
    }
}
