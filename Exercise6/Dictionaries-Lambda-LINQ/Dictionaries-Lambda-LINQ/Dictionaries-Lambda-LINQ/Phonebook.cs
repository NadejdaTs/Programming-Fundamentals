using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Lambda_LINQ
{
    class Program
    {
        static void Main()
        {
            var commands = Console.ReadLine()
                .ToUpper()
                .Split()
                .ToList();

            var phonebook = new Dictionary<string, string>();

            var command = commands[0];
            var name = commands[1];
            var phone = commands[2];

            while (command != "END")
            {
                if (command == "A")
                {
                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");                        
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }
        }
    }
}
