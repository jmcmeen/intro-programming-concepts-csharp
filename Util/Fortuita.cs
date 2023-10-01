namespace Util
{
    //Static wrapper class to get random values without working with Random directly
    public static class Fortuita
    {
        /// <summary>
        /// Returns a random int that is >=0 and < upperBound
        /// </summary>
        /// <param name="upperBound">upper boundary</param>
        /// <returns></returns>
        public static int GetRandomInt(int upperBound)
        {
            Random random = new Random();
            return random.Next(upperBound);
        }

        /// <summary>
        /// Returns a random int that is >=lowerBound and < upperBound
        /// </summary>
        /// <param name="lowerBound">lower bound</param>
        /// <param name="upperBound">upper bound</param>
        /// <returns></returns>
        public static int GetRandomInt(int lowerBound, int upperBound)
        {
            Random random = new Random();
            return random.Next(lowerBound, upperBound);
        }
    }
}
