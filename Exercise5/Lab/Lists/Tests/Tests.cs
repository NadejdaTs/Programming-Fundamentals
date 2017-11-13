using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Tests
    {
        static void Main()
        {
            //var list = new List<int>();
            //list.Add(5);
            //list.Add(25);
            //list.Add(45);
            //list.Add(55);
            //list.Add(15);
            //list.Insert(3, 15);
            //list.RemoveAt(4);
            //list.RemoveAll(x=>x%25==0);
            //Console.WriteLine(String.Join(" ",list));
            ///////////////////////////////////////
            //List<int> result = new List<int>();
            //result.Add(5);
            //result.Add(15);
            //result.Add(55);
            //result.Add(35);
            //result.Add(25);
            //result.Sort();
            //Console.WriteLine(result);
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                //var square = Math.Sqrt(numbers[i]);
                if (Math.Sqrt(numbers[i])%1==0)
                {
                    Console.WriteLine(numbers[i]); ;
                }
            }
        }
    }
}
