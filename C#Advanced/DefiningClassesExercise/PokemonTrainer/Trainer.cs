using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, int n, List<Pokemon> pokemons)
        {
            Name = name;
            NumberOfBadges = n;
            Pokemons = new List<Pokemon>(pokemons);
        }

        public void CheckPokemons()
        {
            if (Pokemons.Count > 0)
            {
                Pokemons.RemoveAll(p => p.Health <= 0);
            }
        }

        public void DecreaseHealth()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemons[i].Health -= 10;
            }
        }
    }
}
