using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>(nums);

            var cmd = Console.ReadLine().ToLower();

            while (cmd != "end")
            {
                var splitted = cmd.Split(' ');

                if (splitted[0] == "add")
                {
                    int numbers1 = int.Parse(splitted[1]);
                    int numbers2 = int.Parse(splitted[2]);

                    stack.Push(numbers1);
                    stack.Push(numbers2);
                }

                if (splitted[0] == "remove")
                {
                    int n = int.Parse(splitted[1]);

                    if (stack.Count > n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                cmd = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
