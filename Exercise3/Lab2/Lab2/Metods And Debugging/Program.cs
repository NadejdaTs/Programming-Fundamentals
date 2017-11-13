using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods_And_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRecipt();
        }
        static void PrintRecipt()
        {
            PrintReciptHeader();
            PrintReciptBody();
            PrintReciptFooter();
        }
        static void PrintReciptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }  
        static void PrintReciptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintReciptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
