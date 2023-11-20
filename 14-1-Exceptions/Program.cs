// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _14_1_Exceptions
{
    /// <summary>
    /// Program that demonstrates Exceptions
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            try
            {
                Console.Write("Enter a number to divide by: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = 10 / x;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}