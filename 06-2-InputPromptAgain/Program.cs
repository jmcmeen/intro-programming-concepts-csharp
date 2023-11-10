/// john mcmeen
/// jnmcmeen@northeaststate.edu

namespace _06_2_InputPromptAgain
{
    /// <summary>
    /// Demonstrates do-while loops, input looping, reprompting
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            const int MIN_VALUE = 1;
            string tempInput;
            int numDice;

            //Prompt for a value and if it is acceptable, break out of the loop, otherwise, prompt again
            do
            {
                //Prompt user
                Console.Write($"Enter a number of dice to roll greater than or equal to {MIN_VALUE}: ");
                tempInput = Console.ReadLine();
                numDice = Convert.ToInt32( tempInput );

            }while( numDice < MIN_VALUE );

            Console.WriteLine( $"You entered {numDice}\n\n" );


            //We could do a little better and actually tell our user why we are asking again
            do
            {
                Console.Write($"Enter a number of dice to roll greater than or equal to {MIN_VALUE}: ");
                tempInput = Console.ReadLine();
                numDice = Convert.ToInt32(tempInput);

                //if a bad value, say so
                if(numDice < MIN_VALUE)
                {
                    Console.WriteLine($"{numDice} is not greater than or equal to {MIN_VALUE}, try again.");
                }

            } while (numDice < MIN_VALUE);

            Console.WriteLine($"You entered {numDice}\n\n");

            //We can still do better using a method for prompting, borrowed the Program.cs file
            //Notice how by abstracting prompting to a method, this while loop has less code in it and is easier to read (IMHO) :P
            do
            {
                numDice = Prompt.ForInt($"Enter a number of dice to roll greater than or equal to {MIN_VALUE}: ");

                if (numDice < MIN_VALUE)
                {
                    Console.WriteLine($"{numDice} is not greater than or equal to {MIN_VALUE}, try again.");
                }

            } while (numDice < MIN_VALUE);

            Console.WriteLine($"You entered {numDice}\n\n");

            //Lastly, we could be completely classless and ungovernable by using while true and using a break statement if we get a good value
            //I don't like this, but in cases where you may have several exit conditions, it is a way to do it...
            do
            {
                numDice = Prompt.ForInt($"Enter a number of dice to roll greater than or equal to {MIN_VALUE}: ");

                if (numDice < MIN_VALUE)
                {
                    Console.WriteLine($"{numDice} is not greater than or equal to {MIN_VALUE}, try again.");
                }
                else
                {
                    break;
                }

            } while (true); //dangerous games, don't forget to break somewhere!

            Console.WriteLine($"You entered {numDice}\n\n");
        }
    }
}