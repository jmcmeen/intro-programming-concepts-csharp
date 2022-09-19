/// <summary>
/// File: ConsoleInput.cs
/// Name: John McMeen
/// Class: CISP1010
/// Semester: Fall 2022
/// Project: CISP1010 Examples
/// </summary>
namespace CISP1010
{
    internal class ConsoleInput
    {        
        /// <summary>
        /// The Main method is an an entry point for the program
        /// </summary>
        /// <param name="args">string array for passing in command line arguments</param>
        static void Main(string[] args)
        {
            string inputValue;
            int x;

            Console.Write("Enter a number: ");
            inputValue = Console.ReadLine();
            x = Convert.ToInt32(inputValue);


            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());


        }
    }
}