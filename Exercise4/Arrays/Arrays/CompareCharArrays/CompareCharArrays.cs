using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(x => char.Parse(x)).ToArray();
            char[] secArray = Console.ReadLine().Split(' ').Select(x => char.Parse(x)).ToArray();

            //char[] result = CompareChar(firstArray, secArray);
            //Console.WriteLine(result);
            int firstLength = firstArray.Length - 1;
            int secLength = secArray.Length - 1;
            if (firstLength > secLength)
            {
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
            else if (firstLength < secLength)
            {
                for (int i = 0; i < firstLength; i++)
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
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secArray);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstLength; i++)
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
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secArray);
                        break;
                    }
                }
            }
        }
        //public static char[] CompareChar(char[] firstArray, char [] secArray, int longer)
        //{
        //    for (int i = 0; i < longer; i++)
        //    {
        //        if (firstArray[i] > secArray[i])
        //        {
        //            Console.WriteLine(secArray);
        //            Console.WriteLine(firstArray);
        //            break;
        //        }
        //        else if (firstArray[i] < secArray[i])
        //        {
        //            Console.WriteLine(firstArray);
        //            Console.WriteLine(secArray);
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine(secArray);
        //            Console.WriteLine(firstArray);
        //            break;
        //        }
        //    }
        //}
    }
}
