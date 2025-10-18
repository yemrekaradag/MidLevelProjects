
using System.Text;

namespace DifferenceCalculator.Services;

public class DifferenceService
{
    private const int Target = 67;

    public (int smallerSum, int largerSum) CalculateDifferences(string[] numbers)
    {
        int smallerSum = 0;
        int largerSum = 0;

        foreach (var numStr in numbers)
        {
            if (!int.TryParse(numStr, out int num))
            {
                Console.WriteLine($"Invalid input: {numStr}");
                continue;
            }

            if (num < Target)
            {
                smallerSum += (Target - num);
            }
            else if (num > Target)
            {
                int diff = num - Target;
                largerSum += diff * diff;
            }
        }

        return (smallerSum, largerSum);
    }
}