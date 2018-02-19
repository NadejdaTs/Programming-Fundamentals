using System;

namespace _5.BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long IsbnNumber { get; set; }
        public double Price { get; set; }
    }
}
