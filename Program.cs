using SwapFirstLastCharApp.Services;

namespace SwapFirstLastCharApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Swap First and Last Character App ===");
        Console.WriteLine("Enter words separated by spaces (e.g., Merhaba Hello Algoritma x):");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided!");
            return;
        }

        StringSwapper swapper = new StringSwapper();
        string result = swapper.SwapFirstAndLastChars(input);

        Console.WriteLine("\nOutput:");
        Console.WriteLine(result);
    }
}
