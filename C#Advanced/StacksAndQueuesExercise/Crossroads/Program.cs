using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                int secondsGreenLight = greenLight;
                int secondsFreeWindows = freeWindow;

                if (command.ToLower() == "green")
                {
                    while (secondsGreenLight > 0 && queue.Count > 0)
                    {
                        string car = queue.Dequeue();
                        secondsGreenLight -= car.Length;

                        if (secondsGreenLight > 0)
                        {
                            count++;
                        }
                        else
                        {
                            secondsFreeWindows += secondsGreenLight;
                            if (secondsFreeWindows < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[car.Length + secondsFreeWindows]}.");
                                return;
                            }

                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            if (command.ToLower() == "end")
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
        }
    }
}
