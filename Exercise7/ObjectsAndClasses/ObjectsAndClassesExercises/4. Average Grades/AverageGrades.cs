using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Average_Grades
{
    class AverageGrades
    {
        public static object GetOrderList { get; private set; }

        static void Main()
        {
            var countStudent = int.Parse(Console.ReadLine());         
            var listOfStudents = new List<Students>();

            for (int i = 1; i <= countStudent; i++)
            {
                var listOfGrades = new List<double>();
                var studentInfo = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = studentInfo[0].ToString();

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    var num = double.Parse(studentInfo[j]);
                    listOfGrades.Add(num);
                }

                var currStudent = new Students();
                currStudent.Name = name;
                currStudent.Grades = listOfGrades;               

                var average = currStudent.Average(listOfGrades);
                currStudent.AverageGrade = average;
                if (average >= 5.0)
                {
                    listOfStudents.Add(currStudent);
                }
            }

            var result = listOfStudents
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }     
           
        }
        //class Students
        //{
        //    public string Name { get; set; }
        //    public List<double> Grades { get; set; }
        //    public double AverageGrade { get; set; }

        //    public double Average(List<double> Grades)
        //    {
        //        var sum = 0d;
        //        for (int i = 0; i < Grades.Count; i++)
        //        {
        //            sum += Grades[i];
        //        }
        //        return sum / Grades.Count;
        //    }
        //}
    }
}
