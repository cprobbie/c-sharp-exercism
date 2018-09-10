using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = Regex.Replace(statement, @"[\d]+", " ");

        if (Regex.IsMatch(statement, @"[\?]$")){
            Regex.Replace(statement, @"[\W]+", "");
            if (Regex.IsMatch(statement, @"[\w]+") && statement.ToUpper() == statement)
                return "Calm down, I know what I'm doing!";
        }
        statement = Regex.Replace(statement, @"[\s]+", "");
        
        if (Regex.IsMatch(statement, @"[\?]$"))
            return "Sure.";

        statement = Regex.Replace(statement, @"[\W]+", " ");

        if (statement.ToUpper() == statement && !string.IsNullOrWhiteSpace(statement))
            return "Whoa, chill out!";            
        else if (String.IsNullOrEmpty(statement))
            return "Fine. Be that way!";
        else
            return "Whatever.";
    }
}