// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate while-loops and for-loops
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //The while-loop is versatile, and primarily used for sentinel value looping
            //However, I think using a while loop, such as below, is useful for understanding
            //each step in a for loop.

            int counter = 0; //establish starting point

            while (counter < 5)
            { //evaluate logic condition
                LiftWeight();
                LowerWeight();
                counter++;      //at some point make sure the sentinel value
            }

            //do-while loop
            counter = 0; //notice we had to reset the counter to reuse it
            do
            {
                LiftWeight();
                LowerWeight();
                counter++;
            }
            while (counter < 5);

            //The for-loop is designed for counting, and allows us to set up a counting
            //loop with less code than the for loop.
            for (int i = 0; i < 5; i++)
            {
                LiftWeight();
                LowerWeight();
            }

            //Nested for-loop example
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i} - {j}");
                }
            }

            //Reverse for-loop 
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        /// <summary>
        /// Lifts the weight
        /// </summary>
        public static void LiftWeight()
        {
            Console.WriteLine("Lifting the weight!");
        }

        /// <summary>
        /// Lowers the weight
        /// </summary>
        public static void LowerWeight()
        {
            Console.WriteLine("Lowering the weight!");
        }
    }
}