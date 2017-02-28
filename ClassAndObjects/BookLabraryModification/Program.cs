using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLabraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            var lib = new Dictionary<string, DateTime>();
            

            for (int i = 0; i < n; i++)
            {
                var book = new Book();
                var tokens = Console.ReadLine().Split();
                book.Title = tokens[0];
                book.Author = tokens[1];
                book.Publisher = tokens[2];
                book.ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.Isbn = tokens[4];
                book.Price = decimal.Parse(tokens[5]);
                books.Add(book);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            
            
            for (int i = 0; i < books.Count; i++)

            {
                if (!lib.ContainsKey(books[i].Title))
                {
                    lib[books[i].Title] = books[i].ReleaseDate;
                }
            }

            foreach (var book in lib.OrderBy(x => x.Value).ThenBy(x => x.Value))
            {
                if (book.Value.CompareTo(date) > 0)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
                }
              
            }
            
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }


    }
}
