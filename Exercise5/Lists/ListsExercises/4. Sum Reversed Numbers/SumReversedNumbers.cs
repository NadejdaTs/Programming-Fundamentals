using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            //int sum = Console.ReadLine().Split().Select(e => new String(e.Reverse().ToArray())).Sum(e => int.Parse(e));
            //Console.WriteLine(sum);    - raboti i samo s tezi dva reda
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<int>();
            string eachElement = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                eachElement = numbers[i];
                char[] element = eachElement.ToCharArray();
                char[] results = element.Reverse().ToArray();
                result.Add(int.Parse(String.Join("", results)));
            }
            Console.WriteLine(result.Sum());
        }
    }
}
