namespace _03_1_Operators
{
    /// <summary>
    /// A program to demonstrate various operators
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //declare some variables
            int a, b, c, d, e;
            bool f, g, h, i, j, k, l, m, n, o, p, q, r;

            //examples of arithmetic operators 
            a = 10 + 3;  //add
            b = a - 6;   //subtract
            c = b * 5;   //multiply 
            d = c / 2;   //divide
            e = c % 2;   //remainder (modulus)

            // the addition operator changes its name when used with strings
            // this is the concatenation operator
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e + "\n");

            //examples of equality operators
            f = a == 13;  // equal?
            g = b != 7;   // not equal?

            Console.WriteLine("a == 13 is " + f);
            Console.WriteLine("b != 7 is " + g + "\n");

            //examples of comparison operators
            h = a < 10;     // less than?
            i = b <= 13;    // less than or equal?
            j = c > 18;     // greater than?
            k = d <= 1;     // less than or equal?

            Console.WriteLine("a < 10 is " + h);
            Console.WriteLine("b <= 13 is " + i);
            Console.WriteLine("c > 18 is " + j);
            Console.WriteLine("d <= 1 is " + k + "\n");

            //examples of Boolean operators
            l = i && j;     // logical AND
            m = i && k;     // logical AND 

            n = i || j;     // logical OR
            o = h || k;     // logical OR
            p = h || j;     // logical OR

            q = !p;         // logical NOT

            r = !(1 < 2);  // invert logic of operation

            Console.WriteLine(i + " and " + j + " is " + l);
            Console.WriteLine(i + " and " + k + " is " + m);
            Console.WriteLine(i + " or " + j + " is " + n);
            Console.WriteLine(h + " or " + k + " is " + o);
            Console.WriteLine(h + " or " + j + " is " + p);
            Console.WriteLine("not " + p + " is " + q + "\n");
            Console.WriteLine("not 1 < 2 is " + r);
            Console.WriteLine("(!r || q) is " + (!r || q));
        }
    }
}