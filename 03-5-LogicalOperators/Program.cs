namespace CISP1010
{
    /// <summary>
    /// A program to demonstrate Boolean logical operators
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Declare some variables to use in this program
            bool aBool = true;
            bool anotherBool = true;
            bool theFinalBool = false;
            int intValue = 1;

            //Logical operators are gernerally used in if statements and loops to evaluate some logical condition
            //If blocks only evaluate if the expression in true
            if (aBool)
            {
                Console.WriteLine("The value of true1 is " + aBool);
            }

            //Logical operators allow us to combine logic operations

            //Demonstrate logical AND - && - returns true if both statements are true
            if (aBool && anotherBool)
            {
                Console.WriteLine("Both statements are true");
            }

            //the following if block will be skipped because one statement is false
            if (aBool && theFinalBool)
            {
                Console.WriteLine("I won't be printed because AND logic");
            }

            //the following if block will be skipped because one statement is false
            if (theFinalBool && theFinalBool)
            {
                Console.WriteLine("I won't be printed because AND logic");
            }

            //Demonstrate logical OR - || - returns true if one statement is true
            if (aBool || anotherBool)
            {
                Console.WriteLine("At lease one statement is true");
            }
            //This block is true
            if (aBool || theFinalBool)
            {
                Console.WriteLine("At lease one statement is true");
            }
            //This block will be skipped
            if (theFinalBool || theFinalBool)
            {
                Console.WriteLine("I won't be printed because OR logic");
            }

            //Demonstrate logical NOT - ! - reverse boolean value
            if (!theFinalBool)
            {
                Console.WriteLine("Not false is true");
            }

            //This will be skipped because it is not true
            if (!aBool)
            {
                Console.WriteLine("I won't be printed because not true is false");
            }

            //You more than likely will not be testing boolean values, but rather other expressions and statements
            if (intValue > 0 && intValue != 2)
            {
                Console.WriteLine(intValue + " is greater than 0 and is not equal to 2");
            }

            if (intValue > 0 && intValue != 1)
            {
                Console.WriteLine("I will be skipped because intValue is equal to 1 and both conditions in an AND must be true");
            }

            //Here are some examples with OR, only one of the conditions below is true
            if (intValue < 0 || intValue > 0)
            {
                Console.WriteLine(intValue + " is less than 0 or greater than 0");
            }

            //What would happen if intValue was equal to 0
            intValue = 0;
            if (intValue < 0 || intValue > 0)
            {
                Console.WriteLine("This will be skipped because both statements are false now");
            }
        }
    }
}