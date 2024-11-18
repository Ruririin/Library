using System;

namespace Library
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        int PublicationYear { get; set; }
    }
}
