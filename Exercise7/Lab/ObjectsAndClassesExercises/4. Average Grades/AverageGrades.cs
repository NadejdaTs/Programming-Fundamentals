using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class AverageGrades
    {
        static void Main()
        {

        }

        private static ReadStudents()
        {

        }
        public static student[] ReadStudents()
        {
                    int num = int.Parse(Console.ReadLine());

        string[] namesAndGrades = new string[num];

        var students = namesAndGrades[0];

            for (int i = 0; i<num; i++)
            {
                students[i] = ReadStudents();
    }
            return students;
        }
    }
}
