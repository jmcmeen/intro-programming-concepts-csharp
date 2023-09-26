namespace _03_7_OperationOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators in C# follow PEMDAS order of operations
            //P - parentheses
            //E = Exponents (not an operator in C#)
            //MD - Multiplication and Division performed left to right
            //AS - Addition and Subtraction performed left to right.
            Console.WriteLine($"{2 + 5 * 3}");

            Console.WriteLine($"{(212.0 - 32) * 5 / 9}");
            Console.WriteLine($"{(212.0 - 32) * (5 / 9)}");
        }
    }
}