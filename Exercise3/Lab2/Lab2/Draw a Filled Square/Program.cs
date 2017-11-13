using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintHeader(num);
            PrintMiddle(num);
            PrintHeader(num);
        }
        static void PrintHeader(int number)
        {
            Console.WriteLine(new string('-',2*number));
        }
        static void PrintMiddle(int number)
        {
            int middlePart = number / 2;
            for (int i = 1; i <= middlePart; i++)
            {
                Console.Write("-");
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
