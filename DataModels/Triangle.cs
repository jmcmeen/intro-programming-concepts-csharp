// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace DataModels;

public class Triangle
{
    public double sideA { get; }
    public double sideB { get; }
    public double sideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Invalid triangle sides");
        }

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public double CalculateArea()
    {
        double s = (sideA + sideB + sideC) / 2; // Semi-perimeter
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }
}
