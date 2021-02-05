using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2.0;
        private double MinGrams = 1;
        private double MaxGrams = 200;

        private readonly Dictionary<string, double> DefautFlourTypes = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1}
        };

        private readonly Dictionary<string, double> DefautBakingTechnique = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private string flourType;
        private string backingTechnique;
        private double grams;

        public Dough(string flourType, string backingTechnique, double grams)
        {
            FlourType = flourType;
            BackingTechnique = backingTechnique;
            Grams = grams;
        }
        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (!DefautFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }
        public string BackingTechnique
        {
            get
            {
                return backingTechnique;
            }
            private set
            {
                if (!DefautBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                backingTechnique = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinGrams}..{MaxGrams}].");
                }

                this.grams = value;
            }
        }

        public double CaloriesPerGram => BaseCaloriesPerGram * this.DefautFlourTypes[this.FlourType.ToLower()] * this.DefautBakingTechnique[this.BackingTechnique.ToLower()];
        //{
        //    get 
        //    {
        //        return BaseCaloriesPerGram* this.DefautFlourTypes[this.FlourType] * this.DefautBakingTechnique[this.BackingTechnique];
        //    }
        //}

        public double TotalCalories => this.CaloriesPerGram * this.Grams;
    }
}
