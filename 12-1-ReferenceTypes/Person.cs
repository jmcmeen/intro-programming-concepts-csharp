/// File: Person.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace _12_ReferenceTypes
{
    /// <summary>
    /// Models a Person object
    /// </summary>
    internal class Person
    {
        public string lastName;
        public string firstName;
        public int age;


        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="lastName">The last name of the Person</param>
        /// <param name="firstName">The first name of the Person</param>
        /// <param name="age">The age of the Person</param>
        public Person(string lastName, string firstName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
        }
    }
}
