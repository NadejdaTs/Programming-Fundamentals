using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.ArrayManipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var commands = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<int>();
            int test;

            do
            {
                if (commands[0] == "add")
                {
                    AddElements(numbers, commands);
                }
                if (commands[0] == "addMany")
                {
                    AddManyElements(numbers, commands);
                }
                if (commands[0] == "contains")
                {
                    test = Contains(numbers, commands[1]);
                    result.Add(test);
                }
                if (commands[0] == "remove")
                {
                    RemoveIndex(numbers, commands[1]);
                }
                if (commands[0] == "shift")
                {
                    RotateList(numbers, commands);
                }
                if (commands[0] == "sumPairs")
                {
                    numbers = SumOfPairs(numbers);
                }

                commands = Console.ReadLine()
                .Split(' ')
                .ToList();

            } while (commands[0] != "print");

            Console.WriteLine(string.Join(Environment.NewLine, result));           
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static List<int> SumOfPairs(List<int> numbers)
        {
            var sum = new List<int>();               
            for (int i = 0; i <= numbers.Count; i++)
            {                                        
                if (numbers.Count > 1)
                {
                    sum.Add(numbers[0] + numbers[1]);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0); 
                }
                else if (numbers.Count == 1)
                {
                    sum.Add(numbers[0]);
                }                    
            }
            numbers = sum;
            return numbers;
        }

        private static void RotateList(List<int> numbers, List<string> commands)
        {
            var indexToRemove = int.Parse(commands[1]);
            var numbersLength = numbers.Count;
            for (int i = 0; i < indexToRemove; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        private static void RemoveIndex(List<int> numbers, string commands)
        {
            numbers.RemoveAt(int.Parse(commands));
        }

        private static int Contains(List<int> numbers, string commands)
        {
            int result = -1;
            if (numbers.Contains(int.Parse(commands)))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (int.Parse(commands) == numbers[i])
                    {
                        result=i;
                    }
                }
            }
            return result;
        }

        private static void AddManyElements(List<int> numbers, List<string> commands)
        {
            int index = int.Parse(commands[1]);
            for (int i = 2; i < commands.Count; i++)
            {
                int element = int.Parse(commands[i]);
                numbers.Insert(index, element);
                index += 1; 
            }
        }

        private static void AddElements(List<int> numbers,List<string> commands)
        {
            int index = int.Parse(commands[1]);
            int element = int.Parse(commands[2]);
            numbers.Insert(index, element);
        }
    }
}
