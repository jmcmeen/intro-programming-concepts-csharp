/// <summary>
/// File: Operators.cs
/// Name: John McMeen
/// Class: CISP1010
/// Semester: Fall 2022
/// Project: CISP1010 Examples
/// </summary>
namespace CISP1010
{
    /// <summary>
    /// A program that demonstrates selection statements
    /// </summary>
    internal class Operators
    {
        /// <summary>
        /// The Main method is an an entry point for the program
        /// </summary>
        /// <param name="args">string array for passing in command line arguments</param>
        static void Main(string[] args)
        {
            //declare some variables
            int a, b, c, d, e;
            bool f, g, h, i, j, k, l, m, n, o, p, q;

            //examples of arithemtic operators 
            a = 10 + 3;  //add
            b = a - 6;   //subtract
            c = b * 5;   //multiply 
            d = c / 2;   //divide
            e = d % 2;   //remainder (modulus)

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e + "\n");

            //examples of equality operators
            g = a == 13;  //equal
            f = b != 7;   //not equal

            Console.WriteLine("a == 13 is " + g);
            Console.WriteLine("b != 7 is " + f + "\n");

            //examples of comparison operators
            h = a < 10;     //less than
            i = b <= 13;    //less than or equal 
            j = c > 18;     //greater than
            k = d <= 1;     //less than or equal

            Console.WriteLine("a < 10 is " + h);
            Console.WriteLine("b <= 13 is " + i);
            Console.WriteLine("c > 18 is " + j);
            Console.WriteLine("d <= 1 is " + k + "\n");

            //examples of Boolean operators
            l = i && j;     //logical AND
            m = i && k;     //logical AND 
            n = i || j;     //logical OR
            o = h || k;     //logical OR
            p = h || j;     //logical OR
            q = !p;         //logical NOT

            Console.WriteLine(i + " and " + j + " is " + l);
            Console.WriteLine(i + " and " + k + " is " + m);
            Console.WriteLine(i + " or " + j + " is " + n);
            Console.WriteLine(h + " or " + k + " is " + o);
            Console.WriteLine(h + " or " + j + " is " + p);
            Console.WriteLine("not " + p + " is " + q + "\n");
        }
    }
}