// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using DataModels;

namespace _13_4_ArraysOfToxicity
{
    /// <summary>
    /// Demonstrates arrays of objects
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Note[] toxicNotes = new Note[12];

            toxicNotes[0] = new Note(523, 200, 0);
            toxicNotes[1] = new Note(523, 200, 0);
            toxicNotes[2] = new Note(622, 100, 0);
            toxicNotes[3] = new Note(587, 100, 0);
            toxicNotes[4] = new Note(523, 100, 0);
            toxicNotes[5] = new Note(587, 100, 0);
            toxicNotes[6] = new Note(622, 400, 600);
            toxicNotes[7] = new Note(1369, 500, 0);
            toxicNotes[8] = new Note(1174, 500, 0);
            toxicNotes[9] = new Note(1244, 200, 0);
            toxicNotes[10] = new Note(1174, 200, 0);
            toxicNotes[11] = new Note(1046, 250, 0);

            PlayNotes(toxicNotes);
        }

        static void PlayNotes(Note[] notes)
        {
            //Guard clause, make sure this is a windows system
            if (!OperatingSystem.IsWindows())
            {
                return;
            }

            //for each Note
            foreach (Note n in notes)
            {
                Console.Beep(n.Frequency, n.Duration);
                Thread.Sleep(n.PostPauseDuration);
            }
        }
    }
}
