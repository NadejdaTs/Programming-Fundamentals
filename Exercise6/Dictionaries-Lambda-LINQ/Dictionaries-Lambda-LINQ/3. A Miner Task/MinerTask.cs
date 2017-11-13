using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.A_Miner_Task
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var resourceQuantity = new Dictionary<string, decimal>();

            while (!line.Equals("stop"))
            {
                var resourse = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resourceQuantity.ContainsKey(resourse)) //ako nqma takuv zapis
                {
                    resourceQuantity[resourse] = 0;         //napravi go
                }
                resourceQuantity[resourse] += quantity;      //dobavi kolichestwoto kum zapisa

                line = Console.ReadLine();
            }

            foreach (var resourse in resourceQuantity)
            {
                var resourseName = resourse.Key;
                var quantityOfResourse = resourse.Value;

                Console.WriteLine($"{resourseName} -> {quantityOfResourse}");
            }
        }
    }
}
