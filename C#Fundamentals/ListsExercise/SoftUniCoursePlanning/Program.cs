using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandArg = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (commandArg[0] == "Add")
                {
                    if (!lessons.Contains(commandArg[1]))
                    {
                        lessons.Add(commandArg[1]);
                    }
                }
                else if (commandArg[0] == "Insert")
                {
                    if (!lessons.Contains(commandArg[1]))
                    {
                        lessons.Insert(int.Parse(commandArg[2]), commandArg[1]);
                    }
                }
                else if (commandArg[0] == "Remove")
                {
                    lessons.Remove(commandArg[1]);

                    if (lessons.Contains(commandArg[1] + ":Exercise"))
                    {
                        lessons.Remove(commandArg[1] + ":Exercise");
                    }
                }
                else if (commandArg[0] == "Swap")
                {
                    if (lessons.Contains(commandArg[1]) && lessons.Contains(commandArg[2]))
                    {
                        int index = lessons.IndexOf(commandArg[2]);
                        lessons[lessons.IndexOf(commandArg[1])] = lessons[lessons.IndexOf(commandArg[2])];
                        lessons[index] = commandArg[1];

                        if (lessons.Contains(commandArg[1] + "-Exercise"))
                        {
                            lessons.Remove(commandArg[1] + "-Exercise");
                            lessons.Insert(lessons.IndexOf(commandArg[1]) + 1, commandArg[1] + "-Exercise");
                        }

                        if (lessons.Contains(commandArg[2] + "-Exercise"))
                        {
                            lessons.Remove(commandArg[2] + "-Exercise");
                            lessons.Insert(lessons.IndexOf(commandArg[2]) + 1, commandArg[2] + "-Exercise");
                        }
                    }
                }
                else if (commandArg[0] == "Exercise")
                {
                    if (lessons.Contains(commandArg[1]) && !(lessons.Contains(commandArg[1] + "-Exercise")))
                    {
                        int indexLesson = lessons.IndexOf(commandArg[1]);
                        lessons.Insert(indexLesson + 1, commandArg[1] + '-' + commandArg[0]);
                    }
                    else
                    {
                        lessons.Add(commandArg[1]);
                        lessons.Add(commandArg[1] + '-' + commandArg[0]);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
