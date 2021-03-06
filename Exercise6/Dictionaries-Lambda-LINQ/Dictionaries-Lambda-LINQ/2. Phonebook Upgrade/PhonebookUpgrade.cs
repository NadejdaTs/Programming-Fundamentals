﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToList();

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}",item.Key, item.Value);
                    }
                }

                    input = Console.ReadLine()
                    .Split()
                    .ToList();
            }
        }
    }
}