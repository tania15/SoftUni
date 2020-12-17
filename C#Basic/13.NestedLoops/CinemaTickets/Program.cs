using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int countStudents = 0;
            int countStandart = 0;
            int countKids = 0;
            int totalTickets = 0;

            while (filmName != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                int count = 0;

                while (type != "End")
                {
                    count++;

                    if (type == "student")
                    {
                        countStudents++;
                    }
                    else if (type == "standard")
                    {
                        countStandart++;
                    }
                    else
                    {
                        countKids++;
                    }

                    if (count == seats)
                    {

                        break;
                    }

                    type = Console.ReadLine();
                }

                totalTickets += count;
                Console.WriteLine($"{filmName} - {100.0 / seats * count:F2}% full.");

                filmName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 / (countKids + countStandart + countStudents) * countStudents:F2}% student tickets.");
            Console.WriteLine($"{100.0 / (countKids + countStandart + countStudents) * countStandart:F2}% standard tickets.");
            Console.WriteLine($"{100.0 / (countKids + countStandart + countStudents) * countKids:F2}% kids tickets.");

        }
    }
}
