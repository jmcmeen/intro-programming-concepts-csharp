// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate selection statements (if)
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create program variables
            int value;

            //Prompt the user for a value
            Console.Write("Enter an integer value: ");
            value = Convert.ToInt32(Console.ReadLine());

            //Prints a message if the user enters 0
            if (value == 0)
            {
                Console.WriteLine("The integer value " + value + " is equal to 0");
            }
        }
    }
}
