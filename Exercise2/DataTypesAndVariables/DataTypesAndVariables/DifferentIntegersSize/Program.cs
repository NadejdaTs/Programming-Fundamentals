using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(System.Console.ReadLine());
            if (n >= -128 && n <= 127)
            {
                Console.WriteLine("* sbyte");
            }
        }
    }
}
