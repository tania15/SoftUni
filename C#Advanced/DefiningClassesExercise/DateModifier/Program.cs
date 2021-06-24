using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDays(date1, date2));
        }
    }
}
