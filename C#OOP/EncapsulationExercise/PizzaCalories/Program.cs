using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split(" ");

                Pizza pizza = new Pizza(pizzaName[1]);

                string[] doughType = Console.ReadLine().Split(" ");
                Dough dough = new Dough(doughType[1], doughType[2], double.Parse(doughType[3]));
                pizza.Dough = dough;

                string toppingInput = Console.ReadLine();


                while (toppingInput != "END")
                {
                    string[] topping = toppingInput.Split(" ");

                    Topping t = new Topping(topping[1], double.Parse(topping[2]));
                    pizza.AddTopping(t);

                    toppingInput = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }           
        }
    }
}
