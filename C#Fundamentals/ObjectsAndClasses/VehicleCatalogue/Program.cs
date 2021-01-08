using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            string data = Console.ReadLine();

            while (data != "end")
            {
                string[] vechile = data.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (vechile[0] == "Truck")
                {
                    Truck truck = new Truck(vechile[1], vechile[2], int.Parse(vechile[3]));

                    int index = 0;

                    for (int i = 0; i < trucks.Count; i++)
                    {
                        if (vechile[1].CompareTo(trucks[i].Brand) < 0)
                        {
                            index = i;
                            break;
                        }

                        if (i == trucks.Count - 1)
                        {
                            index = trucks.Count;
                        }
                    }

                    trucks.Insert(index, truck);
                }
                else
                {
                    Car car = new Car(vechile[1], vechile[2], int.Parse(vechile[3]));

                    int index = 0;

                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (vechile[1].CompareTo(cars[i].Brand) < 0)
                        {
                            index = i;
                            break;
                        }

                        if (i == cars.Count - 1)
                        {
                            index = cars.Count;
                        }
                    }

                    cars.Insert(index, car);
                }

                data = Console.ReadLine();
            }

            Catalog catalog = new Catalog(trucks, cars);

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
