using System;

namespace Int_To_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(15));
        }
        static string IntToRoman(int number)
        {
            return number switch
            {
                >= 1000 => "M" + IntToRoman(number - 1000),
                >= 900 => "CM" + IntToRoman(number - 900),
                >= 500 => "D" + IntToRoman(number - 500),
                >= 400 => "CD" + IntToRoman(number - 400),
                >= 100 => "C" + IntToRoman(number - 100),
                >= 90 => "XC" + IntToRoman(number - 90),
                >= 50 => "L" + IntToRoman(number - 50),
                >= 40 => "XL" + IntToRoman(number - 40),
                >= 10 => "X" + IntToRoman(number - 10),
                >= 9 => "IX" + IntToRoman(number - 9),
                >= 5 => "V" + IntToRoman(number - 5),
                >= 4 => "IV" + IntToRoman(number - 4),
                >= 1 => "I" + IntToRoman(number - 1),
                _ => ""
            };
        }
    }
}
