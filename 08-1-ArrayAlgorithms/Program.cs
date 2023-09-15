/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace ArrayAlgorithms
{
    /// <summary>
    /// A program to demonstrate common array algorithms
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //In class lab
        }

        /// <summary>
        /// Sort array with basic bubble sort algorithm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(array, j, j - 1);
                    }
                }
            }
        }

        /// <summary>
        /// Sort array with optimized bubble sort algorithm
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        public static void OptimizedBubbleSort(int[] array)
        {
            bool isSorted;
            for (int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Swaps two values in an array at the specified indicies
        /// </summary>
        /// <param name="array">The source array</param>
        /// <param name="index1">The first index</param>
        /// <param name="index2">The second index</param>
        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        /// <summary>
        /// Searches an array for a specified value using linear search algorithm
        /// </summary>
        /// <param name="array">The array to be searched</param>
        /// <param name="searchTerm">The value to search for</param>
        /// <returns>The index of the location of the searchTerm, -1 if not found</returns>
        public static int LinearSearch(int[] array, int searchTerm)
        {
            int foundIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchTerm)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        /// <summary>
        /// Searches a sorted array for a specified value using linear search algorithm
        /// </summary>
        /// <param name="array">The sorted array to be searched</param>
        /// <param name="searchTerm">The value to search for</param>
        /// <returns>The index of the location of the searchTerm, -1 if not found</returns>
        public static int BinarySearch(int[] array, int searchTerm)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid;

            while (high >= low)
            {
                mid = (low + high) / 2;

                if (array[mid] == searchTerm)
                {
                    return mid;
                }
                else if (searchTerm < array[mid])
                {
                    high = mid - 1;
                }
                else if (searchTerm > array[mid])
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}