namespace LabUtils.DataModels;

/// <summary>
/// Models a Car object
/// </summary>
public class Car
{
    /// <summary>
    /// Car color
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Make of car
    /// </summary>
    public string? Make { get; set; }

    /// <summary>
    /// Model of car
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Price of car
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Car() { }

    /// <summary>
    /// Parameterized constructor
    /// </summary>
    /// <param name="color">The color of the Car</param>
    /// <param name="make">The make of the Car</param>
    /// <param name="model">The model of the Car</param>
    /// <param name="price">The price of the Car</param>
    public Car(string color, string make, string model, double price)
    {
        Color = color;
        Make = make;
        Model = model;
        Price = price;
    }
}
