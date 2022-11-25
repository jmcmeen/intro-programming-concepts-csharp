/// File: MultidimensionalArrays.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration of multidimensional arrays
    /// </summary>
    internal class MultidimensionalArrays
    {
        //Entry point for the application
        static void Main()
        {
            int[,] scores = new int[5,10];
            
            Random r = new Random();

            //set all the values in multidimensional array
            for(int i = 0; i < scores.GetLength(0); i++)
            {
                for(int j = 0; j < scores.GetLength(1); j++)
                {
                    scores[i, j] = r.Next(1,7);
                }
            }

            //print allthe values in multidimensional array
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