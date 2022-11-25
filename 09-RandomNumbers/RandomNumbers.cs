/// File: RandomNumbers.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration of Random object
    /// </summary>
    internal class RandomNumbers
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create a object of type Random
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The next random in is {r.Next()}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(RollDice(6));
            }
        }

        /// <summary>
        /// Rolls a die
        /// </summary>
        /// <param name="numSides">The number of sides on the die</param>
        /// <returns>A random number >=1 and <= numSides</returns>
        static uint RollDice(uint numSides)
        {
            Random r = new Random();
            int temp = r.Next(1, Convert.ToInt32(numSides + 1));
            uint output = Convert.ToUInt32(temp);
            return output;
        }
    }
}