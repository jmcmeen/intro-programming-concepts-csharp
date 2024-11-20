namespace _03_4_ComparisonOperators
{
    /// <summary>
    /// A program to demonstrate comparison operators
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Equality operators are:
            // == equal to
            // != not equal 

            //Comparison operators are:
            // > greater than
            // < less than
            // >= greater than or equal to
            // <= less than equal to

            //Declare some variables to use in this program
            int intOperand1;
            int intOperand2;
            bool result;

            //Assign values to the integer variables
            intOperand1 = 32;
            intOperand2 = 16;

            //test to see if the values are equal and store result in a boolean variable
            result = intOperand1 == intOperand2;
            Console.WriteLine("Is " + intOperand1 + " == " + intOperand2 + "? " + result);

            //test to see if the values are not equal and store result in boolean variable
            result = intOperand1 != intOperand2;
            Console.WriteLine("Is " + intOperand1 + " != " + intOperand2 + "? " + result);

            //test to see if intOperand1 is less than intOperand2
            result = intOperand1 < intOperand2;
            Console.WriteLine("Is " + intOperand1 + " < " + intOperand2 + "? " + result);

            //test to see if intOperand1 is less than or equal to intOperand2
            result = intOperand1 <= intOperand2;
            Console.WriteLine("Is " + intOperand1 + " <= " + intOperand2 + "? " + result);

            //test to see if intOperand1 is greater than intOperand2
            result = intOperand1 > intOperand2;
            Console.WriteLine("Is " + intOperand1 + " > " + intOperand2 + "? " + result);

            //test to see if intOperand1 is greater than or equal to intOperand2
            result = intOperand1 >= intOperand2;
            Console.WriteLine("Is " + intOperand1 + " >= " + intOperand2 + "? " + result);

            //most times, comparison operators are used in control structures like if-else blocks or loops, not
            //using a variable to store the result but to test in place. Below is an example of not equal, which given
            //the values for the operands, is true, causing the code inside of the if block to execute. If the values
            //were equal, the statement would be false and the if block would be ignored.
            if (intOperand1 != intOperand2)
            {
                Console.WriteLine("The values are not equal.");
            }
        }
    }
}
