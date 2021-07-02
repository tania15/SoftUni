using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] threadsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int task = int.Parse(Console.ReadLine());
            Stack<int> tasks = new Stack<int>(tasksArray);
            Queue<int> threads = new Queue<int>(threadsArray);

            while (tasks.Count > 0 && threads.Count > 0)
            {
                int currentTask = tasks.Peek();
                int currentThreads = threads.Peek();

                if (currentTask == task)
                {
                    break;
                }

                if (currentThreads >= currentTask)
                {
                    tasks.Pop();                    
                }

                threads.Dequeue();
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {task}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
