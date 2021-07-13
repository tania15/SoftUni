using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] citizen = input.Split();
                Citizen c = new Citizen(citizen[0], citizen[1], int.Parse(citizen[2]));

                Console.WriteLine((c as IPerson).GetName());
                Console.WriteLine((c as IResident).GetName());

                input = Console.ReadLine();
            }
        }
    }
}
