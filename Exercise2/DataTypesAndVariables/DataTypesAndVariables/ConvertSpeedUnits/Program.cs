using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(System.Console.ReadLine());
            decimal b = decimal.Parse(System.Console.ReadLine());
            decimal perimeter = (a + b)*2;
            decimal area = a*b;
            decimal diagonal = Math.Sqrt(a,b);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);//ot flashkata
        }
    }
}
