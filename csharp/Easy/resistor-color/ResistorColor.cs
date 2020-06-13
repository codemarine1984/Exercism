using System;

public static class ResistorColor
{
    public static int ColorCode(string colorToSearchFor)
    {
        return Array.IndexOf(Colors(), colorToSearchFor);
    }

    public static string[] Colors()
    {
        // An array of colors in the order of the mnemonic
        String[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colors;
    }
}