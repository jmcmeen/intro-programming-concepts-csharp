namespace _12_3_ObjectsInTheWild
{
    internal class Triangle3
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle3(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2; // Semi-perimeter
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
