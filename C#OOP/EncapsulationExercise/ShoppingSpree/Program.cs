using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] people = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Person> buyers = new List<Person>();

                foreach (string p in people)
                {
                    string[] person = p.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    buyers.Add(new Person(person[0], decimal.Parse(person[1])));
                }

                string[] inputProducts = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();

                foreach (string p in inputProducts)
                {
                    string[] product = p.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    products.Add(new Product(product[0], decimal.Parse(product[1])));
                }


                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] purchase = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = purchase[0];
                    string productName = purchase[1];

                    if (products.Where(p => p.Name == productName).Count() > 0)
                    {
                        buyers.Where(b => b.Name == personName).First().AddProduct(productName, products);
                    }

                    input = Console.ReadLine();
                }

                foreach (Person b in buyers)
                {
                    Console.Write(b.Name + " - ");

                    if (b.Bag.Count == 0)
                    {
                        Console.Write("Nothing bought");
                    }
                    else
                    {
                        for (int i = 0; i < b.Bag.Count; i++)
                        {
                            if (i == b.Bag.Count - 1)
                            {
                                Console.Write(b.Bag[i].Name);
                            }
                            else
                            {
                                Console.Write(b.Bag[i].Name + ", ");

                            }
                        }

                        //foreach (Product p in b.Bag)
                        //{
                        //    Console.Write(p.Name + ", ");
                        //}
                    }

                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
