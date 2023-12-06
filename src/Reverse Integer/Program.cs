namespace ReverseInteger;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Reverse(-123));
    }

    public static int Reverse(int x)
    {
        // Very slow solution, but is the easiest to understand and doesn't need to be faster in this case
        if (x >= 0)
        {
            try
            {
                return int.Parse(new string(x.ToString().Reverse().ToArray()));
            }
            catch
            {
                return 0;
            }
        }
        else
        {
            try
            {
                return -1 * int.Parse(new string(Math.Abs(x).ToString().Reverse().ToArray()));
            }
            catch
            {
                return 0;
            }
        }
    }
}
