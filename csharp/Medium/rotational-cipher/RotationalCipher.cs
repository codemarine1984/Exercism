using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class RotationalCipher
{
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static string Rotate(string text, int shiftKey)
    {
        var sbResult = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            var character = text.ToLower().ElementAt(i);

            if (!char.IsLetter(character)) sbResult.Append(character);
            else
            {
                var newChar = alphabet.CharAtWrap(alphabet.IndexOf(character) + shiftKey);

                if (char.IsUpper(text.ElementAt(i))) newChar = char.ToUpper(newChar);

                sbResult.Append(newChar);
            }
        }

        return sbResult.ToString();
    }
}


public static class StringExtension
{
    public static char CharAtWrap(this string str, int index)
    {
        while (index < 0)
        {
            index += str.Count();
        }

        while (index > str.Count() - 1)
        {
            index -= str.Count();
        }

        return str[index];
    }
}