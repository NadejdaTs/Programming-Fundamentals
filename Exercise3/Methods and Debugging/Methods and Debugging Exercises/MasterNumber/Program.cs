using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (ContainsEvenDigits(i))
                {
                    if (IsPalindrome(i.ToString()) && SumOfDigits(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static bool IsPalindrome(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ContainsEvenDigits(int num)
        {
            int lastDigit = 0;
            bool evenDigit = false;
            while (num != 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    evenDigit = true;
                }
                num /= 10;
            }
            return evenDigit;
        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            int lastDigit = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
