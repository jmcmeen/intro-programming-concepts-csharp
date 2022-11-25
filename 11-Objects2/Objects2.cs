/// <summary>
/// File: Objects2.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
/// </summary>
namespace CISP1010
{
    /// <summary>
    /// Demonstration using Car object
    /// </summary>
    internal class Objects2
    {
        /// <summary>
        /// Entry point for program
        /// </summary>
        static void Main()
        {
            //Car a = new Car(); Car does not have a default constructor defined, so we can not use it

            //We must use the parameterized constructor defined
            Car a = new Car("red", "ford", "taurus", 1299.99);

            //Car has private fields, so we must use the public properties defined to get (access) or set (mutate) values
            //a.color will not work because color is private, but a.Color is public
            Console.WriteLine($"{a.Color} {a.Make} {a.Model} ${a.Price}");

            //The public properties for Car define both get (access) and set (mutate) properties
            //Here was can use the properties to set the values in a Car
            a.Color = "black";
            a.Price = 1199.99;

            //Notice the color and price of the Car changed
            Console.WriteLine($"{a.Color} {a.Make} {a.Model} ${a.Price}");
        }
    }
}