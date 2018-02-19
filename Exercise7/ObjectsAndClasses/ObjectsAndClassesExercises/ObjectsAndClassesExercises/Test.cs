using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6.BookLibraryModif
{
    class BookLibraryModif
    {
        public static void Main(string[] args)
        {
            var countBooks = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();

            for (int i = 0; i < countBooks; i++)
            {
                var bookLine = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var title = bookLine[0];
                var author = bookLine[1];
                var publisher = bookLine[2];
                DateTime releaseDate = DateTime.ParseExact(bookLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

            }
            //test
            DateTime startDade = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in listOfBooks.Where(a => a.ReleaseDate > startDade).OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }

        }
    }
}
