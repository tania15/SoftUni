using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car.Car car = new Car.Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;

            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");


            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());

        }
    }
}
