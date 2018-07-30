using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        DateTime newDate;
        return newDate = birthDate.AddSeconds(1e9);
    }
}