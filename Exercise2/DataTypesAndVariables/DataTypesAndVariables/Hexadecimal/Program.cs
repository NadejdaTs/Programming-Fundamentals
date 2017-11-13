using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(a,16));
        }
    }
}
