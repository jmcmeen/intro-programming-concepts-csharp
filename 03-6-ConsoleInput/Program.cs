/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate input using the Console class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //declare some variables
            string inputString;
            char inputChar;
            int x;

            //Ask for a value, the user will enter a value and press Enter
            Console.Write("Enter a int: ");
            
            //The ReadLine method returns a string
            inputString = Console.ReadLine();

            //If you want the value to be another type, you will have to convert it from a string
            x = Convert.ToInt32(inputString);
            Console.WriteLine($"You wrote {x}");

            //The ReadKeyMethod returns the first character pressed, without having to press Enter
            Console.Write("Press a key: ");

            //ReadKey returns an object that contains the character, this is how you retreive it
            inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nYou wrote {inputChar}");

            //By passing a true Boolean into ReadKey's parameter list, the character typed will not show on the screen
            Console.Write("Press a key (input hidden): ");
            inputChar = Console.ReadKey(true).KeyChar;
            Console.WriteLine($"\nYou wrote {inputChar}");
        }
    }
}