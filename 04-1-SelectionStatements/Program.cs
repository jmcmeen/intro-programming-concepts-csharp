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
            string? tempInput;

            //Prompt the user for a value
            Console.Write("Enter an integer value 1: ");
            tempInput = Console.ReadLine();
            value = Convert.ToInt32(tempInput);

            //Prints a message if the user enters 0, but you didn't
            if (value == 0)
            {
                Console.WriteLine("The integer value " + value + " is equal to 0");
            }

            //Prompt the user for a value
            Console.Write("Enter an integer value 0: ");
            tempInput = Console.ReadLine();
            value = Convert.ToInt32(tempInput);

            //Prints a message if the user enters 0
            if (value == 0)
            {
                Console.WriteLine("The integer value " + value + " is equal to 0");
            }
        }
    }
}
