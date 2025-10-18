using NumberPairCalculator.Services;

namespace NumberPairCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Number Pair Calculator ===");
        Console.WriteLine("Enter pairs of integers (e.g., 2 3 1 5 2 5 3 3):");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided!");
            return;
        }

        string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        PairProcessor processor = new PairProcessor();
        string result = processor.CalculatePairs(numbers);

        Console.WriteLine("\nOutput:");
        Console.WriteLine(result);
    }
}
