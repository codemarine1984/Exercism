using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (IsSilence(statement))
        {
            return "Fine. Be that way!";
        }
        else if (IsForcefulQuestion(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (IsQuestion(statement))
        {
            return "Sure.";
        }
        else if (IsShout(statement))
        {
            return "Whoa, chill out!";
        }

        return "Whatever.";
    }

    private static bool IsShout(string statement)
    {
        var letters = statement.Where(c => char.IsLetter(c));
        var result = letters.Count() > 0 && letters.All(c => char.IsUpper(c));

        return result;
    }

    private static bool IsQuestion(string statement)
    {
        return statement.EndsWith('?');
    }

    private static bool IsForcefulQuestion(string statement)
    {
        return IsQuestion(statement) && IsShout(statement);
    }

    private static bool IsSilence(string statement) => string.IsNullOrWhiteSpace(statement);
}