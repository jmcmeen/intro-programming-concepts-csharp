// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using System.Diagnostics;
using System.Text;

namespace _14_2_StringEfficiency
{
    /// <summary>
    /// Demonstrates String immutability and StringBuilder
    /// </summary>
    internal static class Program
    {

        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            const int NUM_TIMES_TO_CONCAT = 1000000;

            //declare a Stopwatch to track time
            Stopwatch stopWatch = new Stopwatch();

            //start stopwatch
            stopWatch.Start();

            //run the method that uses string concatenation
            StringConcatenateExample(NUM_TIMES_TO_CONCAT);

            //stop the watch
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("String concatenation run time " + elapsedTime);

            //Reset stopwatch
            stopWatch.Reset();

            //start stopwatch
            stopWatch.Start();

            //run the method that uses StringBuilder
            StringBuilderExample(NUM_TIMES_TO_CONCAT);

            //stop the watch
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("StringBuilder run time " + elapsedTime);

            //Why does StringBuilder run in better time?
        }

        /// <summary>
        /// Method that concatenates a character to a string to show string immutability
        /// run time concerns
        /// </summary>
        /// <param name="numTimes">number of time to concatenate</param>
        /// <returns>concatenated string</returns>
        static string StringConcatenateExample(int numTimes)
        {
            string s = "";

            for (int i = 0; i < numTimes; i++)
            {
                s += "z";
            }

            return s;
        }

        /// <summary>
        /// Method that concatenates a character to a string using StringBuilder
        /// </summary>
        /// <param name="numTimes">number of time to concatenate</param>
        /// <returns>concatenated string</returns>
        static string StringBuilderExample(int numTimes)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numTimes; i++)
            {
                sb.Append("z");
            }

            return sb.ToString();
        }
    }
}