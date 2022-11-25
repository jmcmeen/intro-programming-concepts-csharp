/// File: Objects5.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration of an Item class using classic OOP getters and setters
    /// Do not use this example for this course, we will use C# properties instead.
    /// See Item class' summary
    /// </summary>
    internal class Objects5
    {
        /// <summary>
        /// An entry point for the program
        /// </summary>
        static void Main()
        {
            //Create an Item object
            Item a = new Item("Wand of Doom", 29.99);

            //Use getters to access Item's attributes
            Console.WriteLine($"{a.GetName()} {a.GetValue()}");

            //Use setters to mutate, or change, the Item's attributes
            a.SetName("Hammer of Fate");
            a.SetValue(39.99);

            //Notice the values in the Item object have changed
            Console.WriteLine($"{a.GetName()} {a.GetValue()}");
        }
    }
}