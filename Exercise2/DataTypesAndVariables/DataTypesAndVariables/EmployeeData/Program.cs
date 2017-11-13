using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = System.Console.ReadLine(); ;
            string lastName = System.Console.ReadLine(); ;
            byte age = byte.Parse(System.Console.ReadLine());
            char gender = char.Parse(System.Console.ReadLine());
            long presonalID = long.Parse(System.Console.ReadLine());
            int uniqueNum = int.Parse(System.Console.ReadLine());
            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+presonalID);
            Console.WriteLine("Unique Employee number: "+ uniqueNum);
        }
    }
}
