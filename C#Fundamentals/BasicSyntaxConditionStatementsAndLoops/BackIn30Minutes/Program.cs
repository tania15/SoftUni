using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes >= 30)
            {
                minutes -= 30;
                if (hours == 23)
                {
                    hours = 0;
                }
                else
                {
                    hours += 1;
                }
            }
            else
            {
                minutes += 30;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
