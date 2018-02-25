using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine(); ;
            string lastName = Console.ReadLine(); ;
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long presonalID = long.Parse(Console.ReadLine());
            int uniqueNum = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+presonalID);
            Console.WriteLine("Unique Employee number: "+ uniqueNum);
        }
    }
}
