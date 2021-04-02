using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Move":
                        string characters = message.Substring(0, int.Parse(command[1]));
                        message = message
                            .Insert(message.Length, characters)
                            .Remove(0, int.Parse(command[1]));
                        break;
                    case "Insert":
                        message = message
                            .Insert(int.Parse(command[1]), command[2]);
                        break;
                    case "ChangeAll":
                        while(message.Contains(command[1]))
                        {
                            message = message.Replace(command[1], command[2]);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
