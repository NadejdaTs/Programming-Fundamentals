using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int max = GetMax(firstNum, secNum, thirdNum);
            Console.WriteLine(max);
        }
        static int GetMax(int first, int sec, int third)
        {
            if (first > sec && first > third)
            {
                return first;
            }
            else if (sec > first && sec > third)
            {
                return sec;
            }
            else
            {
                return third;
            }
        }
    }
}
