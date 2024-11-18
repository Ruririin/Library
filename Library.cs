using System.Linq;
using System;
using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        private List<IBook> _books = new List<IBook>();

        public void AddBook(string title, string author)
        {
            var year = GetValidYear("Enter the publication year: ");
            if (year <= 0)
            {
                Console.WriteLine("Invalid year. The year must be greater than 0.");
                return;
            }

            _books.Add(new Book(title, author, year));
            Console.WriteLine("Book added successfully!");
        }

        private int GetValidYear(string prompt)
        {
            int year;
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();

                if (int.TryParse(input, out year) && year > 0)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid number greater than 0.");
                }
            }
        }

        public void DisplayAllBooks()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                Console.WriteLine("List of Books:");

                _books
                    .Select(b => $"{b.Title} by {b.Author} ({b.PublicationYear})")
                    .ToList()
                    .ForEach(Console.WriteLine); 
            }
        }

        public void SearchBooksByTitle(string searchTitle)
        {
            var foundBooks = _books
                            .Where(b => b.Title.IndexOf(searchTitle, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();  

            if (foundBooks.Any()) 
            {
                Console.WriteLine("Search Results:");
                foundBooks.ForEach(book => Console.WriteLine($"{book.Title} by {book.Author} ({book.PublicationYear})"));
            }
            else
            {
                Console.WriteLine("No books found with that title.");
            }
        }

        public void DisplayBooksSortedByYear()
        {
            _books
                .OrderBy(b => b.PublicationYear)   
                .ToList()                         
                .ForEach(book => Console.WriteLine($"{book.Title} by {book.Author} ({book.PublicationYear})"));
        }
    }
}