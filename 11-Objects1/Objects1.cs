/// File: Objects1.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Demonstration using Person object
    /// </summary>
    internal class Objects1
    {
        /// <summary>
        /// Entry point for program
        /// </summary>
        static void Main()
        {
            //Create a Person object using default constructor
            Person a = new Person();

            //Create a Person object using parameterized constructor
            Person b = new Person("Snerfle", "Burf", 20);

            //The Person object gives public access to its fields,
            //so we can get (access) and set (mutate) them directly
            Console.WriteLine($"a = {a.firstName} {a.lastName} {a.age}");
            Console.WriteLine($"b = {b.firstName} {b.lastName} {b.age}");

            //Since the object reference a was set up with default values,
            //we might want to change them later
            a.firstName = "Lucy";
            a.lastName = "Goosey";
            a.age = 42;

            //Print the Person object again, noting the changes to the object
            Console.WriteLine($"a = {a.firstName} {a.lastName} {a.age}");
        }
    }
}