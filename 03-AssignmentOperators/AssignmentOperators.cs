/// File: AssignmentOperators.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate assignment operators
    /// </summary>
    internal class HelloWorld
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Declare some variables to use in this program
            int intOperand1;

            //Assign values to the integer variables and display
            intOperand1 = 32;
            Console.WriteLine("intOperand1 = " + intOperand1);

            //To add to the variable, you must add to intOperand1 and assign the value back to intOperand1
            intOperand1 = intOperand1 + 5;
            Console.WriteLine("intOperand1 = " + intOperand1);

            //To simplify this, C# provides an addition assignment operator which shortens the addition and assignment statement
            intOperand1 += 5;
            Console.WriteLine("intOperand1 = " + intOperand1);

            //Subtraction assignment
            intOperand1 -= 5;
            Console.WriteLine("intOperand1 = " + intOperand1);

            //Multiplication assignment
            intOperand1 *= 5;
            Console.WriteLine("intOperand1 = " + intOperand1);

            //Division assignment
            intOperand1 /= 5;
            Console.WriteLine("intOperand1 = " + intOperand1);
        }
    }
}
