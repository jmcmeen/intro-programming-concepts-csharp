// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace DataModels
{
    public class Dice
    {
        //data
        public int numSides;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Dice()
        {
            this.numSides = 6;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="numSides">The number of sides on the die</param>
        public Dice(int numSides)
        {
            this.numSides = numSides;
        }

        /// <summary>
        /// Rolls the dice
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            Random rng = new Random();
            return rng.Next(numSides) + 1;
        }
    }
}
