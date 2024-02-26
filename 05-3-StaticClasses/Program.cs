namespace _05_3_ClassLibraries
{
    /// <summary>
    /// Demonstrates using programmer defined static classes
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            #region declare variables
            int g;
            float m;
            double n;
            #endregion

            #region prompt for values
            g = Prompt.ForInt("Enter an int: ");
            m = Prompt.ForFloat("Enter a float: ");
            n = Prompt.ForDouble("Pardon me, may I have a double?: ");
            #endregion

            #region print values
            Console.WriteLine("g = " + g);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            #endregion
        }
    }
}
