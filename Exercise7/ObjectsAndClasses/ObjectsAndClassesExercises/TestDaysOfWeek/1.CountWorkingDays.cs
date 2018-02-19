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

            DateTime[] officialHolidays = new DateTime[22] {
                new DateTime(secdate.Year,1,1),
                new DateTime(secdate.Year,3,3),
                new DateTime(secdate.Year,5,1),
                new DateTime(secdate.Year,5,6),
                new DateTime(secdate.Year,5,24),
                new DateTime(secdate.Year,9,6),
                new DateTime(secdate.Year,9,22),
                new DateTime(secdate.Year,11,1),
                new DateTime(secdate.Year,12,24),
                new DateTime(secdate.Year,12,25),
                new DateTime(secdate.Year,12,26),

                new DateTime(firstdate.Year,1,1),
                new DateTime(firstdate.Year,3,3),
                new DateTime(firstdate.Year,5,1),
                new DateTime(firstdate.Year,5,6),
                new DateTime(firstdate.Year,5,24),
                new DateTime(firstdate.Year,9,6),
                new DateTime(firstdate.Year,9,22),
                new DateTime(firstdate.Year,11,1),
                new DateTime(firstdate.Year,12,24),
                new DateTime(firstdate.Year,12,25),
                new DateTime(firstdate.Year,12,26)



            };

            int workingDayCounter = ((secdate - firstdate).Days) + 1;

            for (var currentDate = firstdate; currentDate <= secdate; currentDate = currentDate.AddDays(1))
            {
                var day = currentDate.DayOfWeek;
                if (officialHolidays.Contains(currentDate) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday))
                {
                    workingDayCounter--;
                }
            }

            Console.WriteLine(workingDayCounter);

        }
    }
}
