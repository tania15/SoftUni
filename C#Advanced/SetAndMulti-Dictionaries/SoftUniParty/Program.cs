using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "party")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input.ToLower() != "end")
            {
                vip.Remove(input);
                regular.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var v in vip)
            {
                Console.WriteLine(v);
            }

            foreach (var r in regular)
            {
                Console.WriteLine(r);
            }
        }
    }
}
