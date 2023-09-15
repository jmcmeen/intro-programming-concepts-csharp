/// File: Person.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace _10_Objects1
{
    /// <summary>
    /// Models a Person object
    /// </summary>
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            LastName = "Jenkins";
            FirstName = "Leroy";
            Age = 42;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="lastName">The last name of the Person</param>
        /// <param name="firstName">The first name of the Person</param>
        /// <param name="age">The age of the Person</param>
        public Person(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
        }
    }
}
