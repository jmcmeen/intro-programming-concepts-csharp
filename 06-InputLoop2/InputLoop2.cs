/// File: InputLoop2.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate building an input loop
    /// </summary>
    internal class InputLoop2
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create program variables
            int numDice, numSides;

            //Prompt the user to enter a number of dice to roll
            Console.Write("Enter num dice: ");
            numDice = Convert.ToInt32(Console.ReadLine());

            //While the user enters a value greater than 0
            while (numDice > 0)
            {
                //Then prompt the user to enter number of sides on dice
                Console.Write(" Enter num sides: ");
                numSides = Convert.ToInt32(Console.ReadLine());

                //TODO: implement dice roller algorithm here

                //Before we loop back, get numDice again to see if we continue
                Console.Write("Enter num dice: ");
                numDice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
