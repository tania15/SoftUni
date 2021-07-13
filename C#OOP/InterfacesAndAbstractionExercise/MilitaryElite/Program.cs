using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IPrivate> privates = new List<IPrivate>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string soldierType = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];

                switch (soldierType)
                {
                    case "Private":
                        decimal salary = decimal.Parse(tokens[4]);
                        IPrivate privateSoldier = new Private(id, firstName, lastName, salary);
                        privates.Add(privateSoldier);
                        break;
                    case "LieutenantGeneral":
                        ILieutenantGeneral soldier = new LieutenantGeneral(id, firstName, lastName, decimal.Parse(tokens[4]));
                        privates.Add(soldier);
                        break;
                    case "Engineer":
                        Engineer soldier = new Engineer(id, firstName, lastName, decimal.Parse(tokens[4]), Corps.Parse(tokens[5]));
                        break;
                }

                Console.WriteLine(soldier);
                input = Console.ReadLine();
            }
        }
    }
}
