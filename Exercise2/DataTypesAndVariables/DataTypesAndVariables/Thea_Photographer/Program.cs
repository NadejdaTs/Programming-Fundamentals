using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterFactorInPercent = double.Parse(Console.ReadLine());
            int uploadetTime = int.Parse(Console.ReadLine());

            var picturesForFiltering = Math.Ceiling(pictureCount * ((double)filterFactorInPercent / 100));

            int filterdInSeconds = pictureCount * filterTime;          
            var uploadGoodPictures = picturesForFiltering * uploadetTime;

            var totalInSeconds = filterdInSeconds + (int)uploadGoodPictures;
            var totalTime = new TimeSpan(0, 0, totalInSeconds);
            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
