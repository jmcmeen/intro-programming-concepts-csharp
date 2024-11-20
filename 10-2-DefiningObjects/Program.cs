namespace _10_2_DefiningObjects
{
    /// <summary>
    /// Demonstrates using a custom created object and procedural vs. object oriented programming
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //In procedural programming, we have to feed methods all the data they need to be useful
            double x = 5.1;
            double y = 2.4;

            double area = Program.CalculateRectangleArea(x, y);

            //In object oriented programming, we create instances of classes, called objects (instantiation)
            Rectangle rectangle1 = new Rectangle();
            rectangle1.CalculateArea();

            //We then store and manipulate data in objects (encapsulation)
            rectangle1.width = 10;
            rectangle1.height = 11;

            //We can then call on the object to perform actions, or behaviors, against the data stored in them
            area = rectangle1.CalculateArea();

            Console.WriteLine($"the area of rectangle1 is {area}");

            //Each object stores its own data, so each instance is unique.
            //Here we are using the default constructor Rectangle().
            Rectangle rectangle2 = new Rectangle();

            area = rectangle2.CalculateArea();

            Console.WriteLine($"the area of rectangle2 is {area}");

            //Here we are using the parameterized constructor Rectangle(double,double)
            Rectangle rectangle3 = new Rectangle(2.5, 6.5);

            area = rectangle3.CalculateArea();

            Console.WriteLine($"the area of rectangle3 is {area}");

            Rectangle[] rectangles = { rectangle1, rectangle2, rectangle3 };

            for ( int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].width = rectangles[i].width * 2;
                rectangles[i].width = rectangles[i].width * 2;
                Console.WriteLine(rectangles[i].CalculateArea());
            }
        }

        /// <summary>
        /// Calculates the area of a rectangle
        /// </summary>
        /// <param name="width">width of the rectangle</param>
        /// <param name="length">length of the rectangle</param>
        /// <returns>the area of the rectangle</returns>
        static double CalculateRectangleArea(double width, double length)
        {
            return width * length;
        }
    }
}