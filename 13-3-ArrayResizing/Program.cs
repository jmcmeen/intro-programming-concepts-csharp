namespace _13_3_ArrayResizing
{
    internal class Program
    {
        static void Main()
        {
            int[] myArray = new int[1];

            myArray[0] = 1;
            PrintArray(myArray);

            myArray = AppendValue(myArray, 3);
            PrintArray(myArray);

            myArray = AppendValue(myArray, 5);
            PrintArray(myArray);

            myArray = AppendValue(myArray, 6);
            PrintArray(myArray);
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static int[] AppendValue(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[^1] = value;

            return newArray;
        }
    }
}
