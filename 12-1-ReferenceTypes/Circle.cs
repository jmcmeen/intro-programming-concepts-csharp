// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _12_1_ReferenceTypes
{
    /// <summary>
    /// Models a circle
    /// </summary>
    internal class Circle
    {
        /// <summary>
        /// radius of circle
        /// </summary>
        public double radius;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle
        /// </summary>
        /// <returns>the circles's area</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
