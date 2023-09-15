/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples

namespace Util
{
    public class Prompt
    {
        /// <summary>
        /// Prompts the user for an int value
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int ForInt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static float ForFloat(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToSingle(input);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static double ForDouble(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToDouble(input);
        }
    }
}