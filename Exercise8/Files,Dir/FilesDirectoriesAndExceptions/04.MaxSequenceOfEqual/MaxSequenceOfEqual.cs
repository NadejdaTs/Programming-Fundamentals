using System;
using System.Linq;
using System.IO;

namespace _04.MaxSequenceOfEqual
{
    class MaxSequenceOfEqual
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("4.MaxSequenceOfEqualElements.txt");

            for (int l = 0; l < file.Length; l++)
            {
                var currRow = file[l]
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                var count = 0;
                var maxCount = 0;
                var start = 0;

                for (int i = 0; i < currRow.Count - 1; i++)
                {
                    if (currRow[i] == currRow[i + 1])
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
                    Console.Write(currRow[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
