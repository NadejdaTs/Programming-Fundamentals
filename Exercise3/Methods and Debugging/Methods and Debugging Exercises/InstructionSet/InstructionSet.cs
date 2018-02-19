﻿using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine();
        long result = 1L;

        while (opCode.Substring(0, 3) != "END")
        {
            string[] codeArgs = opCode.Split(' ');
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result += operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne -1;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            opCode = Console.ReadLine();
        }
        Console.WriteLine(result);
    }
}
