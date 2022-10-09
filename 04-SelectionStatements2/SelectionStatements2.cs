/// <summary>
/// File: SelectionStatements2.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
/// </summary>
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate selection statements (if/else)
    /// </summary>
    internal class SelectionStatements2
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

            //Prints a different message depending on user input
            if (value > 0)
            {
                Console.WriteLine("The integer value " + value + " is greater than 0.");
            }
            else
            {
                Console.WriteLine("The integer value " + value + " is less than 1.");
            }
        }
    }
}