/// File: ReferenceTypes.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace _12_ReferenceTypes
{
    /// <summary>
    /// Demonstration of reference types and various concerns when working with references
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point for program
        /// </summary>
        static void Main()
        {
            //First value types
            //The line below defines a memory location called i and what is stored there is a value, 12
            int i = 12;

            //The line below defines a reference to a memory location called person for a Person object
            Person person;

            //In this case, we have defined a reference for a Person object, but not allocated new memory
            //Reference types require you to allocate memory with the new keyword
            person = new Person("Burf", "Snerfle", 20);

            //Now we have a memory location called person, that holds a reference to another memory location
            //where the Person object's attributes are stored. Since C# is a memory managed language,
            //if you reuse the person reference, such as in the code below, the old memory containing Burf Snerfle
            //is automatically garbage collected (deleted/deallocated), and replaced with new memory (allocated) for the
            //new Person object
            person = new Person("Lucy", "Goosey", 56);

            //One must take care when using refernce types and the assignment operator (=)
            //Let's look at value types again
            int a = 12;
            int b = 0;

            //If we use the assignment operator with two value types, the value are copied. In the example
            //below, the value of a is copied into b
            b = a;

            Console.WriteLine($"a = {a}, b = {b}");

            //So the same thing happens with reference types, except what a reference type stores is a memory
            //address, so when you use the assignment operator, you copy an address in memory and now two
            //references point to the same object. The example below is not allocating new memory for
            //personB, but rather now both personA and personB point to the same place in memory
            Person personA = new Person("Douglas", "Adams", 42);
            Person personB = personA;

            Console.WriteLine($"{personA.firstName} {personA.lastName} {personA.age}");
            Console.WriteLine($"{personB.firstName} {personB.lastName} {personB.age}");

            //If you make a changes to personA, they are reflected in the personB reference, because they are not
            //two objects, but rather two references pointing to the same object
            personA.firstName = "Not";
            personA.lastName = "New Memory";

            //Print the values using the personB reference
            Console.WriteLine($"{personA.firstName} {personA.lastName} {personA.age}");
            Console.WriteLine($"{personB.firstName} {personB.lastName} {personB.age}");
        }
    }
}