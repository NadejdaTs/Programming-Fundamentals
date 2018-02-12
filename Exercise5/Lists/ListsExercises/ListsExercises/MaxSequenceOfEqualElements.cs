using System;
using System.Linq;

namespace ListsExercises
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var numbres = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var count = 0;
            var maxCount = 0;
            var start = 0;

            for (int i = 0; i < numbres.Count-1; i++)
            {
                if (numbres[i]== numbres[i+1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        start = i - count;  //current position
                        maxCount = count;
                    }
                }
                else
                { 
                        count = 0;
                }
            }
            for (int i = start + 1; i <= start + 1 + maxCount; i++)
            {
                Console.Write(numbres[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
