using System.Collections.Generic;

namespace _4.Average_Grades
{
    class Students
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

        public double Average(List<double> Grades)
        {
            var sum = 0d;
            for (int i = 0; i < Grades.Count; i++)
            {
                sum += Grades[i];
            }
            return sum / Grades.Count;
        }
    }
}
