using System;
using System.Linq;
using System.Collections.Generic;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    int wagon = lift[i];                   

                    lift[i] = (people > 4 - lift[i] ? 4 : lift[i] + people);
                    people = (people > 4 - wagon ? people - (4 - wagon) : 0);
                }

                if (people == 0)
                {
                    if (lift[i] < 4)
                    {
                        Console.WriteLine("The lift has empty spots!");
                    }
                   
                    break;
                }

                if (i == lift.Length - 1 && lift[i] == 4)
                {
                    Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                }
            }            

            Console.WriteLine(string.Join(' ', lift));
        
        }
    }
}
