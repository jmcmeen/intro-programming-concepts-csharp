/// File: ForLoops.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate for loops
    /// </summary>
    internal class ForLoops
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //creat an array of integer values
            int[] myIntegers = { 0, 32, 65, 127, 23225232, -1 };

            //use a for loop to visit each element in the array
            for (int i = 0; i < myIntegers.Length; i++)
            {
                Console.Write(myIntegers[i] + " ");
            }
            Console.WriteLine();

            foreach (int myInt in myIntegers)
            {
                Console.WriteLine(myInt);
            }
        }
    }
}