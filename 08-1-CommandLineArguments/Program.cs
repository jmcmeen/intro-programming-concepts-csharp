// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _08_1_CommandLineArguments
{
    /// <summary>
    /// Demonstrates the use of command line arguments
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            //When arguments are passed from the command line, such as -> someProgram.exe -c 42 3 hello
            //Main receives these as a string array, the argument string has been split on a space and would generate this
            //array for above {"-c", "42", "3". "hello"}

            //see if arg array is empty
            if(args.Length != 0)
            {
                foreach (string arg in args)
                {
                    Console.WriteLine($"  {arg}");
                }
            }
            else //if not print
            {
                Console.WriteLine("No command line arguments specified!");
            }
        }
    }
}