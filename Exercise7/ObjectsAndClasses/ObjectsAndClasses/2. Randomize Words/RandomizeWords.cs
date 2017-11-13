using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class RandomizeWords
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();
            for (int i = 0; i < text.Count; i++)
            {
                int rndIndex = rnd.Next(0,text.Count);
                var tempWord = text[rndIndex];
            }
            Console.WriteLine(String.Join(Environment.NewLine, result));
        }
    }
}
