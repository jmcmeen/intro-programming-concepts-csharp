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
        private string title;
        private string author;
        private ushort pages;
        private string isbn;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Book()
        {
            this.title = "";
            this.author = "";
            this.pages = 0;
            this.isbn = "";
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
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
        }

        //Here we define public properties for private attributes
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public ushort Pages { get => pages; set => pages = value; }
        public string ISBN { get => isbn; set => isbn = value; }

        /// <summary>
        /// Creates a string representation of the Book
        /// </summary>
        /// <returns>The string representation of the Book</returns>
        override public string ToString()
        {
            return $"title={title}\nauthor={author}\npages={pages}\nISBN={isbn}";
        }
    }
}
