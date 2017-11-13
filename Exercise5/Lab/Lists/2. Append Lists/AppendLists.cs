using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class AppendLists
    {
        static void Main()
        {
            List<string> listOfNumbers = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();
            listOfNumbers.Reverse();
            foreach (var token in listOfNumbers)
            {
                string[] numbers = token.Split(' ');
                foreach (var item in numbers)
                {
                    if (item!= " ")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
