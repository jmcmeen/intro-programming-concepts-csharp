using Util;
namespace _05_4_ConsoleMagic
{
    /// <summary>
    /// Absolute chaos.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point. 
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            //Methods that demonstrate the use of ConsoleWizard.dll

            //This Visual Studio Project contains a project reference to a class library, Util,
            //which is another project in this solution.

            //Class libraries are .dll file (dynamic link library) which is a precompiled code library.

            //Class libraries can not contain a class with a Main() method.

            //Adding the project reference will move the compiled Util.dll file into the bin directory
            //for this program when this project is compiled, allowing it to use code from that project.
            IntroScreen();
            TheConquererWorm();
            TheButtersShow();
        }

        /// <summary>
        /// Prints the Console Magic intro screen
        /// </summary>
        static void IntroScreen()
        {
            string appName =
            @"
               _____                      _                
              / ____|                    | |               
             | |     ___  _ __  ___  ___ | | ___           
             | |    / _ \| '_ \/ __|/ _ \| |/ _ \          
             | |___| (_) | | | \__ \ (_) | |  __/          
              \_____\___/|_| |_|___/\___/|_|\___| _      _ 
                              |  \/  |           (_)    | |
                              | \  / | __ _  __ _ _  ___| |
                              | |\/| |/ _` |/ _` | |/ __| |
                              | |  | | (_| | (_| | | (__|_|
                              |_|  |_|\__,_|\__, |_|\___(_)
                                             __/ |         
                                            |___/          
            ";

            ConsoleWizard.PrintColor(appName, ConsoleColor.Green);
            ConsoleWizard.PrintScroll("\n\n\t\tPowered by: ", 100, ConsoleColor.Green);
            ConsoleWizard.PrintRainbowScroll("C O N S O L E  W I Z A R D", 200);

            Thread.Sleep(2000);
            Console.Clear();
        }

        /// <summary>
        /// Prints "The Conquerer Worm" by Edgar Allen Poe
        /// </summary>
        static void TheConquererWorm()
        {
            string conquererWorm = @"
    The Conqueror Worm
    BY EDGAR ALLAN POE

    Lo! ’t is a gala night
        Within the lonesome latter years!   
    An angel throng, bewinged, bedight
        In veils, and drowned in tears,   
    Sit in a theatre, to see
        A play of hopes and fears,
    While the orchestra breathes fitfully   
        The music of the spheres.

    Mimes, in the form of God on high,   
        Mutter and mumble low,
    And hither and thither fly—
        Mere puppets they, who come and go   
    At bidding of vast formless things
        That shift the scenery to and fro,
    Flapping from out their Condor wings
        Invisible Wo!

    That motley drama—oh, be sure   
        It shall not be forgot!
    With its Phantom chased for evermore   
        By a crowd that seize it not,
    Through a circle that ever returneth in   
        To the self-same spot,
    And much of Madness, and more of Sin,   
        And Horror the soul of the plot.

    But see, amid the mimic rout,
        A crawling shape intrude!
    A blood-red thing that writhes from out   
        The scenic solitude!
    It writhes!—it writhes!—with mortal pangs   
    The mimes become its food,
    And seraphs sob at vermin fangs
        In human gore imbued.

    Out—out are the lights—out all!   
        And, over each quivering form,
    The curtain, a funeral pall,
        Comes down with the rush of a storm,   
    While the angels, all pallid and wan,   
        Uprising, unveiling, affirm
    That the play is the tragedy, “Man,”   
        And its hero, the Conqueror Worm." + "\n\n";

            string randomCased = ConsoleWizard.RandomizeCase(conquererWorm);

            ConsoleWizard.PrintScroll(randomCased, 5, ConsoleColor.Red);
            ConsoleWizard.PressAnyKey(ConsoleColor.Magenta);
            Console.Clear();
        }

        /// <summary>
        /// Because cherry is the best.
        /// </summary>
        static void TheButtersShow()
        {
            string alternateCased = ConsoleWizard.AlternateCase("\"Cherry is the best flavor of Kool-Aid\" - Butters \n\n");

            for (int i = 0; i < 10; i++)
            {
                ConsoleWizard.PrintRainbow(alternateCased);
            }

            ConsoleWizard.PressAnyKey(ConsoleColor.Magenta);
            Console.Clear();
        }
    }
}