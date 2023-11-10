namespace _11_0_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5.1;
            double y = 2.4;

            double area = CalculateRectangleArea(x, y);

            Rectangle rectangle1 = new Rectangle();
            rectangle1.width = 10;
            rectangle1.height = 11;

            Rectangle rectangle2 = new Rectangle();

            Rectangle rectangle3 = new Rectangle(2.5, 6.5);

            area = rectangle1.CalculateArea();

            Thread.Sleep(100);

            //Math class is not an instatiated class, it is a static  class
            Math.Min(5, 8);
            Console.WriteLine();

            ////Here are some instantiated classes, otherwise called Object
            string s = "Hello World";
            String myString = new String("Hello World");
            Console.WriteLine(myString);
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString);

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.NextDouble()); 
            Console.WriteLine(random.NextInt64());

            DateTime date = new DateTime();
            Console.WriteLine(date.AddDays(1));
            Console.WriteLine(date.AddDays(10000));
            Console.WriteLine(date);
        }

        public static double CalculateRectangleArea(double width, double length)
        {
            return width * length;
        }
    }
}