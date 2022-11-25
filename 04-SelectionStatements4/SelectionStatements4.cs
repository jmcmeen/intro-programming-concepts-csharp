/// File: SelectionStatements4.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate selection statements (switch)
    /// </summary>
    internal class SelectionStatements4
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

            switch (value)
            {
                case 1:
                    Console.WriteLine("The integer value is 1");
                    break;
                case 2:
                    Console.WriteLine("The integer value is 2");
                    break;
                default:
                    Console.WriteLine("No case defined for " + value);
                    break;
            }
        }
    }
}