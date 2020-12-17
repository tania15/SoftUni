using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");                
            }
            else
            {
                double result;
                string typeNumber = string.Empty;

                if (operation == '+')
                {
                    result = n1 + n2;

                    if (result % 2 == 0)
                    {
                        typeNumber = "even";
                    }
                    else
                    {
                        typeNumber = "odd";
                    }

                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeNumber}");
                }
                else if (operation == '-')
                {
                    result = n1 - n2;
                    
                    if (result % 2 == 0)
                    {
                        typeNumber = "even";
                    }
                    else
                    {
                        typeNumber = "odd";
                    }

                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeNumber}");
                }
                else if (operation == '*')
                {
                    result = n1 * n2;

                    if (result % 2 == 0)
                    {
                        typeNumber = "even";
                    }
                    else
                    {
                        typeNumber = "odd";
                    }

                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeNumber}");
                }
                else if (operation == '/')
                {
                    result = n1 / (n2 * 1.0);
                    Console.WriteLine($"{n1} {operation} {n2} = {result}");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result}");
                }
            }


        }
    }
}
