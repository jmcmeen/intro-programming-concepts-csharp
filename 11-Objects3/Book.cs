/// File: Book.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Models a Book object
    /// </summary>
    internal class Book
    {
        //Here we define public automatic properties
        public string Title { get; set; }
        public string Author { get; set; }
        public ushort Pages { get; set; }
        public string ISBN { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Book()
        {
            Title = "";
            Author = "";
            Pages = 0;
            ISBN = "";
        }

        /// <summary>
        /// Paramterized constructor
        /// </summary>
        /// <param name="title">The title of the Book</param>
        /// <param name="author">The author of the Book</param>
        /// <param name="pages">The number of pages in the Book</param>
        /// <param name="isbn">The ISBN number of the Book</param>
        public Book(string title, string author, ushort pages, string isbn)
        {
            Title = title;
            Author = author;
            Pages = pages;
            ISBN = isbn;
        }

        /// <summary>
        /// Creates a string representation of the Book
        /// </summary>
        /// <returns>The string representation of the Book</returns>
        override public string ToString()
        {
            return $"title={Title}\nauthor={Author}\npages={Pages}\nISBN={ISBN}";
        }
    }
}
