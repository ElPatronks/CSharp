using System;
using System.Collections;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue queue = new Queue();


            while (queue.Count >= 0)
            {
                queue.Enqueue(input);

                input = Console.ReadLine();

                if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                    input = Console.ReadLine(); 
                }
                else if (input == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
            }
            
        }
    }
}
