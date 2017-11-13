using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class test
    {
        static void Main()
        {
            if (!File.Exists("myfile.txt"))
            {
                File.Create("myfile.txt");
            }
            var file = File.ReadAllText("myfile.txt");
            Console.WriteLine(file);
        }
    }
}
