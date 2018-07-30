using System;
using System.Collections.Generic;

public static class Pangram
{
    static string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string input)
    {
        char[] alphabetArray = alphabet.ToCharArray();
        int counter = 0;
        bool result;
        foreach (char s in alphabetArray)
        {
            counter = input.ToLower().Contains(s.ToString()) ? counter + 1 : counter;
        }
        return result = (counter == alphabet.Length) ? true : false;
    }
}
