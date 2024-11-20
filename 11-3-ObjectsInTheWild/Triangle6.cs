namespace _11_3_ObjectsInTheWild
{
    internal class Triangle6
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get => _sideA;
            set => _sideA = value;
        }
        public double SideB
        {
            get => _sideB;
            set => _sideB = value;
        }
        public double SideC
        {
            get => _sideC;
            set => _sideC = value;
        }

        public double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2; // Semi-perimeter
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public Triangle6(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
    }
}
