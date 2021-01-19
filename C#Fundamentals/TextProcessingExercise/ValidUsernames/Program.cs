using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isValidName = true;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsLetterOrDigit(name[i]) != true && name[i] != '-' && name[i] != '_')
                        {
                            isValidName = false;
                            break;
                        }
                    }

                    if (isValidName)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
