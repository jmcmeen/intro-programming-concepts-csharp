/// File: Objects3.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration using Book objects
    /// </summary>
    internal class Objects3
    {
        static void Main(string[] args)
        {
            //Create a Book using default constructor
            Book a = new Book();

            //Notice Books default constructor just sets some default values for a Book
            Console.WriteLine($"{a.Title} {a.Author} {a.Pages} {a.ISBN}");

            //We would use the default constructor if we wanted to create memory for a Book and then alter it later
            //Since we have some public properties that allow us to get (access) and set (mutate) values in a Book,
            //we can make some changes and then use them 
            a.Title = "A Super Cool Book";
            a.Author = "McMeen, John";
            a.Pages = 5398;
            a.ISBN = "9385938201";

            //Notice the Book objects' values changed
            Console.WriteLine($"{a.Title} {a.Author} {a.Pages} {a.ISBN}\n");

            //If we already have some values for a Book, such as in some variables entered by a user,
            //We can use those with a paramterized constructor to set up the memory and values in that memory
            //when the object is created
            string someTitle = "Another Super Awesome Book";
            string someAuthor = "McMeen, John";
            ushort somePages = 2349;
            string someISBN = "937293004";

            //Create Book using paramterized constructor
            Book b = new Book(someTitle, someAuthor, somePages, someISBN);

            //Book also has a ToString method that bundles up all the values in a Book, and anything else we want in
            //a string representation of a Book, and returns a string
            Console.WriteLine(b.ToString());
        }
    }
}