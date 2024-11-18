using System;

namespace Library
{
    public class Book : IBook
    {
        private string _title;
        private string _author;
        private int _publicationYear;

        public Book(string title, string author, int publicationYear)
        {
            SetTitle(title);
            SetAuthor(author);
            SetPublicationYear(publicationYear);
        }

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int PublicationYear { get => _publicationYear; set => _publicationYear = value; }


        private void SetTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cannot be null or empty.");
            _title = title;
        }

        private void SetAuthor(string author)
        {
            if (string.IsNullOrEmpty(author))
                throw new ArgumentException("Author cannot be null or empty.");
            _author = author;
        }

        private void SetPublicationYear(int publicationYear)
        {
            if (publicationYear < 0)
                throw new ArgumentException("Publication year cannot be negative.");
            _publicationYear = publicationYear;
        }
    }
}
