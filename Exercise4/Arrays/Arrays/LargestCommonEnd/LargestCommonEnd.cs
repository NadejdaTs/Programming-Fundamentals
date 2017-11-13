using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            int maxCountLeft = ScanFromLeft(firstArray, secondArray);
            int maxCountRight = ScanFromRight(firstArray, secondArray);

            if (maxCountLeft == 0 && maxCountRight == 0)
            {
                Console.WriteLine(0);
            }
            else if (maxCountLeft>maxCountRight)
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
            int minLength = Math.Min(firstArray.Length,secondArray.Length);
            int count = 0;
            int maxCount = 0;

            int secondArrLength = secondArray.Length;
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount<count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }
        public static int ScanFromRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;   
            if (firstArray.Length>secondArray.Length)
            {
                int arrIndex = firstArray.Length-1;
                for (int i = secondArray.Length - 1; i >= 0; i--)
                {
                    if (firstArray[arrIndex] == secondArray[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    arrIndex--;
                }
            }
            else
            {
                int arrIndex = secondArray.Length - 1;
                for (int i = firstArray.Length - 1; i >= 0; i--)
                {
                    if (secondArray[arrIndex] == firstArray[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    arrIndex--;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }
    }
}
