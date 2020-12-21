using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            int count = 0;
            string password = string.Empty;
            string reversePass = string.Empty;

            do
            {
                password = Console.ReadLine();
                reversePass = string.Empty;

                for (int i = password.Length - 1; i >= 0; i--)
                {
                    reversePass += password[i];
                }
                
                if (reversePass != user)
                {
                    if (count == 3)
                    {
                        Console.WriteLine($"User {user} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }

                count++;
            } while (count < 4 && reversePass != password);

            //if (count >= 4)
            //{
            //    Console.WriteLine($"User {user} blocked!");
            //}
        }
    }
}
