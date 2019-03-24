using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        switch (color)
        {
            case "black":
                return 0;
            case "brown":
                return 1;
            case "red":
                return 2;
            case "orange":
                return 3;
            case "yellow":
                return 4;
            case "green":
                return 5;
            case "blue":
                return 6;
            case "violet":
                return 7;
            case "grey":
                return 8;
            case "white":
                return 9;
            default:
                return -1;
        }
    }

    public static string[] Colors()
    {
        var mappedColors = new string[10];
        var colors = new string[10] { "green", "blue", "violet", "grey", "white", "black", "brown", "red", "orange", "yellow" };
        foreach (var c in colors)
        {
            mappedColors[ColorCode(c)] = c;
        }
        return mappedColors;
    }
}