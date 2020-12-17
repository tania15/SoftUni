using System;

namespace Godzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueOfFilm = double.Parse(Console.ReadLine());
            int countActor = int.Parse(Console.ReadLine());
            double prise = double.Parse(Console.ReadLine());

            double costs = valueOfFilm * 10 / 100;

            if (countActor > 150)
            {
               costs += ((countActor * prise) - (countActor * prise * 10 / 100));
            }
            else
            {
                costs += (countActor * prise);
            }

            if (costs > valueOfFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs - valueOfFilm:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {valueOfFilm - costs:F2} leva left.");
            }
        }
    }
}
