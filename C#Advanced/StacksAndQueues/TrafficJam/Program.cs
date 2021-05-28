using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (command.ToLower() != "end")
            {
                if (command.ToLower() != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    int c = 0;

                    while (c < number && cars.Count > 0)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        c++;
                        count++;
                    }                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
