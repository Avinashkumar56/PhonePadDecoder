using System;
using System.Text;

public class PhonePadDecoder
{
    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
            return "";

        // Mapping digits to letters using array index
        string[] keypad = {
            " ",        // 0
            "&'(",      // 1
            "ABC",      // 2
            "DEF",      // 3
            "GHI",      // 4
            "JKL",      // 5
            "MNO",      // 6
            "PQRS",     // 7
            "TUV",      // 8
            "WXYZ"      // 9
        };

        StringBuilder result = new StringBuilder();
        int i = 0, length = input.Length;

        while (i < length)
        {
            char ch = input[i];

            if (ch == '#') break;

            if (ch == '*')
            {
                if (result.Length > 0)
                    result.Length--; // backspace, remove last character
                i++;
                continue;
            }

            if (ch == ' ')
            {
                i++;
                continue;
            }

            // Count how many times this digit is repeated
            int count = 1;
            int j = i + 1;
            while (j < length && input[j] == ch)
            {
                count++;
                j++;
            }

            if (char.IsDigit(ch))
            {
                int digit = ch - '0';
                string letters = keypad[digit];
                int index = (count - 1) % letters.Length;
                result.Append(letters[index]);
            }

            i = j;
        }

        return result.ToString();
    }
}

class PhonePad
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Key (end it with #):");
        string input = Console.ReadLine();

        string output = PhonePadDecoder.OldPhonePad(input);
        Console.WriteLine(output);
    }
}
