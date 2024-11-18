using System;


namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Search Books by Title");
                Console.WriteLine("4. Display Books Sorted by Publication Year");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddNewBook(library);
                }
                else if (choice == "2")
                {
                    library.DisplayAllBooks();
                }
                else if (choice == "3")
                {
                    SearchBooksByTitle(library);
                }
                else if (choice == "4")
                {
                    library.DisplayBooksSortedByYear();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
            }
        }


        private static void AddNewBook(Library library)
        {
            Console.Write("Enter the book title: ");
            var title = Console.ReadLine();

            Console.Write("Enter the author: ");
            var author = Console.ReadLine();

            library.AddBook(title, author);
        }

        private static void SearchBooksByTitle(Library library)
        {
            Console.Write("Enter a title or part of the title to search: ");
            var titleSearch = Console.ReadLine();

            library.SearchBooksByTitle(titleSearch);
        }
    }
}
