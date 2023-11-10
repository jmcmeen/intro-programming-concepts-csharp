// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples
// Resources: https://www.piano-keyboard-guide.com/c-sharp-minor-scale.html

using Util;

namespace _07_6_CSharpMinorRemix
{
    /// <summary>
    /// Demonstrates constants, arrays, for-loops, random numbers, methods
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main(string[] args)
        {
            //In 7-4 a mthod for playing an array of notes was introduced
            //In 7-5 we examined playing random notes from an array, but did not use the play notes method
            //Here we are going to combine the approaches. 

            // since we will be using this number a lot, store it as a constant so we don't have to hunt down all literal instances if we want to change them
            const int NUM_NOTES = 200;

            //Upper and lower bounds for random int generation
            const int DURATION_LOWER_BOUND = 50;
            const int DURATION_UPPER_BOOUND = 500;
            const int PAUSE_DURATION_LOWER_BOUND = 0;
            const int PAUSE_DURATION_UPPER_BOUND = 100;

            //Declare some notes in the C# minor scale (these would probably be better off living in a separate file)
            const int cSharp = 277;
            const int dSharp = 311;
            const int E = 329;
            const int fSharp = 369;
            const int gSharp = 415;
            const int a = 440;
            const int b = 493;

            //put the notes in an array to select random notes from
            int[] notes = { cSharp, dSharp, E, fSharp, gSharp, a, b };

            //Declare some array values which will hold random values
            int[] randomFrequencies = new int[NUM_NOTES];
            int[] randomDurations = new int[NUM_NOTES];
            int[] randomPauseDurations = new int[NUM_NOTES];

            //declare some temp variables to use in the for-loop below 
            int randomIndex;
            int randomDuration;
            int randomPauseDuration;

            //instead of getting values and immediately using them like we did in 7-5, here we will store all
            //the random values into arrays, and then pass those values to our play notes method
            for (int i = 0; i < NUM_NOTES; i++)
            {
                randomIndex = Fortuita.GetRandomInt(notes.Length);
                randomDuration = Fortuita.GetRandomInt(DURATION_LOWER_BOUND, DURATION_UPPER_BOOUND);
                randomPauseDuration = Fortuita.GetRandomInt(PAUSE_DURATION_LOWER_BOUND, PAUSE_DURATION_UPPER_BOUND);

                //use the random index generated above to get a value out of the notes array and put it in the random frequencies array
                randomFrequencies[i] = notes[randomIndex];

                //here we will set the values for the current iteration of random durations and random pause durations
                randomDurations[i] = randomDuration;
                randomPauseDurations[i] = randomPauseDuration;
            }

            //Now, we have all our data bundled up into the arrays that the play notes method needs
            PlayNotes(randomFrequencies, randomDurations, randomPauseDurations);

            //We will do this all over again in a future lab, but use objects instead.
        }

        /// <summary>
        /// Plays a melody arranged in three arrays of corresponding frequencies,durations, and pause durations
        /// </summary>
        /// <param name="frequencies">array of notes as frequencies to play</param>
        /// <param name="durations">array of note durations</param>
        /// <param name="pauseDurations">array of pause durations</param>
        static void PlayNotes(int[] frequencies, int[] durations, int[] pauseDurations)
        {
            //Guard clause, make sure arrays are of same length
            if (frequencies.Length != durations.Length || frequencies.Length != pauseDurations.Length)
            {
                return;
            }

            //Guard clause, make sure this is a windows system
            if (!OperatingSystem.IsWindows())
            {
                return;
            }

            //we had to make sure they are the same length because we will be using one i value to access each element
            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(pauseDurations[i]);
            }
        }
    }
}