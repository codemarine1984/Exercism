using System;
using System.Collections.Generic;

public class Robot
{
    Random rand = new Random();
    private string _Name;
    private static List<string> usedNames = new List<string>();

    public Robot()
    {
        _Name = GenerateName();
    }
    public string Name
    {
        get
        {
            return _Name;
        }
    }

    public void Reset()
    {
        _Name = GenerateName();
    }

    private string GenerateName()
    {
        string name;
        // The max number of names in this format is 26 * 26 * 10 * 10 * 10 = 676000
        if(usedNames.Count == 26 * 26 * 10 * 10 * 10)
        {
            throw new ArgumentException("All possible names have been used.");
        }

        do
        {
            name = $"{GetLetter()}{GetLetter()}{GetNum()}";

        } while (usedNames.Contains(name));

        usedNames.Add(name);
        return name;
    }

    private char GetLetter()
    {
        return Convert.ToChar(rand.Next(65, 91));
    }

    private string GetNum()
    {
        return rand.Next(1000).ToString("D3");
    }
}