namespace _05_5_PathOfExecution;

class Program
{
    static void Main()
    {
        Dont();
    }

    static void Dont()
    {
        Panic();
    }

    static void Panic()
    {
        int x = 4;
        int y = 5;
        int z = 6;

        decimal superCombinedValue = SuperCombiner(x, y, z);
        double subtractedValue = Subtractron(superCombinedValue);
        double positiveValue = Positron(subtractedValue);

        x = Repeater(positiveValue) * (Repeater(positiveValue) - 1);

        Console.WriteLine(x);
    }

    static double Positron(double val)
    {
        return Math.Abs(val);
    }

    static decimal TurboDivider(float anIncrediblyLongVariableNameForNoReason)
    {
        double input = (double)anIncrediblyLongVariableNameForNoReason;
        decimal val = MegaMultiplier(input);
        return val / 2.0m;
    }

    static decimal SuperCombiner(int val1, int val2, int val3)
    {
        float result = Convert.ToSingle(val1 + val2 + val3);
        return TurboDivider(result); 
    }

    static decimal MegaMultiplier(double x)
    {
        decimal input = Convert.ToDecimal(x);
        return input * 0.0000000000001m;
    }

    static double Subtractron(decimal input)
    {
        decimal output = 0.0m;
        for(int i = 0; i < 1000000; i++)
        {
            output -= input;
        }

        return (double)output;
    }

    static int Repeater(double inputValue)
    {
        double accumulator = 0;
        for(int i =0; i < 10000000; i++)
        {
            accumulator += inputValue;
        }

        return (int)accumulator;
    }
}