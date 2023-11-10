// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate for loops
    /// </summary>
    internal static class ForLoops
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //creat an array of strings
            string[] someStrings = { "Hello", "World", "42" };

            //use a for loop to visit each element in the array
            for (int i = 0; i < someStrings.Length; i++)
            {
                Console.WriteLine(someStrings[i]);
            }
            Console.WriteLine();

            //use a foreach loop to create a read-only alias to an array element
            foreach (string s in someStrings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            //since a foreach loop variable is read only, you must use a for i loop if editing array values
            for (int i = 0; i < someStrings.Length; i++)
            {
                //overwriting each element in the array
                someStrings[i] = "overwritten";
            }

            //so foreach loops are used for access only
            foreach (string s in someStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}