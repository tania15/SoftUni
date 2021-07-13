using System;
using System.Linq;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //List<IId> citizensAndRobots = new List<IId>();

            //while (input != "End")
            //{
            //    string[] arriver = input.Split();

            //    if (arriver.Length == 2)
            //    {
            //        citizensAndRobots.Add(new Robot(arriver[0], arriver[1]));
            //    }
            //    else
            //    {
            //        citizensAndRobots.Add(new Citizen(arriver[0], int.Parse(arriver[1]), arriver[2]));
            //    }

            //    input = Console.ReadLine();
            //}

            //int fakeNumber = int.Parse(Console.ReadLine());

            ////foreach (var c in citizensAndRobots)
            ////{
            ////    if (c.Id.EndsWith(fakeNumber.ToString()))
            ////    {
            ////        Console.WriteLine(c.Id);
            ////    }
            ////}
            //citizensAndRobots.Where(c => c.Id.EndsWith(fakeNumber.ToString())).ToList().ForEach(c => Console.WriteLine(c.Id));


            // task 2
            //string input = Console.ReadLine();
            //List<IBirthdate> citizensAndPets = new List<IBirthdate>();

            //while (input != "End")
            //{
            //    string[] data = input.Split();

            //    if (data[0] == "Pet")
            //    {
            //        citizensAndPets.Add(new Pet(data[1], data[2]));
            //    }
            //    else if (data[0] == "Citizen")
            //    {
            //        citizensAndPets.Add(new Citizen(data[1], int.Parse(data[2]), data[3], data[4]));
            //    }

            //    input = Console.ReadLine();
            //}

            //int year = int.Parse(Console.ReadLine());

            //citizensAndPets.Where(c => c.Birthdate.EndsWith(year.ToString())).ToList().ForEach(c => Console.WriteLine(c.Birthdate));


            // task 3
            int num = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < num; i++)
            {
                string[] person = Console.ReadLine().Split();

                if (person.Length == 3)
                {
                    buyers.Add(new Rebel(person[0], int.Parse(person[1]), person[2]));
                }
                else
                {
                    buyers.Add(new Citizen(person[0], int.Parse(person[1]), person[2], person[3]));
                }
            }

            string name = Console.ReadLine();

            while (name != "End")
            {
                buyers.Where(b => (b.GetType().Name == "Rebel" && (b as Rebel).Name == name) || (b.GetType().Name == "Citizen" && (b as Citizen).Name == name))
                    .ToList()
                    .ForEach(b => b.BuyFood());  

                //foreach (var b in buyers)
                //{
                //    if (b.GetType == )
                //    {

                //    }
                //}

                name = Console.ReadLine();
            }

            int sum = 0;

            foreach (var b in buyers)
            {
                if (b.GetType().Name == "Rebel")
                {
                    sum += (b as Rebel).Food;
                }
                else
                {
                    sum += (b as Citizen).Food;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
