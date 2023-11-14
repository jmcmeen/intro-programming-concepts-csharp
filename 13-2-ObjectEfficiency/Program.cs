// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using DataModels;
using System.Diagnostics;

namespace _13_2_ObjectEfficiency
{
    /// <summary>
    /// Demonstrates run time considerations on memory operations
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            const int NUM_ROLLS = 1000000000;

            //declare a Stopwatch to track time
            Stopwatch stopWatch = new Stopwatch();

            //start stopwatch
            stopWatch.Start();

            //create ClumsyDice object
            ClumsyDice clumsyDice = new ClumsyDice();

            for (int i = 0; i < NUM_ROLLS; i++)
            {
                clumsyDice.NextRoll();
            }

            //stop the watch
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("ClumsyDice run time " + elapsedTime);

            //Reset stopwatch
            stopWatch.Reset();

            //start stopwatch
            stopWatch.Start();

            //create Dice object
            Dice dice = new Dice();

            for (int i = 0; i < NUM_ROLLS; i++)
            {
                dice.NextRoll();
            }

            //stop the watch
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Dice run time " + elapsedTime);

            //Why does Dice run faster than ClumsyDice?
        }
    }
}