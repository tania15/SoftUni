using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MaxLength = 15;
        private const int MaxToppingsCount = 10;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and {MaxLength} symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }

        public int CountOfToppings => this.toppings.Count;

        public double TotalCalories => CalculateTotalCalories();

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == MaxToppingsCount)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
            }

            this.toppings.Add(topping);
        }

        private double CalculateTotalCalories()
        {
            double result = this.Dough.TotalCalories;

            foreach (Topping topping in toppings)
            {
                result += topping.TotalCalories;
            }

            return result;
        }
    }
}
