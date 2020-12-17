using System;

namespace CatLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string cat = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());
            double mounts = 0.0;

            if (cat == "British Shorthair")
            {
                if (gender == 'm')
                {
                    mounts = 13 * 12 / 6;
                }
                else
                {
                    mounts = 14 * 12 / 6;
                }
            }
            else if (cat == "Siamese")
            {
                if (gender == 'm')
                {
                    mounts = 15 * 12 / 6;
                }
                else
                {
                    mounts = 16 * 12 / 6;
                }
            }
            else if (cat == "Persian")
            {
                if (gender == 'm')
                {
                    mounts = 14 * 12 / 6;
                }
                else
                {
                    mounts = 15 * 12 / 6;
                }
            }
            else if (cat == "Ragdoll")
            {
                if (gender == 'm')
                {
                    mounts = 16 * 12 / 6;
                }
                else
                {
                    mounts = 17 * 12 / 6;
                }
            }
            else if (cat == "American Shorthair")
            {
                if (gender == 'm')
                {
                    mounts = 12 * 12 / 6;
                }
                else
                {
                    mounts = 13 * 12 / 6;
                }
            }
            else if (cat == "Siberian")
            {
                if (gender == 'm')
                {
                    mounts = 11 * 12 / 6;
                }
                else
                {
                    mounts = 12 * 12 / 6;
                }
            }
            else
            {
                Console.WriteLine($"{cat} is invalid cat!");
            }

            if (mounts != 0.0)
            {
                Console.WriteLine($"{Math.Round(mounts)} cat months");
            }
        }

    }
}
