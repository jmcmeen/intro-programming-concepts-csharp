namespace _11_2_DefiningObjects
{
    /// <summary>
    /// Models a rectangle
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// width of rectangle
        /// </summary>
        public double width;

        /// <summary>
        /// height of rectangle
        /// </summary>
        public double height;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Rectangle()
        {
            width = 1;
            height = 1;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="width">rectangle width</param>
        /// <param name="height">rectangle height</param>
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        /// <returns>the rectangle area</returns>
        public double CalculateArea()
        {
            return width * height;
        }
    }
}
