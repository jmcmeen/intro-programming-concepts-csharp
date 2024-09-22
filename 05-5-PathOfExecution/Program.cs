namespace _05_5_PathOfExecution;

/// <summary>
/// An intentionally off the rails program to 
/// practice using the Visual Studio Debugger.
/// </summary>
class Program
{
    /// <summary>
    /// Program entry point
    /// </summary>
    static void Main()
    {
        Dont();
    }

    /// <summary>
    /// !Do()
    /// </summary>
    static void Dont()
    {
        Panic();
    }

    /// <summary>
    /// Isn't it obvious what this method does by the name?
    /// </summary>
    static void Panic()
    {
        int x = 4;
        int y = 5;
        int z = 6;

        decimal superCombinedValue = SuperCombiner(x, y, z);
        double subtractedValue = Subtractron(superCombinedValue);
        double positiveValue = Positron(subtractedValue);

        x = X(positiveValue) * (X(positiveValue) - 1);

        Console.WriteLine(x);
    }

    /// <summary>
    /// The most useful method in this program, except it's just a wrapper for
    /// another useful method that gets the absolute value of a numeric type.
    /// </summary>
    /// <param name="val">The number you want the absolute value of</param>
    /// <returns>The absolute value of val</returns>
    static double Positron(double val)
    {
        return Math.Abs(val);
    }

    /// <summary>
    /// Divides, con gusto!
    /// </summary>
    /// <param name="anIncrediblyLongVariableNameForNoReason"></param>
    /// <returns></returns>
    static decimal TurboDivider(float anIncrediblyLongVariableNameForNoReason)
    {
        double input = (double)anIncrediblyLongVariableNameForNoReason;
        decimal val = MegaMultiplier(input);
        return val / 2.0m;
    }

    /// <summary>
    /// Combines stuff, duh
    /// </summary>
    /// <param name="val1">The first value to the combined</param>
    /// <param name="val2">The second value to the combined</param>
    /// <param name="val3">The third value to the combined</param>
    /// <returns>The values combined, but also turbo divided first.</returns>
    static decimal SuperCombiner(int val1, int val2, int val3)
    {
        float result = Convert.ToSingle(val1 + val2 + val3);
        return TurboDivider(result); 
    }

    /// <summary>
    /// Multiplies a number by 0.0000000000001, and by no right is no better than the * operator
    /// </summary>
    /// <param name="x">x</param>
    /// <returns>input</returns>
    static decimal MegaMultiplier(double x)
    {
        decimal input = Convert.ToDecimal(x);
        return input * 0.0000000000001m;
    }

    /// <summary>
    /// This is a looping mechanism, for subtracting, over and over again
    /// </summary>
    /// <param name="input">Pledge your fealty to Subtractron by leaving a decimal value
    /// in Subtractron's decimal input variable.</param>
    /// <returns>Subtractron's output value.</returns>
    static double Subtractron(decimal input)
    {
        decimal output = 0.0m;
        for(int i = 0; i < 1000000; i++)
        {
            output -= input;
        }

        return (double)output;
    }

    /// <summary>
    /// No one really knows what method X does, but its on the spec sheet. </summary>
    /// <param name="inputValue">a double!</param>
    /// <returns>an int!</returns>
    static int X(double inputValue)
    {
        double accumulator = 0;
        for(int i =0; i < 10000000; i++)
        {
            accumulator += inputValue;
        }

        return (int)accumulator;
    }
}