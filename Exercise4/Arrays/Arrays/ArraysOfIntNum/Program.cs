using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfIntNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            for (int i = arr.Lenght; i >0; i--)
            {
                int result = arr[i];
                Console.Write(result+" ");
            }
        }
    }
}
