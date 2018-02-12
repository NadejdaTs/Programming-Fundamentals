using System;
using System.Linq;

namespace _5.Bomb_Numbers
{
    class BombNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();                      // 1 2 2 4 2 2 2 9

            var bombNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();                      // 4 2   ->12

            var bomb = bombNum[0];
            var power = bombNum[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomb == numbers[i])
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, numbers.Count - 1);
                    numbers.RemoveRange(i, right - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(left, i - left);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
