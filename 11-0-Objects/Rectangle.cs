namespace _11_0_Objects
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
