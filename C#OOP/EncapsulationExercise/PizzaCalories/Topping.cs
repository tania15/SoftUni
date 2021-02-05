using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCaloriesPerGram = 2.0;
        private double MinGrams = 1;
        private double MaxGrams = 50;

        private readonly Dictionary<string, double> DefaulTypeTopping = new Dictionary<string, double>
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (!this.DefaulTypeTopping.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [{MinGrams}..{MaxGrams}].");
                }
                weight = value;
            }
        }

        public double CaloriesPerGram => baseCaloriesPerGram * this.DefaulTypeTopping[this.Type.ToLower()];

        public double TotalCalories => this.CaloriesPerGram * this.Weight;
    }
}
