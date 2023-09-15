namespace Looper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayChromaticScale();
        }

        static void PlayChromaticScale()
        {
            if (OperatingSystem.IsWindows())
            {
                const double TWELTH_ROOT_OF_TWO = 1.05946309436;
                const double D_SHARP_1 = 38.89;

                //Create an array of notes
                double[] notes = new double[94];

                //set the first note to C1 frequency
                notes[0] = D_SHARP_1;

                //starting with the second note, multiply the previous note by
                //the twelth root of 2 to set the current note
                for (int i = 1; i < notes.Length; i++)
                {
                    notes[i] = notes[i - 1] * TWELTH_ROOT_OF_TWO;
                }

                //play all the notes
                foreach (int note in notes)
                {
                    //Console.WriteLine($"{note}"); //uncomment to see the frequency value
                    if (OperatingSystem.IsWindows())
                    {
                        Console.Beep(Convert.ToInt32(note), 100);
                    }
                }
            }
        }
    }
}