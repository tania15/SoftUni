﻿using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (password != input)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
