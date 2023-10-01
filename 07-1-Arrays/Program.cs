/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate arrays
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //declaring an int array and instantiating the array
            int[] myNums = new int[5];

            //indivisually assign a value to each
            myNums[0] = 1;
            myNums[1] = 2;
            myNums[2] = 4;
            myNums[3] = 8;
            myNums[4] = 16;

            //walk through the array using for loop
            for (int i = 0; i < myNums.Length; i++)
            {
                Console.WriteLine($"{i} = {myNums[i]}");
            }

            Console.WriteLine();

            //walk through the array using a foreach
            foreach(int num in myNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //If you already have the values you want to store in mind, you can optionally create an array like this.
            int[] myNums2 = {8, 6, 7, 5, 3, 0, 9 };
            PrintArrayOnOneLine(myNums2);
        }

        static void PrintArrayOnOneLine(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}