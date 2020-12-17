using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minOfArrival = int.Parse(Console.ReadLine());

            if (hourOfArrival > hourOfExam)
            {
                Console.WriteLine("Late");

                if (minOfArrival > minOfExam)
                {
                    Console.WriteLine($"{hourOfArrival - hourOfExam}:{minOfArrival - minOfExam:D2} hours after the start");
                }
                else
                {
                    if (hourOfArrival - hourOfExam - 1 == 0)
                    {
                        Console.WriteLine($"{minOfArrival + 60 - minOfExam} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourOfArrival - hourOfExam - 1}:{minOfArrival + 60 - minOfExam:D2} hours after the start");
                    }
                }
            }
            else if (hourOfArrival == hourOfExam)
            {
                if (minOfExam == minOfArrival)
                {
                    Console.WriteLine("On time");
                }
                else if (minOfArrival > minOfExam)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minOfArrival - minOfExam} minutes after the start");
                }
                else
                {
                    if (minOfExam - minOfArrival <= 30 && minOfExam - minOfArrival >= 0)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{minOfExam - minOfArrival} minutes before the start");
                    }
                    else if (minOfExam - minOfArrival > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minOfExam - minOfArrival} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{minOfArrival + 60 - minOfExam} minutes after the start");
                    }
                }
            }
            else
            {
                if (minOfArrival > minOfExam)
                {
                    if (hourOfExam - hourOfArrival - 1 == 0)
                    {
                        if (minOfExam + 60 - minOfArrival > 30)
                        {
                            Console.WriteLine("Early");
                        }
                        else
                        {
                            Console.WriteLine("On time");
                        }
                        Console.WriteLine($"{minOfExam + 60 - minOfArrival} minutes before the start");
                    }
                    else
                    {
                        
                        Console.WriteLine($"{hourOfExam - hourOfArrival - 1}:{minOfExam + 60 - minOfArrival:D2} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hourOfExam - hourOfArrival}:{minOfExam - minOfArrival:D2} hours before the start");
                }
            }

        }
    }
}

