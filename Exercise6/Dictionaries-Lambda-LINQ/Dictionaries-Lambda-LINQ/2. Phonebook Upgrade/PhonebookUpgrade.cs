﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            List<string> input = Console.ReadLine().Split().ToList();

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
                        if (input[0] == "ListAll")
                        {
                            Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}