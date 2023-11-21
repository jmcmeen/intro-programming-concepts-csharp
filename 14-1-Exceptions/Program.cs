// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

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
            }

            try
            {
                SomeMethod(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Double.Parse("t");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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