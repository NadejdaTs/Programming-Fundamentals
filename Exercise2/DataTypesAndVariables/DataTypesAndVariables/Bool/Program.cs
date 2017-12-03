using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //bool b = Convert.ToBoolean(str);
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
