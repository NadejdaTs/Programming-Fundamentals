using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class FromLab
    {
        static void Main(string[] args)
        {
            string[] nameOfDate = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(nameOfDate[day - 1]);
            }
            else
            { 
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
