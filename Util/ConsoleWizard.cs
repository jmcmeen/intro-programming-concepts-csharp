// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace Util
{
    /// <summary>
    /// Collection of static methods for Console manipulation
    /// </summary>
    public static class ConsoleWizard
    {
        /// <summary>
        /// Gets a random ConsoleColor except black
        /// </summary>
        /// <returns>random ConsoleColor</returns>
        public static ConsoleColor GetRandomColor()
        {
            return (ConsoleColor)new Random().Next(1, 16);
        }

        /// <summary>
        /// Prints one character in a given color
        /// </summary>
        /// <param name="color">char color</param>
        /// <param name="c">char to print</param>
        public static void PrintCharacter(ConsoleColor color, char c)
        {
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        /// <summary>
        /// Prints a string in rainbow colors
        /// </summary>
        /// <param name="message"></param>
        public static void PrintRainbow(string message)
        {
            foreach (char c in message)
            {
                PrintCharacter(GetRandomColor(), c);
            }
        }

        /// <summary>
        /// Randomizes the case of a string
        /// </summary>
        /// <param name="inputString">the string to randomize case</param>
        /// <returns>a string with case randomized</returns>
        public static string RandomizeCase(string inputString)
        {
            Random r = new Random();
            string newString = "";

            foreach (char c in inputString)
            {
                if (r.Next() % 2 == 0)
                {
                    newString += c.ToString().ToUpper();
                }
                else
                {
                    newString += c.ToString().ToLower();
                }
            }

            return newString;
        }

        /// <summary>
        /// Converts the string to alternate cased
        /// </summary>
        /// <param name="inputString">the string to convert</param>
        /// <returns>the converted string</returns>
        public static string AlternateCase(string inputString)
        {
            ulong counter = 0;
            string newString = "";

            foreach (char c in inputString)
            {
                if (counter % 2 == 0)
                {
                    newString += c.ToString().ToUpper();
                }
                else
                {
                    newString += c.ToString().ToLower();
                }

                counter++;
            }

            return newString;
        }

        /// <summary>
        /// Prints scrolling text with rainbow color
        /// </summary>
        /// <param name="message">message to print</param>
        /// <param name="waitTime"> time to wait betwen each character</param>
        public static void PrintRainbowScroll(string message, int waitTime)
        {
            foreach (char c in message)
            {
                PrintCharacter(GetRandomColor(), c);
                Thread.Sleep(waitTime);
            }
        }

        /// <summary>
        /// Prints a scrolling message
        /// </summary>
        /// <param name="message">the message to print</param>
        /// <param name="waitTime">time to wait between each character</param>
        /// <param name="color">text color</param>
        public static void PrintScroll(string message, int waitTime, ConsoleColor color)
        {
            foreach (char c in message)
            {
                PrintCharacter(color, c);
                Thread.Sleep(waitTime);
            }
        }

        /// <summary>
        /// Print a message in a given color
        /// </summary>
        /// <param name="message">The message to print</param>
        /// <param name="color">text color</param>
        public static void PrintColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
        }

        /// <summary>
        /// Wait for the user to press a key
        /// </summary>
        /// <param name="color">color for message text</param>
        public static void PressAnyKey(ConsoleColor color)
        {
            PrintColor("Press any key to continue", color);
            Console.ReadKey();
        }
    }
}
