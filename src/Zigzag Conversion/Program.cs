using System.Text;

namespace ZigzagConversion;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Convert("AB", 3) == "");
    }
    public static string Convert(string s, int numRows)
    {
        if (s.Length <= 2 || numRows == 1) return s;
        // Cant figure out how to calculate matrix length. Doesnt make a big difference in this case
        var matrix = new char[s.Length, numRows];
        var counterVertical = 0;
        var counterHorizontal = 0;
        var reached = false;

        matrix[0, 0] = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if(counterVertical < numRows && !reached)
            {
                counterVertical++;
                matrix[counterHorizontal, counterVertical] = s[i];
                if (counterVertical == numRows - 1) reached = true;
            }
            else
            {
                counterVertical--;
                counterHorizontal = counterHorizontal == matrix.GetLength(0) - 1 ? counterHorizontal : counterHorizontal + 1;
                matrix[counterHorizontal, counterVertical] = s[i];
                if(counterVertical == 0 || counterHorizontal == matrix.GetLength(0) - 1) reached = false;
            }
        }

        var resultSb = new StringBuilder();

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for(int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j,i] != '\0')
                {
                    resultSb.Append(matrix[j, i]);
                }
            }
        }

        return resultSb.ToString();
    }
}
