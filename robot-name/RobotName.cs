using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Robot
{
    private static Random _rand = new Random();
    private string _robotName = GenerateNewName();
    private static HashSet<string> _existingNames = new HashSet<string>();
    public string Name
    {
        get { return _robotName; }
    }
    private static string GenerateNewName()
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        var robotName = new StringBuilder();

        for (int i = 0; i < 2; i++)
            robotName.Append(alphabet[_rand.Next(0, alphabet.Length)].ToString());

        for (int i = 0; i < 3; i++)
            robotName.Append(numbers[_rand.Next(0, numbers.Length)].ToString());

        string robotNameStr = robotName.ToString();

        if (!_existingNames.Add(robotNameStr))
            return GenerateNewName();

        return robotNameStr;
    }
    public void Reset()
    {
        _robotName = GenerateNewName();
    }
}