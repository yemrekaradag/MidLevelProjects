
using System.Text;

namespace SwapFirstLastCharApp.Services;

public class StringSwapper
{
    public string SwapFirstAndLastChars(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (word.Length <= 1)
            {
                result.Append(word);
            }
            else
            {
                char first = word[0];
                char last = word[^1];
                string middle = word.Substring(1, word.Length - 2);
                result.Append(last + middle + first);
            }

            result.Append(' ');
        }

        return result.ToString().TrimEnd();
    }
}