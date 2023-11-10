// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _11_2_DefiningObjects
{
    internal class Rectangle
    {
        public double width;
        public double height;

        public Rectangle()
        {
            width = 1;
            height = 1;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }
}
