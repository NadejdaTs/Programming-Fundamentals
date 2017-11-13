using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n-1; i++)
            {
                for (int j = 0; j <= n-1; j++)
                {
                    for (int l = 0; l <= n-1; l++)
                    {
                        char letter = (char)('a' + i);
                        char secLetter = (char)('a' + j);
                        char thirdLetter = (char)('a' + l);
                        Console.WriteLine("{0}{1}{2}", letter, secLetter, thirdLetter);
                    }
                }
            }
        }
    }
}
