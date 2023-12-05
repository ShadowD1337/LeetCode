using System.Reflection.Metadata.Ecma335;

namespace KnightDialer;

internal class Program
{
    static void Main(string[] args)
    {
        while(true) Console.WriteLine(KnightDialer(Convert.ToInt32(Console.ReadLine())));
    }
    //TODO: way too time complex. Inputs above 50 would take hours to compute and above a certain number it gives StackOverflowException.
    public static int KnightDialer(int n)
    {
        var counter = 0;

        for(int i = 0; i <= 9; i++)
        {
            if (n == 1)
            {
                counter++;
                continue;
            }
            if (i == 5) continue;
            GenerateCombos(i, n, ref counter);
        }

        return counter;
    }
    public static Task GenerateCombos(int currentNum, int length, ref int counter)
    {
        if (length <= 1)
        {
            counter++;
            return Task.CompletedTask;
        }
        if (currentNum == 0)
        {
            GenerateCombos(4, length - 1, ref counter);
            GenerateCombos(6, length - 1, ref counter);
        }
        else if (currentNum == 1)
        {
            GenerateCombos(6, length - 1, ref counter);
            GenerateCombos(8, length - 1, ref counter);
        }
        else if (currentNum == 2)
        {
            GenerateCombos(7, length - 1, ref counter);
            GenerateCombos(9, length - 1, ref counter);
        }
        else if (currentNum == 3)
        {
            GenerateCombos(4, length - 1, ref counter);
            GenerateCombos(8, length - 1, ref counter);
        }
        else if (currentNum == 4)
        {
            GenerateCombos(0, length - 1, ref counter);
            GenerateCombos(3, length - 1, ref counter);
            GenerateCombos(9, length - 1, ref counter);
        }
        else if (currentNum == 5)
        {
            throw new NotSupportedException();
        }

        else if (currentNum == 6)
        {
            GenerateCombos(0, length - 1, ref counter);
            GenerateCombos(1, length - 1, ref counter);
            GenerateCombos(7, length - 1, ref counter);
        }
        else if (currentNum == 7)
        {
            GenerateCombos(2, length - 1, ref counter);
            GenerateCombos(6, length - 1, ref counter);
        }
        else if (currentNum == 8)
        {
            GenerateCombos(1, length - 1, ref counter);
            GenerateCombos(3, length - 1, ref counter);
        }
        else if (currentNum == 9)
        {
            GenerateCombos(2, length - 1, ref counter);
            GenerateCombos(4, length - 1, ref counter);
        }
        return Task.CompletedTask;
    }
}
