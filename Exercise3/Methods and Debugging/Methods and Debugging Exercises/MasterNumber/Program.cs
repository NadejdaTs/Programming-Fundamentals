using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = MasterNumber(n);
            Console.ReadLine(result);
        }
        public static int MasterNumber(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    if (true)
                    {
                        if (true)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
