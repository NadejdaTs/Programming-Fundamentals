using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = Console.ReadLine();
            if (choise == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secNum = int.Parse(Console.ReadLine());
                int max = GetMax(firstNum,secNum);
                Console.WriteLine(max);
            }
            else if (choise == "char")
            {
                char firstCh = char.Parse(Console.ReadLine());
                char secCh = char.Parse(Console.ReadLine());
                char max = GetMax(firstCh,secCh);
                Console.WriteLine(max);
            }
            else
            {
                string firstCh = Console.ReadLine();
                string secCh = Console.ReadLine();
                string max = GetMax(firstCh, secCh);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
