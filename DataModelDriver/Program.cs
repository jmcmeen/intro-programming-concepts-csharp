// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using DataModels;

namespace DataModelDriver
{
    internal class Program
    {
        static void Main()
        {
            Dice dice = new Dice();

            Console.WriteLine("Rolling a d6 10 times");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dice.Roll());
            }

            dice = new Dice(20);

            Console.WriteLine("Rolling a d20 10 times");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dice.Roll());
            }
        }
    }
}