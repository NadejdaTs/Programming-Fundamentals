using System;

namespace NumbersReversedOrder
{
    class NumbersReversedOrder
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double result = GetReversedOrder(number);
            Console.WriteLine(result);
        }

        private static double GetReversedOrder(double num)
        {
            var numString = num.ToString();
            var reversedString = String.Empty;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }
            double result = double.Parse(reversedString);
            return result;
        }
    }
}
