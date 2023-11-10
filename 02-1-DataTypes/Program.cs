// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _02_1_DataTypes
{
    /// <summary>
    /// A program that demonstrates declaring variables of common C# types
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
       
            #region Declaring and printing variables
            //Declaring a variable called a
            int a;

            //Assigning a the value 32
            a = 32;

            //Printing the variable a
            Console.WriteLine(a);

            //You can combine declaration and assignment 
            int b = 12;

            //You use variables to control memory. The computer will associate the name you give the variable
            //with a place in physical memory or RAM. Variable values in memory can be changed any time you need.
            a = 2;

            //print a, print a new line, print b
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion

            #region Data types
            //Here I declare and assign values to variables of several C# data types
            //The data type's size and range are list on the end of line comment

            //Integral types (integers, whole numbers)
            sbyte c = -1;               //signed 8-bit integer, -128 to 127
            byte d = 42;                //unsigned 8-bit integer, 0 to 255
            short e = 31232;            //signed 16-bit integer, -32,768 to 32,767
            ushort f = 55023;           //unsigned 16-bit integer, 	0 to 65,535
            int g = -19235321;          //signed 32-bit integer, -2,147,483,648 to 2,147,483,647
            uint h = 3326585456;        //unsigned 32-bit integer, 0 to 4,294,967,295
            long i = 16516546816;       //signed 64-bit integer, 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong j = 4381861566516516;   //unsigned 64-bit integer,	0 to 18,446,744,073,709,551,615
            nint k = 3216561;           //signed 32-bit or 64-bit integer, Depends on platform (computed at runtime)
            nuint l = 451414514;        //Unsigned 32-bit or 64-bit integer, Depends on platform (computed at runtime)

            //Floating-point numeric types 
            float m = 3.1415926535f;                          //4 bytes, 6-9 digits of precision
            double n = 0.9734516364275;                       //8 bytes, 15-17 digits of precision
            decimal o = -1.19635472345168569884624m;          //16 bytes, 28-29 digits od precision

            //Characters
            char p = 'a';
            char q = '\u00A9';
            char r = '\u00F1';

            //Strings
            string s = "Hello World!";

            //Boolean
            bool t = true;
            bool u = false;

            //Print all the variables declared with an concatenated label
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);
            Console.WriteLine("l = " + l);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            Console.WriteLine("o = " + o);
            Console.WriteLine("p = " + p);
            Console.WriteLine("q = " + q);
            Console.WriteLine("r = " + r);
            Console.WriteLine("s = " + s);
            Console.WriteLine("t = " + t);
            Console.WriteLine("u = " + u);
            #endregion

            #region Variable naming
            //Variable names are your choice! Name them wisely as meaningful variable names help code readbility
            //which code is more expressive?

            double v = 12;
            double w = 3;
            double x = v * w;
            Console.WriteLine("Area = " + x);

            //or
            double length = 12;
            double width = 3;
            double area = length * width;
            Console.WriteLine("Area" + area);

            #endregion


        }
    }
}



