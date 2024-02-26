namespace DataModels;

/// <summary>
/// Models a Book object
/// </summary>
public class Book
{
    /// <summary>
    /// Title of the book
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Author of the book
    /// </summary>
    public string? Author { get; set; }

    /// <summary>
    /// Number of pages in book
    /// </summary>
    public ushort Pages { get; set; }

    /// <summary>
    /// ISBN of book
    /// </summary>
    public string? ISBN { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Book()
    {
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
