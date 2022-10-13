﻿namespace CISP1010
{
    /// <summary>
    /// An example program that creates a simple menu using a switch statement
    /// and static methods
    /// </summary>
    internal class SimpleMenu
    {
        /// <summary>
        /// Entry point for the application
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            char choice;
            do
            {
                choice = ShowMenu();

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("\nYou picked choice one!\n");
                        break;
                    case '2':
                        Console.WriteLine("\nYou picked choice two!\n");
                        break;
                    case '3':
                        Console.WriteLine("\nBye!\n");
                        break;
                }

            } while (choice != '3');
        }

        /// <summary>
        /// Shows a menu and prompts the user for a choice
        /// </summary>
        /// <returns>The key character pressed by the user</returns>
        static char ShowMenu()
        {
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit\n");

            return PromptForChar("choice->") ;
        }
        
        /// <summary>
        /// Prints a prompt and waits for the user to press a key
        /// </summary>
        /// <param name="messagePrompt">The displayed prompt</param>
        /// <returns>The character key pressed by the user</returns>
        static char PromptForChar(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Console.ReadKey().KeyChar;
        }
    }
}