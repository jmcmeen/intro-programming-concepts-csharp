namespace _04_4_SelectionStatements
{
    /// <summary>
    /// A program to demonstrate selection statements (switch)
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

            if (value == 1)
            {
                Console.WriteLine("The integer value is 1");
            }
            else if (value == 2)
            {
                Console.WriteLine("The integer value is 2");
            }
            else
            {
                Console.WriteLine("No case defined for " + value);
            }

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

            //Prompt the user for a value
            Console.Write("Enter an integer value: ");
            value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case < 0:
                    Console.WriteLine("The integer value is less than zero");
                    break;
                case > 0:
                    Console.WriteLine("The integer value is greater than zero");
                    break;
                default:
                    Console.WriteLine("0 == " + value);
                    break;
            }
        }
    }
}