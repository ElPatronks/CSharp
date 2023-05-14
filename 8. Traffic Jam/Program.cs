using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Any())
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
