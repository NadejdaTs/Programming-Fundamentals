using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClassesExercises
{
    class CountWorkingDays
    {
        static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateTime firstdate = DateTime.ParseExact(
                    startDate,
                    "dd-MM-yyyy",
                    CultureInfo.InvariantCulture);

            DateTime secdate = DateTime.ParseExact(
                    endDate,
                    "dd-MM-yyyy",
                    CultureInfo.InvariantCulture);

            DateTime[] officialHolidays = new DateTime[11] {
                new DateTime(secdate.Year,01,01),
                new DateTime(secdate.Year,03,03),
                new DateTime(secdate.Year,05,01),
                new DateTime(secdate.Year,05,06),
                new DateTime(secdate.Year,05,24),
                new DateTime(secdate.Year,09,06),
                new DateTime(secdate.Year,09,22),
                new DateTime(secdate.Year,11,01),
                new DateTime(secdate.Year,12,24),
                new DateTime(secdate.Year,12,25),
                new DateTime(secdate.Year,12,26)
            };

            int workingDayCounter = 0;

            for (var currentDate = firstdate; currentDate <= secdate; currentDate = currentDate.AddDays(1))
            {
                var day = currentDate.DayOfWeek;
                if (!officialHolidays.Contains(currentDate) && !day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday))
                {
                    workingDayCounter++;
                }
            }

            Console.WriteLine(workingDayCounter);

        }
    }
}
