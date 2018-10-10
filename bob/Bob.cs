using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string ReplaceDigitsWithSpaces() => Regex.Replace(statement, @"[\d]+", " ");
        string RemoveAllWhiteSpaces() => Regex.Replace(statement, @"[\s]+", "");
        string ReplaceNoneWordsWithSpaces() => Regex.Replace(statement, @"[\W]+", " ");

        statement.Trim();
        statement = ReplaceDigitsWithSpaces();

        if (statement.EndsWith("?")){
            if (Regex.IsMatch(statement, @"[\w]+") && statement.ToUpper() == statement)
                return "Calm down, I know what I'm doing!";
        }
        statement = RemoveAllWhiteSpaces();
        
        if (statement.EndsWith("?"))
            return "Sure.";

        statement = ReplaceNoneWordsWithSpaces();

        if (statement.ToUpper() == statement && !string.IsNullOrWhiteSpace(statement))
            return "Whoa, chill out!";            
        else if (String.IsNullOrEmpty(statement))
            return "Fine. Be that way!";
        else
            return "Whatever.";
    }
}