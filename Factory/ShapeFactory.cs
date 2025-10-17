using GeometryCalculator.Interfaces;
using GeometryCalculator.Models;

namespace GeometryCalculator.Factory;

public static class ShapeFactory
{
    public static IShape CreateShape(int choice)
    {
        return choice switch
        {
            1 => new Circle(),
            2 => new Square(),
            3 => new Rectangle(),
            4 => new Triangle(),
            _ => null
        };
    }
}