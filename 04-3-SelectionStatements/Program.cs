namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate selection statements (if, else if)
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

            //Prints a different message depending on user input
            if (value > 0)
            {
                Console.WriteLine("The integer value " + value + " is greater than 0.");
            }
            else if (value < 0)
            {
                Console.WriteLine("The integer value " + value + " is less than 0.");
            }
            else
            {
                Console.WriteLine("The integer value " + value + " is equal to 0.");
            }
        }
    }
}