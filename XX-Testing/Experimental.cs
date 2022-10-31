namespace CISP1010
{
    class Experimental
    {
        static void Main(string[] args)
        {
            string message = "Hello Worl Nice to MEet You!\n\n";

            //ConsoleUtilities.PrintColor(message, ConsoleColor.Red);
            //ConsoleUtilities.PrintRainbow(message);
            //ConsoleUtilities.PrintRainbow(ConsoleUtilities.RandomizeCase(message));
            //ConsoleUtilities.PrintRainbow(ConsoleUtilities.AlternateCase(message));
            //ConsoleUtilities.PrintRainbowScroll(message, 50);
            //ConsoleUtilities.PrintScroll(message, 100, ConsoleColor.Green);

            double[] notes = new double[13];
            notes[0] = 440.0; //a5
            char input;

            for(int i = 1; i < notes.Length; i++)
            {
                notes[i] = notes[i - 1] * 1.05946309436;
            }


            for (int i = 0; i < notes.Length; i++)
            {
                Console.Beep(Convert.ToInt32(notes[i]), 100);
            }



        }
    }
}