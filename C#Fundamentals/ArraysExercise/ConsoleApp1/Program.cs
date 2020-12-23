using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] positions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] ladybugs = new int[n];

            for (int i = 0; i < positions.Length; i++)
            {
                ladybugs[positions[i]] = 1;
            }

            int ladybugIndex = 0;
            char direction;
            int step = 0;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                ladybugIndex = (int)char.GetNumericValue(command[0]);
                direction = command[2];

                if (command[command.Length - 2] == ' ')
                {
                    step = (int)char.GetNumericValue(command[command.Length - 1]);
                }
                else
                {
                    step = int.Parse(command.Substring(command.Length - 2));
                }

                ladybugs[ladybugIndex] = 0;

                if (direction == 'r')
                {
                    if (ladybugIndex + step < n)
                    {
                        if (ladybugs[ladybugIndex + step] == 0)
                        {
                            ladybugs[ladybugIndex + step] = 1;
                        }
                        else
                        {
                            int p = 1;
                            while (ladybugIndex + step + p < n && ladybugs[ladybugIndex + step + p] == 1)
                            {                                
                                p++;
                            }

                            if (ladybugIndex + step + p < n)                             
                            {
                                ladybugs[ladybugIndex + step + p] = 1;
                            }
                        }

                    }
                }
                else
                {
                    if (ladybugIndex - step >= 0)
                    {
                        if (ladybugs[ladybugIndex - step] == 0)
                        {
                            ladybugs[ladybugIndex - step] = 1;
                        }
                        else
                        {
                            int p = 1;
                            while (ladybugIndex - step - p >= n && ladybugs[ladybugIndex - step - p] == 1)
                            {
                                p++;
                            }

                            if (ladybugIndex - step - p >= 0)                             
                            {
                                ladybugs[ladybugIndex - step - p] = 1;
                            }
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(' ', ladybugs));
        }
    }
}
