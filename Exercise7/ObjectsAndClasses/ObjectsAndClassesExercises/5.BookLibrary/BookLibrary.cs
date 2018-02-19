using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _5.BookLibrary
{
    class BookLibrary
    {
        public static void Main(string[] args)
        {
            var countBooks = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            List<Library> library = new List<Library>();
            var authorAndPrice = new Dictionary<string, double>();

            for (int i = 0; i < countBooks; i++)
            {
                var bookLine = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var title = bookLine[0];
                var author = bookLine[1];
                var publisher = bookLine[2];
                var releaseDate = DateTime.ParseExact(bookLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbnNumber = long.Parse(bookLine[4]);
                var price = double.Parse(bookLine[5]);

                Book currBook = new Book();

                currBook.Title = title;
                currBook.Author = author;
                currBook.Publisher = publisher;
                currBook.ReleaseDate = releaseDate;
                currBook.IsbnNumber = isbnNumber;
                currBook.Price = price;

                listOfBooks.Add(currBook);

                Library currLibrary = new Library();
                currLibrary.Name = author;
                currLibrary.Books = listOfBooks;

                if (!authorAndPrice.ContainsKey(currLibrary.Name))
                {
                    authorAndPrice[currLibrary.Name] = 0.0;
                }
                authorAndPrice[currLibrary.Name] += currBook.Price;
            }

            var result = authorAndPrice
                .OrderByDescending(p => p.Value)
                .ThenBy(a => a.Key);

            foreach (var book in result)
            {
                Console.WriteLine($"{book.Key} -> {book.Value:F2}");
            }
        }
    }
}
