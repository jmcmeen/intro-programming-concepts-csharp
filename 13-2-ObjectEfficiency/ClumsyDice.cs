namespace _13_2_ObjectEfficiency
{
    internal class ClumsyDice
    {
        /// <summary>
        /// Number of sides
        /// </summary>
        public int NumSides { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClumsyDice()
        {
            NumSides = 6;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="numSides">The number of sides on the die</param>
        public ClumsyDice(int numSides)
        {
            NumSides = numSides;
        }

        /// <summary>
        /// Rolls the dice
        /// </summary>
        /// <returns>a random number between 1 and NumSides</returns>
        public int NextRoll()
        {
            Random rng = new Random();
            return rng.Next(NumSides) + 1;
        }
    }
}
