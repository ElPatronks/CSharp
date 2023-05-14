using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> list = new List<int>();

            Queue<int> queue = new Queue<int>(array);

            for (int i = 0; i < queue.Count; i++)
            {
                int n = queue.Peek();

                if (n % 2 == 0)
                {
                    list.Add(n);
                }
                queue.Dequeue();
                i--;
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
