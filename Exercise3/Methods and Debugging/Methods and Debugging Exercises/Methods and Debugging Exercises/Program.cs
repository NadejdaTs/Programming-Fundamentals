using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Debugging_Exercises
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
