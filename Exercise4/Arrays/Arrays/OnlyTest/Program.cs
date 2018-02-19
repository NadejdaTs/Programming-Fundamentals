using System;
using System.Linq;

namespace OnlyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////3.Fold and Sum - another way
            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int k = array.Length / 4;
            //int[] upperRow = new int[k * 2];
            //int[] lowerRow = new int[k * 2];

            //for (int i = 0; i < k; i++)
            //{
            //    upperRow[i] = array[k - i - 1];
            //    upperRow[upperRow.Length - i - 1] = array[array.Length - k + i];
            //    lowerRow[2 * i] = array[2 * i + k];
            //    lowerRow[2 * i + 1] = array[2 * i + k + 1];
            //}

            //int[] result = new int[k * 2];

            //for (int i = 0; i < result.Length; i++)
            //{
            //    result[i] = upperRow[i] + lowerRow[i];
            //}

            //Console.WriteLine(string.Join(" ", result));
            string[] arr = { "one", "two", "three", "four", "five" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {i}", i, arr[i]);
            }
            }
        }
}
