// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace DataModels;

/// <summary>
/// Models a Person object
/// </summary>
public class Person
{
    /// <summary>
    /// Person's family name (last name)
    /// </summary>
    public string? FamilyName { get; set; }

    /// <summary>
    /// Person's given name (first name)
    /// </summary>
    public string? GivenName { get; set; }

    /// <summary>
    /// Person's age
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Person() { }

    /// <summary>
    /// Parameterized constructor
    /// </summary>
    /// <param name="familyName">The last name of the Person</param>
    /// <param name="lastName">The first name of the Person</param>
    /// <param name="age">The age of the Person</param>
    public Person(string familyName, string lastName, int age)
    {
        FamilyName = familyName;
        GivenName = lastName;
        Age = age;
    }

    /// <summary>
    /// Creates a string for a Person
    /// </summary>
    /// <returns>Person as a string</returns>
    public override string ToString()
    {
        return $"{FamilyName}, {GivenName} - {Age}";
    }
}
