using System;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ');

            int result = GetResult(text[0], text[1]);
            Console.WriteLine(result);
        }

        public static int GetResult(string str1, string str2)
        {
            var multiply = 0;
            int sum = 0;

            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < minLen; i++)
            {
                var currStr1 = Convert.ToInt32(str1[i]);
                var currStr2 = Convert.ToInt32(str2[i]);
                multiply = currStr1 * currStr2;
                sum += multiply;
            }

            if (str1.Length != str2.Length)
            {
                string longerStr = str1.Length > str2.Length ? longerStr = str1 : longerStr = str2;

                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerStr[i];
                }
                return sum;
            }
            else
            {
                return sum;
            }
        }
    }
}
