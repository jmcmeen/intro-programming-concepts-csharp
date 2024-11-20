namespace _03_3_ArithmeticOperators
{
    /// <summary>
    /// A program to demonstrate arithmetic operators
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Notes: Here we are mainly using the + operator with integer operands
            // which performs an arithmetic operation. However, when an operand is
            // a string, then it will concatenate, or combine, the values to
            // make a new string. This is demonstrated in the WriteLine methods below.

            //Declare some variables to use in this program
            int intOperand1;
            int intOperand2;
            int intResult;

            //Assign values to the integer variables
            intOperand1 = 32;
            intOperand2 = 16;

            //Add the values and display result
            intResult = intOperand1 + intOperand2;
            Console.WriteLine(intOperand1 + " + " + intOperand2 + " = " + intResult);

            //Subtract the values and display result
            intResult = intOperand1 - intOperand2;
            Console.WriteLine(intOperand1 + " - " + intOperand2 + " = " + intResult);

            //Multiply the values and display result
            intResult = intOperand1 * intOperand2;
            Console.WriteLine(intOperand1 + " * " + intOperand2 + " = " + intResult);

            //Divide the values and display result
            intResult = intOperand1 / intOperand2;
            Console.WriteLine(intOperand1 + " / " + intOperand2 + " = " + intResult);

            //Divide the values and display the remainder (modulus)
            intResult = intOperand1 % intOperand2;
            Console.WriteLine(intOperand1 + " % " + intOperand2 + " = " + intResult);

            //Increment the value by 1
            Console.WriteLine("Current value is " + intOperand1);
            intOperand1++;
            Console.WriteLine(" new value is " + intOperand1);

            //Decrement the value by 1
            Console.WriteLine("Current value is " + intOperand1);
            intOperand1--;
            Console.WriteLine(" new value is " + intOperand1);
        }
    }
}
