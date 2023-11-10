namespace _12_3_ObjectsInTheWild
{
    internal class Triangle1
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle1()
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;
        }

        public Triangle1(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2; // Semi-perimeter
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
    }
}
