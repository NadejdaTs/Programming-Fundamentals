using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class DayOfWeek
    {
        static void Main()
        {
            string dayOfWeek = Console.ReadLine();
            DateTime date = DateTime.ParseExact(
                dayOfWeek, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
