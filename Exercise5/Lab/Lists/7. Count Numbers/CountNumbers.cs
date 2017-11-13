using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class CountNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            //int lastNum = Int32.MaxValue; //purvi nacin
            //numbers.Add(lastNum);         //purvi nacin
            int count = 1;
            if (numbers.Count>0)
            {
                var previous = numbers[0];
                
                for (int i = 1; i < numbers.Count; i++)
                {
                    var current = numbers[i];
                    if (current == previous)
                    {
                        count++;
                    }
                    else
                    {       
                        Console.WriteLine($"{previous} -> {count}");
                        count = 1;
                    }
                    previous = current;
                }
                Console.WriteLine($"{previous} -> {count}"); //vtori nachin
            }   
        }
    }
}
