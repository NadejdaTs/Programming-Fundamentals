using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_Reversed_Numbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split()            
                .ToList(); //123 234 12

            var resultArray = new List<int>();

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                var eachElement = listOfNumbers[i].ToCharArray();
                var reversed = eachElement.Reverse();
                resultArray.Add(int.Parse(String.Join("", reversed)));
            }


            Console.WriteLine(listOfNumbers[0]);
            //Console.WriteLine(string.Join(", ", listOfNumbers));

            //var listOfNum = new List<int>();
            //listOfNum.Add(105);
            //listOfNum.Add(10);
            //listOfNum.Insert(1, 40);
            //listOfNum.Add(30);
            //listOfNum.RemoveAt(2);
            //if (listOfNum.Contains(40))
            //{
            //    Console.WriteLine(string.Join(", ", listOfNum));
            //}

            //var numbers = Console.ReadLine()
            //    .Split(' ')
            //    .ToList();

            //var result = new List<int>();
            //string eachElement = string.Empty;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    eachElement = numbers[i];
            //    char[] element = eachElement.ToCharArray();
            //    char[] results = element.Reverse().ToArray();
            //    result.Add(int.Parse(String.Join("", results)));
            //}
            //Console.WriteLine(result.Sum());
        }
    }
}
