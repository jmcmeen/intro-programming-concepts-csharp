namespace _08_1_Arrays
{
    /// <summary>
    /// A program to demonstrate arrays
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //declaring an int array of size 5 and instantiating the array
            int[] myNums;

            myNums = new int[5];

            //you can have arrays of any type, although myNums is use in this example
            string[] myNames = new string[42];
            char[] mychars = new char[100];

            /*------------------manual access-------------------*/
            //individually assign a value to each
            myNums[0] = 1;
            myNums[1] = 2;
            myNums[2] = 4;
            myNums[3] = 8;
            myNums[4] = 16;
            //myNums[5] = 32; //This will throw an out of range exception

            //manually print each value
            Console.WriteLine(myNums[0]);
            Console.WriteLine(myNums[1]);

            Console.WriteLine($"{myNums[0]},{myNums[1]},{myNums[2]},{myNums[3]},{myNums[4]}");
            
            Console.WriteLine($"myNums length is {myNums.Length}\n");

            /*------------------for-loop access----------------------*/

            //or walk through the array using for loop
            Console.WriteLine();

            for (int i = 0; i < myNums.Length; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            
            Console.WriteLine();

            for (int i = 0; i < myNums.Length; i++)
            {
                Console.WriteLine($"myNums[{i}] = {myNums[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < myNums.Length; i++)
            {
                Console.WriteLine($"Setting index {i}'s value to {i * 5}");
                myNums[i] = i * 5;
            }

            Console.WriteLine();

            //walk through the array using a foreach
            foreach (int num in myNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //If you already have the values you want to store in mind, you can optionally create an array like this.
            int[] myNums2 = { 8, 6, 7, 5, 3, 0, 9 };

            PrintArrayOnOneLine(myNums2);
            WhatHappensHere(myNums2);
            PrintArrayOnOneLine(myNums2);
        }

        /// <summary>
        /// Prints an array of integers to one line
        /// </summary>
        /// <param name="array">an int array</param>
        static void PrintArrayOnOneLine(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Changes array values of the original reference because array has a copied value of the reference from Main
        /// </summary>
        /// <param name="array"></param>
        static void WhatHappensHere(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
        }
    }
}