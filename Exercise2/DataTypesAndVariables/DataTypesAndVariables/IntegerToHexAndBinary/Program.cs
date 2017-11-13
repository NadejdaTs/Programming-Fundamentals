using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, base));
            Console.WriteLine(string.ToUpper(n));
        }
    }
}
