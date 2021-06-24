using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (command.ToLower() != "tournament")
            {
                string[] trainer = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (trainers.Where(t => t.Name == trainer[0]).Count() > 0)
                {
                    trainers.Where(t => t.Name == trainer[0]).First().Pokemons.Add(new Pokemon(trainer[1], trainer[2], int.Parse(trainer[3])));
                }
                else
                {
                    List<Pokemon> pokemons = new List<Pokemon>();
                    pokemons.Add(new Pokemon(trainer[1], trainer[2], int.Parse(trainer[3])));
                    trainers.Add(new Trainer(trainer[0], 0, pokemons));
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                foreach (var t in trainers)
                {
                    if (t.Pokemons.Where(p => p.Element == command).Count() > 0)
                    {
                        t.NumberOfBadges++;
                    }
                    else
                    {
                        t.DecreaseHealth();
                        t.CheckPokemons();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var t in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count()}");
            }
        }
    }
}
