using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Bool
    {
        static void Main(string[] args)
        {
            bool b = Convert.ToBoolean(Console.ReadLine());

            if (b)
            {          
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
