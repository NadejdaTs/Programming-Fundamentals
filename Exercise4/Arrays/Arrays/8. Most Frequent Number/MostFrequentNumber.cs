using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int currNumber = 0;
            int count = 0;
            int maxCount = 0;
            int start = 0;
            int mostFreqNum = 0;
            int num = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                currNumber = numbers[i];
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (currNumber == numbers[j])
                    {
                        count++;
                        if (maxCount<count)
                        {
                            start = i - count;
                            maxCount = count;
                        }
                        if (num < count)
                        {
                            mostFreqNum = currNumber;
                            num = count;
                        }

                    }
                    else
                    {
                        count = 0;
                    }
                }
                
            }
            Console.WriteLine(mostFreqNum);
        }
    }
}
