using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] levelsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> levels = new Stack<int>(levelsArray);
            Queue<int> ingredients = new Queue<int>(ingredientsArray);
            Dictionary<string, int> dishes = new Dictionary<string, int> 
            {
                { "Dipping sauce", 150 },
                { "Green salad", 250 },
                {"Chocolate cake", 300 },
                {"Lobster", 400 }
            };

            Dictionary<string, int> madeDishes = new Dictionary<string, int>();


            while (levels.Count > 0 && ingredients.Count > 0)
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int totalFreshnessLevel = levels.Peek() * ingredients.Peek();                

                if (dishes.ContainsValue(totalFreshnessLevel))
                {                    
                    string dish = dishes.Where(d => d.Value == totalFreshnessLevel).First().Key;            

                    if (madeDishes.ContainsKey(dish))
                    {
                        madeDishes[dish]++;
                    }
                    else
                    {
                        madeDishes.Add(dish, 1);
                    }

                    ingredients.Dequeue();
                }
                else
                {
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }

                levels.Pop();                
            }

            if (madeDishes.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var m in madeDishes.OrderBy(k => k.Key))
            {
                Console.WriteLine($"# {m.Key} --> {m.Value}");
            }
        }
    }
}
