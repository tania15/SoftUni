using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>(songs);
            string input = Console.ReadLine();

            while (queue.Count > 0)
            {
                if (input.ToLower() == "play")
                {
                    queue.Dequeue();
                }
                else if (input.ToLower() == "show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    int index = input.IndexOf(' ');
                    string song = input.Substring(index + 1, input.Length - index - 1);
                    
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
