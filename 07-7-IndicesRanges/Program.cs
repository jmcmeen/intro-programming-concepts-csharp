namespace _07_7_IndicesRanges
{
    /// <summary>
    /// Demonstration of negative array indices and ranges
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Indices let you refer to elements relative to the end of an array by using the ^ operator.
            //^1 refers to the last element, ^2 refers to the second-to-last element, and so on:
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1];   // 'u'
            char secondToLast = vowels[^2];   // 'o'

            //Ranges let you “slice” an array by using the.. operator:
            char[] firstTwo = vowels[..2];    // 'a', 'e'
            char[] lastThree = vowels[2..];    // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3];    // 'i'
            char[] lastTwo = vowels[^2..];   // 'o', 'u'
        }
    }
}