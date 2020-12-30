using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!CheckLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckLetterssAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
           

            if (!Check2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckLetterssAndDigits(password) && CheckLength(password) && Check2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckLength(string password)
        {
            return (password.Length >= 6 && password.Length <= 10 ? true : false);
        }

        static bool CheckLetterssAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool Check2Digits(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' 
                    || password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9' || password[i] == '0')
                {
                    count++;
                }

                if (count == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
