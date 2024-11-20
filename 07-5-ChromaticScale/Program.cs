namespace _07_5_ChromaticScale
{
    /// <summary>
    /// Program class for Main method
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            if (OperatingSystem.IsWindows())
            {
                const float TWELFTH_ROOT_OF_TWO = 1.05946309436f;
                float freq = 55.0f;

                Console.WriteLine(freq);

                for (int i = 0; i < 84; i++)
                {
                    freq = freq * TWELFTH_ROOT_OF_TWO;
                    Console.WriteLine(freq);
                    Console.Beep((int)freq, 50);
                }
            }
            else
            {
                Console.WriteLine("OS not supported");
            }
        }
    }
}