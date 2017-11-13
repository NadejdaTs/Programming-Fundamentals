using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine(1,5);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j < i ; j++)
                {
                    Console.WriteLine(1);
                }
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
