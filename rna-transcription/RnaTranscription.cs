using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var lookup = new Dictionary<char, char>{
            {'G', 'C'},
            {'C', 'G'},
            {'T', 'A'},
            {'A', 'U'}
        };
        char[] nucleotideArray = nucleotide.ToCharArray();
        string RnaString = "";

        for (int i = 0; i < nucleotideArray.Length; i++)
        {
            string newLetter = lookup[nucleotideArray[i]].ToString();
            RnaString = RnaString + newLetter;
        }
        return RnaString;
    }
}