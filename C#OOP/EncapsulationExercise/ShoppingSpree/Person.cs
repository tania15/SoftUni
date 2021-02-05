using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;              // list of string for name of product

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Bag
        {
            get
            {
                return bag;
            }            
        }

        public void AddProduct(string productName, List<Product> products)
        {
            if (products.Where(p => p.Name == productName).Count() > 0)
            {
                decimal price = products.Where(p => p.Name == productName).First().Price;
                Product p = new Product(productName, price);

                if (this.Money - price < 0)
                {
                    Console.WriteLine($"{this.Name} can't afford {productName}");
                }
                else
                {
                    this.Bag.Add(p);
                    this.Money -= p.Price;
                    Console.WriteLine($"{this.Name} bought {productName}");
                }
            }
        }

    }
}
