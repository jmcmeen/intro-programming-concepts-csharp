// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples
// Resources: https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type

namespace _12_1_ReferenceTypes
{
    /// <summary>
    /// Demonstrates differences in value types and reference types
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Value types store values, when copying a value from one to another they are independent
            int x = 1;
            int y = x;

            Console.WriteLine($"the value of x is {x}");
            Console.WriteLine($"the value of y is {y}\n");

            //Changes to one doesn't effect the other because they are separate variables and values
            x = 2;
            Console.WriteLine($"the value of x is {x}");
            Console.WriteLine($"the value of y is {y}\n");

            //Remembering back to pass by value parameters, this is why copies were independent

            //When you pass a value-type variable from one method to another,
            //the system creates a separate copy of the variable's value in another method.
            //If the value is changed in the one method, it doesn't affect the
            //value in another method. 
            y = 1;
            Console.WriteLine($"the value of y is {y}");
            TryToChangeValueType(y);
            Console.WriteLine($"the value of y is {y}\n");

            //Reference types store values too, except their values are memory addresses to the start of the data segment
            //for that object in memory. This means when copying the value of one reference type
            //variable to another, both references will point to the same place in memory. In this case, each reference
            //points to one thing, not independent values

            //Consider this Circle with a radius of 1
            Circle circle = new Circle(1);
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}\n");

            //Lets create a new reference variable but assign it circle (instead of newing up memory)
            Circle circleCopy = circle;

            //It would appear we now have two circles
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}");
            Console.WriteLine($"circleCopy has a radius of {circleCopy.radius} and an area of {circleCopy.CalculateArea()}\n");

            //But let's make a change to the circle reference only and observe their states
            circle.radius = 2;
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}");
            Console.WriteLine($"circleCopy has a radius of {circleCopy.radius} and an area of {circleCopy.CalculateArea()}\n");

            //Both references changed? No, only one object exists and these reference both point to it
            //Let's make a change to circleCopy
            circleCopy.radius = 4;
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}");
            Console.WriteLine($"circleCopy has a radius of {circleCopy.radius} and an area of {circleCopy.CalculateArea()}\n");

            //Just like arrays before, when reference types are passed to a method, it is still true
            //that the system creates a separate copy of the variable's value.
            //Hower reference types' values are references to a location in memory.
            //So that copy you get in the method call is pointing to the same place in
            //memory as the variable in the calling method. 
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}");
            TryToChangeReferenceType(circle);
            Console.WriteLine($"circle has a radius of {circle.radius} and an area of {circle.CalculateArea()}");
            Console.WriteLine($"circleCopy has a radius of {circleCopy.radius} and an area of {circleCopy.CalculateArea()}\n");
        }

        /// <summary>
        /// Demnonstrates pass by value
        /// </summary>
        /// <param name="anInt">an integer value</param>
        static void TryToChangeValueType(int anInt)
        {
            Console.WriteLine($"the value of anInt is {anInt}");
            anInt = 42;
            Console.WriteLine($"the value of anInt is {anInt}");
        }

        /// <summary>
        /// Demnonstrates pass by value w/ a reference type
        /// </summary>
        /// <param name="c"></param>
        static void TryToChangeReferenceType(Circle c)
        {
            Console.WriteLine($"c has a radius of {c.radius} and an area of {c.CalculateArea()}");
            c.radius = 2;
            Console.WriteLine($"c has a radius of {c.radius} and an area of {c.CalculateArea()}");
        }
    }
}