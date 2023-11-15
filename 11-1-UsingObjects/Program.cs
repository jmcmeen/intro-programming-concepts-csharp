// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _11_0_Objects
{
    internal static class Program
    {
        static void Main()
        {
            //Classes like Thread, Math, and Console have static methods and properties
            //which means you call the methods from the class name -> Console.WriteLine();
            Console.Title = "Using Objects";
            Console.WriteLine("Sleeping one second...");
            Thread.Sleep(1000);
            Math.Min(5, 8);
            Console.WriteLine();

            //Other classes need to be instantiated into Objects, usually because they hold
            //internal state data unique to each instance of an object. Here are some examples of using objects

            //String/string
            string s = "Hello World"; //despite seeing strings defined like this, they are objects
            string myString = new string("Hello World");
            String anotherString = new String("Another"); //string and String are equivalent
            Console.WriteLine(myString);
            Console.WriteLine(myString.ToUpper()); // notice ToUpper return a completely new object referece, does not change the original object reference
            Console.WriteLine(myString);

            //Random
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextInt64());

            //DateTime (DateTime is technically a Struct, more on that later)
            DateTime date = new DateTime();
            Console.WriteLine(date.AddDays(1));
            Console.WriteLine(date.AddDays(10000));
            Console.WriteLine(date);
        }
    }
}