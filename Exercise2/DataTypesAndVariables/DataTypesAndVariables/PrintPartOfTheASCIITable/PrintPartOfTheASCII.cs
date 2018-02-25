using System;

namespace PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCII
    {
        static void Main(string[] args)
        {
            int FirstNum = int.Parse(Console.ReadLine());
            int LastNum = int.Parse(Console.ReadLine());

            for (int i = FirstNum; i <= LastNum; i++)
            {
                Console.Write(Convert.ToChar(i));
            }
            Console.WriteLine();
            
        }
    }
}
