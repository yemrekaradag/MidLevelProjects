using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Models;

public class Square : IShape
{
    private double side;

    public Square()
    {
        Console.Write("Enter side length: ");
        side = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateArea() => side * side;
    public double CalculatePerimeter() => 4 * side;
    public double CalculateVolume() => Math.Pow(side, 3);
}