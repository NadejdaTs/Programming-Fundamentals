﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number,16).ToUpper());
            Console.WriteLine(Convert.ToString(number,2));
        }
    }
}
