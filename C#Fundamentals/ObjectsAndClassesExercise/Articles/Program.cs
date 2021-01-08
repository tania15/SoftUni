using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else
                {
                    article.Rename(command[1]);

                }
            }

            Console.WriteLine(article);
        }
    }
}
