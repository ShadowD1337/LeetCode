using System.Reflection.Metadata.Ecma335;

namespace KnightDialer;

internal class Program
{
    static void Main(string[] args)
    {
        while(true) Console.WriteLine(KnightDialer(Convert.ToInt32(Console.ReadLine())));
    }
    //TODO: way too time complex. Inputs above 20 would take hours to compute and above a certain number it gives StackOverflowException.
    public static int KnightDialer(int n)
    {
        var numbers = new List<List<int>>();

        for(int i = 0; i <= 9; i++)
        {
            if (n == 1)
            {
                numbers.Add(new List<int> { i });
                continue;
            }
            if (i == 5) continue;

            foreach (var combo in GenerateCombos(i, n))
            {
                numbers.Add(combo);
            }
        }

        return numbers.Count;
    }
    public static IEnumerable<List<int>> GenerateCombos(int currentNum, int length) => GenerateCombos(currentNum, length, new List<int>());
    public static IEnumerable<List<int>> GenerateCombos (int currentNum, int length, List<int> number)
    {
        number.Add(currentNum);
        if (length <= 1)
        {
            yield return number;
            yield break;
        }
        if (currentNum == 0)
        {
            foreach (var combo in GenerateCombos(4, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(6, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 1)
        {
            foreach (var combo in GenerateCombos(6, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(8, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 2)
        {
            foreach (var combo in GenerateCombos(7, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(9, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 3)
        {
            foreach (var combo in GenerateCombos(4, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(8, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 4)
        {
            foreach (var combo in GenerateCombos(0, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(3, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(9, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 5)
        {
            throw new NotSupportedException();
        }

        else if (currentNum == 6)
        {
            foreach (var combo in GenerateCombos(0, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(1, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(7, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 7)
        {
            foreach (var combo in GenerateCombos(2, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(6, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 8)
        {
            foreach (var combo in GenerateCombos(1, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(3, length - 1, number))
            {
                yield return combo;
            }
        }
        else if (currentNum == 9)
        {
            foreach (var combo in GenerateCombos(2, length - 1, number))
            {
                yield return combo;
            }
            foreach (var combo in GenerateCombos(4, length - 1, number))
            {
                yield return combo;
            }
        }
    }
}
