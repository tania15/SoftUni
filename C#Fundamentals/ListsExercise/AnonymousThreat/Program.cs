using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArg = command.Split();

                if (commandArg[0] == "merge")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex > text.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (endIndex > text.Count)
                    {
                        endIndex = text.Count - 1;
                    }

                    string resultElement = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        resultElement += text[i];
                    }

                    text[startIndex] = resultElement;                    
                    
                    text.RemoveRange(startIndex + 1, endIndex - startIndex);                                        
                }
                else if (commandArg[0] == "divide")
                {
                    if (int.Parse(commandArg[1]) > text.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    int length = text[int.Parse(commandArg[1])].Length / int.Parse(commandArg[2]);

                    string element = text[int.Parse(commandArg[1])];
                    text.RemoveAt(text.Count - 1);

                    while (element.Length >= length)
                    {
                        string add = string.Empty;

                        for (int i = 0; i < length; i++)
                        {
                            add += element[0];
                            element = element.Substring(1);
                        }

                        text.Add(add);
                    }

                    if (element.Length > 0)
                    {
                        text.Add(element);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', text));
        }

    }
}
