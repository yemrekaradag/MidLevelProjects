
using System.Text;

namespace NumberPairCalculator.Services;

public class PairProcessor
{
    public string CalculatePairs(string[] numbers)
    {
        StringBuilder output = new StringBuilder();

        if (numbers.Length % 2 != 0)
        {
            Console.WriteLine("⚠️ The number of integers must be even.");
            return string.Empty;
        }

        for (int i = 0; i < numbers.Length; i += 2)
        {
            int first = int.Parse(numbers[i]);
            int second = int.Parse(numbers[i + 1]);
            int sum = first + second;

            if (first == second)
                output.Append(Math.Pow(first, 2) * Math.Pow(second, 2));
            else
                output.Append(sum);

            if (i < numbers.Length - 2)
                output.Append(" ");
        }

        return output.ToString();
    }
}