using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCompany = int.Parse(Console.ReadLine());
            int maxPassingers = 0;
            string company = string.Empty;

            for (int i = 1; i <= countCompany; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine();
                int sum = 0;
                int count = 0;

                while (command != "Finish")
                {
                    int countPassengers = int.Parse(command);
                    sum += countPassengers;
                    count++;

                    command = Console.ReadLine();
                }

                int passengers = (int) Math.Floor(sum * 1.0 / count);
                if (passengers > maxPassingers)
                {
                    maxPassingers = passengers;
                    company = name;
                }

                Console.WriteLine($"{name}: {passengers} passengers.");
            }

            Console.WriteLine($"{company} has most passengers per flight: {maxPassingers}");
        }
    }
}
