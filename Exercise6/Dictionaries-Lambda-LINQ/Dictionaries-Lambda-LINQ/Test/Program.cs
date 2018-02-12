using System;
using System.Collections.Generic;

namespace _3.A_Miner_Task
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var resourceQuantity = new Dictionary<string, decimal>();

            while (line != "stop")
            {
                var resourse = line;
                var quantity = decimal.Parse(Console.ReadLine());
                if (!resourceQuantity.ContainsKey(resourse))
                {
                    resourceQuantity[resourse] = 0;
                }
                resourceQuantity[resourse] += quantity;    
                line = Console.ReadLine();
            }

            foreach (var resourse in resourceQuantity)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
