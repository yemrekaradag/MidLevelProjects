using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Models;

public class Circle : IShape
{
    private double radius;

    public Circle()
    {
        Console.Write("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateArea() => Math.PI * radius * radius;
    public double CalculatePerimeter() => 2 * Math.PI * radius;
    public double CalculateVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
}