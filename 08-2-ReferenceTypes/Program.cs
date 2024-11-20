namespace _08_2_ReferenceTypes
{
    /// <summary>
    /// Demonstration of value types vs reference types
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

            //Arrays are the first distinction we will make as a reference type.

            //Reference types store values too, except their values are memory addresses to the start of the data segment
            //for that structure in memory. This means when copying the value of one reference type
            //variable to another, both references will point to the same place in memory. In this case, each reference
            //points to one thing, not independent values

            //Consider the following double array of size 5.
            double[] doubles = new double[5];

            //fill the array with values
            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = (i + 1) * 1.1;
            }

            //Convert the array toa string and print it
            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}\n");

            //Now let's assign the value of doubles to another reference variable
            double[] doublesCopy = doubles;

            //It would appear we now have two arrays
            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}");
            Console.WriteLine($"doublesCopy -> {DoubleArrayToString(doublesCopy)}\n");

            //But let's make a change to the doubles reference only and observe their states
            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = (i + 1) * 2.2;
            }

            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}");
            Console.WriteLine($"doublesCopy -> {DoubleArrayToString(doublesCopy)}\n");

            //Both references changed? No, only one array exists and these reference both point to it
            //Let's make a change to doublesCopy and observe their state
            for (int i = 0; i < doublesCopy.Length; i++)
            {
                doublesCopy[i] = (i + 1) * 3.3;
            }

            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}");
            Console.WriteLine($"doublesCopy -> {DoubleArrayToString(doublesCopy)}\n");

            //So when reference types are passed to a method, it is still true
            //that the system creates a separate copy of the variable's value.
            //Hower reference types' values are references to a location in memory.
            //So that copy you get in the method call is pointing to the same place in
            //memory as the variable in the calling method. 
            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}");
            TryToChangeReferenceType(doubles);
            Console.WriteLine($"doubles -> {DoubleArrayToString(doubles)}");
            Console.WriteLine($"doublesCopy -> {DoubleArrayToString(doublesCopy)}\n");
        }

        /// <summary>
        /// Demnonstrates pass by value with a value type
        /// </summary>
        /// <param name="anInt">an integer value</param>
        static void TryToChangeValueType(int anInt)
        {
            Console.WriteLine($"the value of anInt is {anInt}");
            anInt = 42;
            Console.WriteLine($"the value of anInt is {anInt}");
        }

        /// <summary>
        /// Demonstrates pass by value with a reference type
        /// </summary>
        /// <param name="doubleArray"></param>
        static void TryToChangeReferenceType(double[] doubleArray)
        {
            Console.WriteLine($"the value of doubleArray is {DoubleArrayToString(doubleArray)}");

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = 0;
            }

            Console.WriteLine($"the value of doubleArray is {DoubleArrayToString(doubleArray)}");
        }

        /// <summary>
        /// Converts a array of doubles to a string
        /// </summary>
        /// <param name="doubleArray">an array of doubles</param>
        /// <returns>a string with each double seperated by a space</returns>
        static string DoubleArrayToString(double[] doubleArray)
        {
            string temp = "";
            foreach (var item in doubleArray)
            {
                temp += item + " ";
            }
            return temp;
        }
    }
}