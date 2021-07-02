using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel => Ingredients.Sum(x => x.Alcohol);

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        public void Add(Ingredient ingredient)
        {
            //if (!Ingredients.Contains(ingredient) &&
            //    Ingredients.Select(i => i.Quantity).Sum() <= Capacity &&
            //    Ingredients.Count + 1 <= MaxAlcoholLevel)

            //if (Ingredients.Count() == 0)
            //{
            //    Ingredients = new List<Ingredient>();
            //}

            if (Ingredients.Where(i => i.Name == ingredient.Name).Count() == 0 && Ingredients.Count() < Capacity)
            {   
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            int count = Ingredients.Where(n => n.Name == name).Count();

            if (count > 0)
            {
                Ingredients.Remove(Ingredients.First(n => n.Name == name));
                return true;
            }

            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            if (Ingredients.Where(i => i.Name == name).Count() > 0)
            {
                return Ingredients.Where(i => i.Name == name).First();
            }

            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            //int max = Ingredients.Select(i => i.Alcohol).Max();
            //return Ingredients.Where(i => i.Alcohol == max).First();

            Ingredient max = Ingredients.OrderByDescending(x => x.Alcohol).First();
            return max;
        }

        //public int CurrentAlcoholLevel()
        //{
        //    //return Ingredients.Select(i => i.Quantity).Sum();
        //    return Ingredients.Sum(alcohol => alcohol.Alcohol);
        //}

        public string Report()
        {
            //return $"Cocktail: {Name} - Current Alcohol Level: {Ingredients.Count()}\n{string.Join(Environment.NewLine, Ingredients)}";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var i in Ingredients)
            {
                sb.AppendLine(i.ToString());
            }

            return sb.ToString();
        }
    }
}
