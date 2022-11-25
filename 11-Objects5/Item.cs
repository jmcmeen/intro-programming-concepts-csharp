/// File: Item.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Models an Item object
    /// Note: This object demonstrates classic getters and setters
    ///       and does not use C# properties. You might see this
    ///       in other OOP lanaguages. When using C#, properties
    ///       are recommended as they generally require less
    ///       lines of code. This is only included to demonstrate
    ///       how this was handled in OOP langauges without 
    ///       a properties feature.
    /// </summary>
    internal class Item
    {
        private string name;
        private double value;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">The name of the Item</param>
        /// <param name="value">The value of the Item</param>
        public Item(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Sets the Item's name
        /// </summary>
        /// <param name="name">The Item's name</param>
        public void SetName(string name) 
        { 
            this.name = name; 
        }

        /// <summary>
        /// Gets the Item's name
        /// </summary>
        /// <returns>The Item's name</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the Item's value
        /// </summary>
        /// <param name="value">The Item's value</param>
        public void SetValue(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Gets the Item's value
        /// </summary>
        /// <returns>The Item's value</returns>
        public double GetValue()
        {
            return value;
        }
    }
}
