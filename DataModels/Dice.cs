namespace DataModels;

/// <summary>
/// Models a table top gaming die
/// </summary>
public class Dice
{
    /// <summary>
    /// Number of sides
    /// </summary>
    public int NumSides { get; set; }

    /// <summary>
    /// Random number generator
    /// </summary>
    private Random _randomNumberGenerator;

    /// <summary>
    /// Default constructor
    /// </summary>
    public Dice()
    {
        NumSides = 6;
        _randomNumberGenerator = new Random();
    }

    /// <summary>
    /// Parameterized constructor
    /// </summary>
    /// <param name="numSides">The number of sides on the die</param>
    public Dice(int numSides)
    {
        NumSides = numSides;
        _randomNumberGenerator = new Random();
    }

    /// <summary>
    /// Rolls the dice
    /// </summary>
    /// <returns>a random number between 1 and NumSides</returns>
    public int NextRoll()
    {
        return _randomNumberGenerator.Next(NumSides) + 1;
    }

    public override string ToString()
    {
        return $"d{NumSides}";
    }
}
