/// <summary>
/// File: Methods.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP1010 Examples
/// </summary>

namespace CISP1010
{
    /// <summary>
    /// A program that demonstrates using static methods
    /// </summary>
    internal class Methods
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            PrintWelcomeMessage();
            PrintWelcomeMessage("Hello World");
            Console.WriteLine(Square(9));

        }

        /// <summary>
        /// Prints a welcome message
        /// </summary>
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("       Welcome to the Program!      ");
            Console.WriteLine("------------------------------------");

        }

        /// <summary>
        /// Prints a welcome message specified by the user
        /// </summary>
        /// <param name="message">Message to print</param>
        static void PrintWelcomeMessage(string message)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"            {message}      ");
            Console.WriteLine("------------------------------------");

        }

        /// <summary>
        /// Squares an int
        /// </summary>
        /// <param name="x">The int to be squared</param>
        /// <returns>x squared</returns>
        static int Square(int x)
        {
            return x * x;
        }
    }
}