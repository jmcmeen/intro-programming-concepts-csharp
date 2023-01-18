/// File: Objects4.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration using Television object
    /// </summary>
    internal class Objects4
    {
        static void Main()
        {
            //Create a new Television object using default constructor
            Television a = new Television();

            Console.WriteLine("Setting the channel to 42\n");

            //Besides fields and properties, objects can have methods that operate on the object
            //Here we set the channel
            a.SetChannel(42);

            Console.WriteLine(a + "\n");

            Console.WriteLine("Setting the channel to 1000\n");

            //The SetChannel method and Channel property are both designed to prevent the
            //programmer from setting an invalid channel value (here 1000 > MAX_CHANNEL in Television)
            a.Channel = 1000;

            Console.WriteLine(a + "\n");

            //Television also has some methods for incrementing and decrementing channels
            //Here we will demo them in a loop to call each method a given number of times
            Console.WriteLine("Calling ChannelUp() twelve times");
            for(int i = 0; i < 12; i++)
            {
                a.ChannelUp();
                Console.WriteLine(a);
            }

            Console.WriteLine("\nCalling ChannelDown() five times");
            for (int i = 0; i < 5; i++)
            {
                a.ChannelDown();
                Console.WriteLine(a.ToString());
            }
        }
    }
}