namespace _08_4_ToxicRemix
{
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            //construct some notes, durations, and pauses arrays
            int[] toxicFrequencies = { 523, 523, 622, 587, 523, 587, 622, 1369, 1174, 1244, 1174, 1046 };
            int[] toxicNoteDurations = { 200, 200, 100, 100, 100, 100, 400, 500, 500, 200, 200, 250 };
            int[] toxicPauseDurations = { 0, 0, 0, 0, 0, 0, 600, 0, 0, 0, 0, 0 };

            //play them
            PlayNotes(toxicFrequencies, toxicNoteDurations, toxicPauseDurations);

            //We will see soon, there is still a better way to hold these values. Since the values in
            //each index of both arrays, we should find a way to group them together. The answer will be
            //objects.
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