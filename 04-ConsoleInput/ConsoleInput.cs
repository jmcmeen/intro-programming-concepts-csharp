/// <summary>
/// File: ConsoleInput.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP1010 Examples
/// </summary>
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate input using the Console class
    /// </summary>
    internal class ConsoleInput
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            string inputString;
            char inputChar;
            int x;

            Console.Write("Enter a int: ");
            inputString = Console.ReadLine();
            x = Convert.ToInt32(inputString);
            Console.WriteLine($"You wrote {x}");

            Console.Write("Press a key: ");
            inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nYou wrote {inputChar}");

            Console.Write("Press a key (input hidden): ");
            inputChar = Console.ReadKey(true).KeyChar;
            Console.WriteLine($"\nYou wrote {inputChar}");
        }
    }
}