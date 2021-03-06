﻿using System;

namespace Name_оf_The_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            string nameNum = GetNameOfLastNum(number);
            Console.WriteLine(nameNum);
        }
        static string GetNameOfLastNum(long number)
        {
            var lastDigit = number % 10;

            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
    }
}
