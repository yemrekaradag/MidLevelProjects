using GeometryCalculator.Factory;
using GeometryCalculator.Interfaces;

namespace MidLevelProjects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Geometry Calculator ===\n");

        Console.WriteLine("Select a shape:");
        Console.WriteLine("1 - Circle");
        Console.WriteLine("2 - Square");
        Console.WriteLine("3 - Rectangle");
        Console.WriteLine("4 - Triangle");
        int shapeChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSelect a calculation:");
        Console.WriteLine("1 - Area");
        Console.WriteLine("2 - Perimeter");
        Console.WriteLine("3 - Volume");
        int operationChoice = Convert.ToInt32(Console.ReadLine());

        IShape shape = ShapeFactory.CreateShape(shapeChoice);

        if (shape == null)
        {
            Console.WriteLine("Invalid shape selection!");
            return;
        }

        double result = 0;

        switch (operationChoice)
        {
            case 1:
                result = shape.CalculateArea();
                Console.WriteLine($"\nResult: {shape.GetType().Name} area = {result:F2}");
                break;
            case 2:
                result = shape.CalculatePerimeter();
                Console.WriteLine($"\nResult: {shape.GetType().Name} perimeter = {result:F2}");
                break;
            case 3:
                result = shape.CalculateVolume();
                Console.WriteLine($"\nResult: {shape.GetType().Name} volume = {result:F2}");
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }
    }
}