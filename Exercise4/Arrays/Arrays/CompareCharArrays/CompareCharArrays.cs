using System;
using System.Linq;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(x => char.Parse(x)).ToArray();
            char[] secArray = Console.ReadLine().Split(' ').Select(x => char.Parse(x)).ToArray();

            int firstLength = firstArray.Length - 1;
            int secLength = secArray.Length - 1;
            for (int i = 0; i < secLength; i++)
            {
                if (firstArray[i] > secArray[i])
                {
                    Console.WriteLine(secArray);
                    Console.WriteLine(firstArray);
                    break;
                }
                else if (firstArray[i] < secArray[i])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secArray);
                    break;
                }
                else
                {
                    Console.WriteLine(secArray);
                    Console.WriteLine(firstArray);
                    break;
                }
            }
        }
    }
}

