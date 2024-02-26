namespace _14_1_Exceptions
{
    /// <summary>
    /// Program that demonstrates Exceptions
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            try
            {
                Console.Write("Enter a number to divide by: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = 10 / x;
                Console.Write(y);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine("Yo, you messed up.");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
            try
            {
                SomeMethod(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "\n");
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine(ex.StackTrace + "\n");
            }

            try
            {
                Convert.ToDouble("t");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <exception cref="Exception"></exception>
        static void SomeMethod(int x)
        {
            if (x == 0)
            {
                throw new Exception("I don't like the value 0, it offends me.");
            }

            Console.WriteLine("Doing my things here without worrying about 0's");
        }
    }
}