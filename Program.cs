using DoubleConsonantChecker.Services;

namespace DoubleConsonantChecker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Double Consonant Checker ===");
        Console.WriteLine("Enter words separated by spaces (e.g., Merhaba Umut Arya):");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided!");
            return;
        }

        ConsonantChecker checker = new ConsonantChecker();
        string result = checker.CheckWords(input);

        Console.WriteLine("\nOutput:");
        Console.WriteLine(result);
    }
}
