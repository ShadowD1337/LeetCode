namespace LongestSubstringWithoutRepeatingCharacters;

internal class Program
{
    static void Main(string[] args)
    {
        var answer = LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine(answer);
    }
    public static int LengthOfLongestSubstring(string s)
    {
        int biggestLength = 0;

        for(int i = 0; i < s.Length; i++)
        {
            var usedChars = new List<char>();
            for(int j = i; j < s.Length; j++)
            {
                if (!usedChars.Contains(s[j]))
                {
                    usedChars.Add(s[j]);
                }
                else break;
            }
            biggestLength = Math.Max(biggestLength, usedChars.Count);
        }

        return biggestLength;
    }
}
