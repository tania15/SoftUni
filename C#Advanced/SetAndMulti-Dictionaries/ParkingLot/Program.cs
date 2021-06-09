using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (input.ToLower() != "end")
            {
                string[] car = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (car[0].ToLower() == "in")
                {
                    cars.Add(car[1]);
                }
                else
                {
                    cars.Remove(car[1]);
                }

                input = Console.ReadLine();
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string c in cars)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
