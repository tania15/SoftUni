using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)                
                .ToList();

            string input = Console.ReadLine();
            int successfulRemovers = 0;
            int turns = 1;

            while (input != "end")
            {
                int[] indexes = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (!(indexes[0] < elements.Count && indexes[0] >= 0) || !(indexes[1] < elements.Count && indexes[1] >= 0))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    elements.Insert(elements.Count / 2, "-" + successfulRemovers + "a");
                    elements.Insert(elements.Count / 2, "-" + successfulRemovers + "a");
                }
                else
                {
                    if (elements[indexes[0]] == elements[indexes[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[indexes[0]]}!");

                        if (indexes[0] < indexes[1])
                        {
                            elements.RemoveAt(indexes[1]);
                            elements.RemoveAt(indexes[0]);                            
                        }
                        else
                        {
                            elements.RemoveAt(indexes[0]);                            
                            elements.RemoveAt(indexes[1]);                            
                        }

                        successfulRemovers += 2;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {turns} turns!");
                        break;
                    }
                }

                turns++;
                input = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', elements));
            }
        }
    }
}
