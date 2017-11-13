using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory
{
    class Dir
    {
        static void Main()
        {
            var dir = new Directory.GetCurrentDirectory();
            var dirInfo = new DirectoryInfo(dir);
        }
    }
}
