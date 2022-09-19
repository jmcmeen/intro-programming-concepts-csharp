namespace CISP1010;

internal class Program
{
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        Console.WriteLine(Square(9));
    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("------------------------------------");

    }

    static int Square(int x)
    {
        return x * x; 
    }
}