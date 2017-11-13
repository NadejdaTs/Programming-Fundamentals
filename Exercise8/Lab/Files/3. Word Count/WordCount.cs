using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class WordCount
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var text = File.ReadAllText("text.txt")
                .Split(new[] { '.',',','!','?','`','\n','\r','-','/'})
                .Select(w => w.ToLower())
                .Distinct()
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
            }
            
        }
    }
}
