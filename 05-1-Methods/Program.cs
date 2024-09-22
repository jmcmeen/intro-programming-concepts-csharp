namespace CISP1010
{
    /// <summary>
    /// A program that demonstrates using static methods
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            int y;
            double z;

            //use the first version of PrintWelcomeMessage
            PrintWelcomeMessage();

            //This is another version, which takes a parameter and prints what is passed in
            //Two or more methods with the same name is called method overloading
            PrintWelcomeMessage("Welcome!");

            //Calculate square and return the value into y
            y = Square(9);
            Console.WriteLine(y);

            //Calculate sum and return the value into y
            y = Add(4, 6);
            Console.WriteLine(y);

            //Calculate the sum and return the value in y
            z = Add(5.0, 6.0);
            Console.WriteLine(z);

            //When you pass a value-type variable from one method to another,
            //the system creates a separate copy of the variable's value in another method.
            //If the value is changed in the one method, it doesn't affect the
            //value in another method. 

            //This is called pass by value
            Console.WriteLine($"the value of y is {y}");
            TryToChangeValueType(y);
            Console.WriteLine($"the value of y is {y}");
        }

        /// <summary>
        /// Prints a welcome message
        /// </summary>
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("       Welcome to the Program!      ");
            Console.WriteLine("------------------------------------");
        }

        /// <summary>
        /// Prints a welcome message specified by the user
        /// </summary>
        /// <param name="message">Message to print</param>
        static void PrintWelcomeMessage(string message)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"            {message}      ");
            Console.WriteLine("------------------------------------");
        }

        /// <summary>
        /// Adds two integers
        /// </summary>
        /// <param name="value1"> The first integer</param>
        /// <param name="value2"> The seconds integer</param>
        /// <returns> the sum of two integers</returns>
        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Adds two doubles
        /// </summary>
        /// <param name="value1">The first double</param>
        /// <param name="value2">The second double</param>
        /// <returns>The sum of two doubles</returns>
        static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Squares an int
        /// </summary>
        /// <param name="x">The int to be squared</param>
        /// <returns>x squared</returns>
        static int Square(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Demnonstrates pass by value
        /// </summary>
        /// <param name="anInt">an integer value</param>
        static void TryToChangeValueType(int anInt)
        {
            Console.WriteLine($"the value of anInt is {anInt}");
            anInt = 42;
            Console.WriteLine($"the value of anInt is {anInt}");
        }
    }
}