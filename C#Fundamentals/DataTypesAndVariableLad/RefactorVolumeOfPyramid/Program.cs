using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double dul, sh, v = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            v = double.Parse(Console.ReadLine());
            double x = (dul * sh * v) / 3;
            Console.Write($"Pyramid Volume: {x:f2}");
        }
    }
}
