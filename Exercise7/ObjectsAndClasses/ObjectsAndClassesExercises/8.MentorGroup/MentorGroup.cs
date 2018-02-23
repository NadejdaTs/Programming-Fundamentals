using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _8.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();

            var firstText = Console.ReadLine();

            while (firstText != "end of dates")
            {
                Student currStudent = new Student();
                var dateTimes = new List<DateTime>();

                char[] separators = new char[] { ' ', ',' };
                var nameAndDates = firstText
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = nameAndDates[0];

                for (int i = 1; i < nameAndDates.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(nameAndDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dateTimes.Add(date);
                }
                bool exist = false;

                foreach (var person in student.Where(x => x.Name.Equals(name)))
                {
                    person.Dates.AddRange(dateTimes);
                    exist = true;
                }

                if (!exist)
                {
                    currStudent.Name = name;
                    currStudent.Dates = dateTimes;
                    currStudent.Comment = new List<string>();
                    student.Add(currStudent);
                }

                firstText = Console.ReadLine();
            }

            var secondText = Console.ReadLine();

            while (secondText != "end of comments")
            {
                var textComents = secondText
                    .Split('-');

                var name = textComents[0];
                var comment = textComents[1];

                foreach (var person in student.Where(n => n.Name.Equals(name)))
                {
                    person.Comment.Add(comment);
                }

                secondText = Console.ReadLine();
            }

            foreach (var person in student.OrderBy(n => n.Name))
            {
                Console.WriteLine(person.Name);
                Console.WriteLine("Comments:");

                foreach (var comment in person.Comment)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in person.Dates.OrderBy(x => x.Date))
                {
                    string dates = date.ToString("dd/MM/yyyy");
                    Console.WriteLine($"-- {dates}");
                }

            }
        }
    }
}
