namespace _12_3_ObjectsInTheWild
{
    internal class Triangle2
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle2()
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;
        }

        public Triangle2(double sideA, double sideB, double sideC)
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

        //Getters (Accessors)
        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double GetSideC()
        {
            return sideC;
        }

        //Setters (Mutators)
        public void SetSideA(double sideA)
        {
            this.sideA = sideA;
        }

        public void SetSideB(double sideB)
        {
            this.sideB = sideB;
        }

        public void SetSideC(double sideC)
        { 
            this.sideC = sideC;
        }
    }
}
