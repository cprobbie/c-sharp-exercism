using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        double seconds;
        seconds = Math.Pow(10, 9);
        DateTime newDate = birthDate.AddSeconds(Convert.ToInt32(seconds));
        return newDate;
    }
}