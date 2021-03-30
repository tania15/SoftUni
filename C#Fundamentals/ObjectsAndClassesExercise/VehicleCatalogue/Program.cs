using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            while (input != "End")
            {
                string[] vehicle = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (vehicle[0] == "truck")
                {
                    trucks.Add(new Vehicle(vehicle[1], vehicle[2], int.Parse(vehicle[3])));
                }
                else
                {
                    cars.Add(new Vehicle(vehicle[1], vehicle[2], int.Parse(vehicle[3])));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                if (cars.Select(c => c.Model).Contains(input))
                {
                    //Vehicle car = cars.Where(c => c.Model == input).First();

                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {input}");
                    Console.WriteLine($"Color: {cars.Where(c => c.Model == input).Select(c => c.Color).FirstOrDefault()}");
                    Console.WriteLine($"Horsepower: {cars.Where(c => c.Model == input).Select(c => c.HorsePower).First()}");
                }
                else
                {
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {input}");
                    Console.WriteLine($"Color: {trucks.Where(c => c.Model == input).Select(c => c.Color).First()}");
                    Console.WriteLine($"Horsepower: {trucks.Where(c => c.Model == input).Select(c => c.HorsePower).First()}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cars have average horsepower of: {cars.Select(c => c.HorsePower).Average() :F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucks.Select(c => c.HorsePower).Average() :F2}.");
        }
    }
}
