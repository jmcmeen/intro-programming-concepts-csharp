using LabUtils;

namespace _08_5_CSharpMinor
{
    /// <summary>
    /// Demonstrates constants, arrays, random numbers, Console.Beep, guard clauses
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Upper and lower bounds for random int generation
            const int NUM_NOTES = 200;
            const int DURATION_LOWER_BOUND = 50;
            const int DURATION_UPPER_BOUND = 501;
            const int PAUSE_DURATION_LOWER_BOUND = 0;
            const int PAUSE_DURATION_UPPER_BOUND = 6;

            //Declare some notes in the C# minor scale
            const int cSharp = 277;
            const int dSharp = 311;
            const int e = 329;
            const int fSharp = 369;
            const int gSharp = 415;
            const int a = 440;
            const int b = 493;

            //put the notes in an array to select random notes from
            int[] notes = { cSharp, dSharp, e, fSharp, gSharp, a, b };

            //Declare some variables which will hold random values
            int randomIndex;
            int randomDuration;
            int randomPauseDuration;

            //Guard clause for non windows systems
            if (!OperatingSystem.IsWindows()) return;

            //Let's play NUM_NOTES number of notes (that is a bad sentence but intentional)
            for (int i = 0; i < NUM_NOTES; i++)
            {
                //get a random index number to use with the notes array using the length of the array as upper bound
                randomIndex = Fortuita.GetRandomInt(notes.Length); //a "using LabUtils;" statement up top would make this method call shorter

                //get a random duration for the note
                randomDuration = Fortuita.GetRandomInt(DURATION_LOWER_BOUND, DURATION_UPPER_BOUND);

                //get a random pause duration to play after note
                randomPauseDuration = Fortuita.GetRandomInt(PAUSE_DURATION_LOWER_BOUND, PAUSE_DURATION_UPPER_BOUND);

                //use randomIndex as an index into the notes array to get one of the C# minor notes, also use the random duration generated above
                Console.Beep(notes[randomIndex], randomDuration);

                //sleep for random pause duration
                Thread.Sleep(randomPauseDuration);
            }
        }
    }
}