using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IReadOnlyDictionary<char, int> _readOnlyResult { get; private set; }
    public static IDictionary<char, int> Count(string sequence)
    {
        try
        {
            var result = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };

            foreach (var c in sequence)
            {
                result[c]++;
            }
            _readOnlyResult = result;

            return (IDictionary<char, int>)_readOnlyResult;
        }
        catch
        {
            throw new ArgumentException();
        }
    }
}