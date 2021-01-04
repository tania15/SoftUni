using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>(n);
            int counter = 1;

            while (counter <= n)
            {
                string[] message = Console.ReadLine().Split();

                if (message.Length == 3)
                {
                    if (names.Contains(message[0]) == false)
                    {
                        names.Add(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is already in the list!");
                    }
                }
                else
                {
                    if (names.Contains(message[0]) == true)
                    {
                        names.Remove(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is not in the list!");
                    }                    
                }

                counter++;
            }

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
