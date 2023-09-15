/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace Toxic
{
    /// <summary>
    /// A program dedicated to The Princess of Pop
    /// ...which demonstrates a void return type method with no parameters
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Name that tune!
            Console.WriteLine("Toxic by Britney Spears");

            //Now just say the magic word, Toxic();
            PlayToxic();
        }

        /// <summary>
        /// Method which plays Britney Spears Toxic
        /// </summary>
        static void PlayToxic()
        {
            //Oof, Console.Beep(int, int) is only supported by Windows.
            if (OperatingSystem.IsWindows())
            {
                Console.Beep(523, 200);
                Console.Beep(523, 200);
                Console.Beep(622, 100);
                Console.Beep(587, 100);
                Console.Beep(523, 100);
                Console.Beep(587, 100);
                Console.Beep(622, 400);
                Thread.Sleep(600);
                Console.Beep(1369, 500);
                Console.Beep(1174, 500);
                Console.Beep(1244, 200);
                Console.Beep(1174, 200);
                Console.Beep(1046, 250);
            }

            return; //the return statement is optional for void return type
        }
    }
}