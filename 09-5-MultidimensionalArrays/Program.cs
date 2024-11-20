namespace _09_5_MultidimensionalArrays
{
    /// <summary>
    /// Demonstration of multidimensional arrays
    /// </summary>
    internal static class Program
    {
        //Entry point for the application
        static void Main()
        {
            // declare a 2D int array
            int[,] scores = new int[5, 4];

            //create a Random object
            Random random = new Random();

            //set all the values in multidimensional array
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    scores[i, j] = random.Next(1, 7);
                }
            }

            //print all the values in multidimensional array
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write(scores[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}