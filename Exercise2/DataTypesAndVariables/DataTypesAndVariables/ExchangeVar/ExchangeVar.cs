using System;

namespace ExchangeVar
{
    class ExchangeVar
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.WriteLine("After:");
            Console.WriteLine("a = "+b);
            Console.WriteLine("b = "+a);
        }
    }
}
