namespace CISP1010
{
    internal class ConsoleUtilities
    {
        public static ConsoleColor GetRandomColor()
        {
            Random r = new Random();
            ConsoleColor color;

            do
            {
                color = (ConsoleColor)r.Next(16);
            }while(color == ConsoleColor.Black);

            return color;
        }

        public static void PrintCharacter(ConsoleColor color, char c)
        {
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        public static void PrintRainbow(string message)
        {
            foreach(char c in message)
            {
                PrintCharacter(GetRandomColor(), c);
            }
        }

        public static string RandomizeCase(string inputString)
        {
            Random r = new Random();
            string newString = "";

            foreach(char c in inputString)
            {
                if(r.Next() % 2 == 0)
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

        public static void PrintRainbowScroll(string message, int waitTime)
        {
            foreach (char c in message)
            {
                PrintCharacter(GetRandomColor(), c);
                Thread.Sleep(waitTime);
            }
        }

        public static void PrintScroll(string message, int waitTime, ConsoleColor color)
        {
            foreach (char c in message)
            {
                PrintCharacter(color, c);
                Thread.Sleep(waitTime);
            }
        }

        public static void PrintColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
        }
    }
}
