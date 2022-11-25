/// <summary>
/// File: MultidimensionalArrays.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
/// </summary>
namespace _10_MultidimensionalArrays
{
    internal class MultidimensionalArrays
    {
        static void Main(string[] args)
        {
            int[,] scores = new int[5,10];

            
            Random r = new Random();

            


            for(int i = 0; i < scores.GetLength(0); i++)
            {
                for(int j = 0; j < scores.GetLength(1); j++)
                {
                    scores[i, j] = r.Next(1,7);
                }
            }


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