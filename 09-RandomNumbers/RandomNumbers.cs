/// <summary>
/// File: RandomNumbers.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
/// </summary>
namespace CISP1010
{
    internal class RandomNumbers
    {
        static void Main(string[] args)
        {
            //create a object of type Random
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The next random in is {r.Next()}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(RollDice(6));
            }
        }

        static uint RollDice(uint numSides)
        {
            Random r = new Random();
            int temp = r.Next(1, Convert.ToInt32(numSides + 1));
            uint output = Convert.ToUInt32(temp);
            return output;
        }

    }
}