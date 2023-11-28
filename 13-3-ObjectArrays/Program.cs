// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using DataModels;

namespace _13_3_ObjectArrays
{
    /// <summary>
    /// Demonstrates creating arrays of objects
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create an array for seven dice references.
            Dice[] dice = new Dice[7];

            //The references are null until their contructors are invoked. 
            //The line below would cause a null reference exception at run-time
            //dice[0].NextRoll();

            //see we need to instantiate objects for these references to point to
            dice[0] = new Dice(4);
            dice[1] = new Dice(6);
            dice[2] = new Dice(8);
            dice[3] = new Dice(10);
            dice[4] = new Dice(12);
            dice[5] = new Dice(20);
            dice[6] = new Dice(100);

            //For 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-------------");

                //Roll each dice object 
                foreach (Dice d in dice)
                {
                    Console.WriteLine($"{d} = {d.NextRoll()}");
                }

                Console.WriteLine("-------------\n");
            }
        }
    }
}