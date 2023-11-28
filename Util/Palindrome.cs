namespace Util
{
    public static class Palindrome
    {
        public static bool IsPalindrome1(string testString)
        {
            char[] chars = testString.ToCharArray();
            char[] reversedChars = testString.ToCharArray();
            Array.Reverse(reversedChars);
            string reversedTestString = new string(reversedChars);
            return reversedTestString == testString;
        }

        public static bool IsPalindrome2(string testString)
        {
            char[] chars = testString.ToCharArray();
            int low = 0;
            int high = chars.Length - 1;

            while (low <= high)
            {
                if (chars[low] != chars[high])
                {
                    return false;
                }

                low++;
                high--;
            }

            return true;
        }
    }
}
