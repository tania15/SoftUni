namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var dbContext = new BookShopContext();
            //DbInitializer.ResetDatabase(dbContext);

            //Console.WriteLine(GetBooksByAgeRestriction(dbContext, "Minor"));

            //Console.WriteLine(GetGoldenBooks(dbContext));

            Console.WriteLine(GetBooksByPrice(dbContext));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            AgeRestriction restriction = Enum.Parse<AgeRestriction>(command, true);

            var titles = context.Books
                .Where(b => b.AgeRestriction == restriction)
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var t in titles)
            {
                sb.AppendLine(t);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var titles = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var t in titles)
            {
                sb.AppendLine(t);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var titles = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var t in titles)
            {
                sb.AppendLine($"{t.Title} - ${t.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var titles = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var t in titles)
            {
                sb.AppendLine(t);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            //string[] categories = input
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();

            var titles = context.Books
                .Where(b => b.BookCategories.Any(c => input.ToLower().Contains(c.Category.Name.ToLower())))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var t in titles)
            {
                sb.AppendLine(t);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate < DateTime.Parse(date))
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    EditionType = b.EditionType.ToString(),
                    b.Price
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.ToLower().EndsWith(input.ToLower()))
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .Select(a => $"{a.FirstName} {a.LastName}")                
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var a in authors)
            {
                sb.AppendLine(a);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var b in books)
            {
                sb.AppendLine(b);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => new
                {
                    b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}"
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title} ({b.AuthorName})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int count = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return count;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                .Select(a => new
                {
                    Name = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.Copies)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var a in authors)
            {
                sb.AppendLine($"{a.Name} - {a.Copies}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Profit = c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
                })
                .OrderByDescending(b => b.Profit)
                .ThenBy(c => c.Name)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var c in categories)
            {
                sb.AppendLine($"{c.Name} ${c.Profit:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categoriesAndBooks = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks
                        .Select(b => b.Book)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Take(3)
                        .Select(b => new
                        {
                            b.Title,
                            ReleaseDate = b.ReleaseDate.Value.Year
                        })
                        .ToArray()
                })
                .OrderBy(c => c.CategoryName)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var c in categoriesAndBooks)
            {
                sb.AppendLine($"--{c.CategoryName}");

                foreach (var b in c.Books)
                {
                    sb.AppendLine($"{b.Title} ({b.ReleaseDate})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            IQueryable<Book> allBooksBefore2010 = context
                .Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010);

            foreach (Book book in allBooksBefore2010)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            int count = 0;
            IQueryable<Book> removeBooks = context.Books
                .Where(b => b.Copies < 4200);

            foreach (var b in removeBooks)
            {
                context.Books.Remove(b);
                count++;
            }

            context.SaveChanges();

            return count;
        }
    }
}
