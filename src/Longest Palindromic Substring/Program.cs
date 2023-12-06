namespace LongestPalindromicSubstring;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LongestPalindrome("aba"));
    }
    public static string LongestPalindrome(string s)
    {
        var palindromes = new HashSet<string>();
        var maxLength = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (s.Length - i + 1 <= maxLength) break;
            for(int j = s.Length; j >= i; j--)
            {
                if (j - i + 1 <= maxLength) break;

                var substring = s.Substring(i, j - i);
                if (IsPalindrome(substring))
                {
                    palindromes.Add(substring);
                    maxLength = substring.Length;
                }
            }
        }

        // Fast method for finding longest string in a List
        return palindromes.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
    }

    public static bool IsPalindrome(string input)
    {
        if (input.Length == 1) return true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
