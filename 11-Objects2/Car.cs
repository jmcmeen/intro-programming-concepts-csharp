/// File: Car.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
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
        //Notice C# let's you use a couple different syntaxes to achieve the same goal
        //I prefer the first for properties that require more than one line of code
        //The second is good for one liners
        //The formatting of the last two is common, just moving everything to one line
        //You can chose whichever format you would like in this course
        public string Color 
        { 
            get { return color; } 
            set { color = value; } 
        }
        public string Make 
        { 
            get => make; 
            set => make = value; 
        }
        public string Model { get => model; set => model = value; }
        public double Price { get => price; set => price = value; }
        #endregion
    }
}
