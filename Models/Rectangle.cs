using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Models;

public class Rectangle : IShape
{
    private double width;
    private double height;
    private double depth;

    public Rectangle()
    {
        Console.Write("Enter width: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter depth (for volume, 0 if not needed): ");
        depth = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateArea() => width * height;
    public double CalculatePerimeter() => 2 * (width + height);
    public double CalculateVolume() => width * height * depth;
}