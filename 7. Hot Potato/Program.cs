﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
