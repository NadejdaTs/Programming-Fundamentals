using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Remove_Negatives_and_Reverse
{
    class Lists
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Reverse();
            numbers.RemoveAll(i => i<0);
            bool isEmpty = !numbers.Any();
            if (isEmpty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
