
using System.Text;

namespace DoubleConsonantChecker.Services;

public class ConsonantChecker
{
    private readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u',
                                           'A', 'E', 'I', 'O', 'U' };

    public string CheckWords(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            bool hasDoubleConsonant = HasConsecutiveConsonants(word);
            result.Append(hasDoubleConsonant ? "True" : "False");
            result.Append(' ');
        }

        return result.ToString().TrimEnd();
    }

    private bool HasConsecutiveConsonants(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (!IsVowel(word[i]) && !IsVowel(word[i + 1]))
                return true;
        }
        return false;
    }

    private bool IsVowel(char c)
    {
        return Array.Exists(vowels, v => v == c);
    }
}