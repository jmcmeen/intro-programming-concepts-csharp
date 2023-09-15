namespace _05_3_ClassLibraries;

using Util;

class Program
{
    /// <summary>
    /// Program entry point
    /// </summary>
    static void Main()
    {
        //This Visual Studio Project contains a project reference to a class library, Util,
        //which is another project in this solution.

        //Class libraries are .dll file (dynamic link library) which is a precompiled code library.

        //Class libraries can not contain a class with a Main() method.

        //Adding the project reference will move the compiled Util.dll file into the bin directory
        //for this program when this project is compiled, allowing it to use code from that project.

        //The using Util; statement at the top of this code file enables us to leave
        //off the Util in Util.Prompt.ForInt("") below.

        //Example usage of Util.Prompt class methods
        int input1 = Prompt.ForInt("Enter an integer: ");

        float input2 = Prompt.ForFloat("Enter a float: ");

        double input3 = Prompt.ForDouble("Enter a double: ");

        Console.WriteLine($"You entered {input1}, {input2}, {input3}");
    }
}
