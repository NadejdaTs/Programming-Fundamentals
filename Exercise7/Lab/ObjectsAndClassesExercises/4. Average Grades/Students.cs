using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Students
    {
        public string Name { get; set; }
        public float[] Grades { get; set; }

        public float Average()
        {
            return Grades.Average();
        }
    }
}
