namespace CISP1010
{
    class Experimental
    {
        static void Main(string[] args)
        {
            string message = "Hello, Neo\n\n";

            ConsoleUtilities.PrintColor(message, ConsoleColor.Red);
            ConsoleUtilities.PrintRainbow(message);
            ConsoleUtilities.PrintRainbow(ConsoleUtilities.RandomizeCase(message));
            ConsoleUtilities.PrintRainbow(ConsoleUtilities.AlternateCase(message));
            ConsoleUtilities.PrintRainbowScroll(message, 50);
            ConsoleUtilities.PrintScroll(message, 100, ConsoleColor.Green);
        }
    }
}