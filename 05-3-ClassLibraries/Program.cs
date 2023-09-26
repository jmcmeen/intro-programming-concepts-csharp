namespace _05_3_StaticClasses;  //alternate namespace declaration

class Program
{
    /// <summary>
    /// Program entry point
    /// </summary>
    static void Main()
    {
        //Example usage of Util.Prompt class methods
        int input1 = Prompt.ForInt("Enter an integer: ");

        float input2 = Prompt.ForFloat("Enter a float: ");

        double input3 = Prompt.ForDouble("Enter a double: ");

        Console.WriteLine($"You entered {input1}, {input2}, {input3}");
    }
}
