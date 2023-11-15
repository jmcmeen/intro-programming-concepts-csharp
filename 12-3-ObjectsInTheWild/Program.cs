// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples
// Resources: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

namespace _12_3_ObjectsInTheWild
{
    internal static class Program
    {
        static void Main()
        {
            Triangle1 triangle1 = new Triangle1();
            triangle1.sideA = 1;

            Triangle2 triangle2 = new Triangle2();
            triangle2.SetSideA(1);
            triangle2.GetSideA();


            Triangle3 triangle3 = new Triangle3();
            triangle3.SideA = 1;


        }
    }
}