using DifferenceCalculator.Services;

namespace DifferenceCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Difference Calculator ===");
        Console.WriteLine("Enter numbers separated by spaces (e.g., 56 45 68 77):");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided!");
            return;
        }

        string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        DifferenceService service = new DifferenceService();
        (int smallerSum, int largerSum) = service.CalculateDifferences(numbers);

        Console.WriteLine($"\nOutput:");
        Console.WriteLine($"{smallerSum} {largerSum}");
    }
}
