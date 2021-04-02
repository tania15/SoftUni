using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] command = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Contains":
                        if (key.Contains(command[1]))
                        {
                            Console.WriteLine($"{key} contains {command[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string subStr = key.Substring(int.Parse(command[2]), int.Parse(command[3]) - int.Parse(command[2]));
                        
                        if (command[1] == "Upper")
                        {
                            subStr = subStr.ToUpper();
                        }
                        else
                        {
                            subStr = subStr.ToLower();
                        }

                        key = key.Remove(int.Parse(command[2]), int.Parse(command[3]) - int.Parse(command[2]));
                        key = key.Insert(int.Parse(command[2]), subStr);                       

                            Console.WriteLine(key);
                        break;
                    case "Slice":
                        key = key.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]));

                        Console.WriteLine(key);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
