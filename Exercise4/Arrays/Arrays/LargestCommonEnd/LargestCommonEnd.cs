using System;
using System.Linq;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            int maxCountLeft = ScanFromLeft(firstArray, secondArray);
            int maxCountRight = ScanFromRightFindLength(firstArray, secondArray);

            if (maxCountLeft == 0 && maxCountRight == 0)
            {
                Console.WriteLine(0);
            }
            else if (maxCountLeft > maxCountRight)
            {
                Console.WriteLine(maxCountLeft);
            }
            else
            {
                Console.WriteLine(maxCountRight);
            }
        }

        public static int ScanFromLeft(string[] firstArray, string[] secondArray)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
            }
            return count;
        }

        public static int ScanFromRightFindLength(string[] firstArray, string[] secondArray)
        {
            var result = 0;
            if (firstArray.Length > secondArray.Length)
            {
                var shorterArray = secondArray;
                var longerArray = firstArray;
                result = ScanFromRight(shorterArray, longerArray);
            }
            else
            {
                var shorterArray = firstArray;
                var longerArray = secondArray;
                result = ScanFromRight(shorterArray, longerArray);
            }
            return result;
        }

        private static int ScanFromRight(string[] shorterArray, string[] longerArray)
        {
            int count = 0;
            int arrIndex = longerArray.Length - 1;
            for (int i = shorterArray.Length - 1; i >= 0; i--)
            {
                if (longerArray[arrIndex] == shorterArray[i])
                {
                    count++;
                }
                arrIndex--;
            }
            return count;
        }
    }
}
