/// <summary>
/// File: Car.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
/// </summary>
namespace CISP1010
{
    /// <summary>
    /// Models a Car object
    /// </summary>
    internal class Car
    {
        //Private attributes
        private string color;
        private string make;
        private string model;
        private double price;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="color">The color of the Car</param>
        /// <param name="make">The make of the Car</param>
        /// <param name="model">The model of the Car</param>
        /// <param name="price">The price of the Car</param>
        public Car(string color, string make, string model, double price)
        {
            this.color = color;
            this.make = make;
            this.model = model;
            this.price = price;
        }

        #region Public Properties
        //Here we define public properties for private attributes
        public string Color { get => color; set => color = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public double Price { get => price; set => price = value; }
        #endregion
    }
}
