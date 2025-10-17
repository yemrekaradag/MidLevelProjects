using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Models;

public class Triangle : IShape
{
    private double baseLength;
    private double height;
    private double side1;
    private double side2;

    public Triangle()
    {
        Console.Write("Enter base: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateArea() => (baseLength * height) / 2;
    public double CalculatePerimeter() => baseLength + side1 + side2;
    public double CalculateVolume() => 0; // Triangle has no volume
}