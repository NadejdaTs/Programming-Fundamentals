using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        //char search = 'р';
        bool hasMatch = false;

        for (int i = 0; i < text.Length-1; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = 1 + jump;
                string matchedString;
                if (i + endIndex <= text.Length)
                {
                    matchedString = text.Substring(i, endIndex);
                }
                else
                {
                    matchedString = text.Substring(i);
                }
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
