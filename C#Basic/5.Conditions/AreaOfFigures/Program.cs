using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side*side:F3}");
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine()); 
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side1 * side2:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{radius*radius*Math.PI:F3}");
            }
            else
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side*height/2:F3}");
            }
        }
    }
}
