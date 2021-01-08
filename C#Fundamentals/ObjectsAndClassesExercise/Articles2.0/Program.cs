using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ");
                Article current = new Article(article[0], article[1], article[2]);
                articles.Add(current);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }

    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
