using System;

public class SpaceAge
{
    public long sec;
    public SpaceAge(long seconds)
    {
        sec = seconds;
    }

    public double OnEarth()
    {
        long earthSecPerYear = 31557600;
        return (Convert.ToDouble(sec) / earthSecPerYear);
    }

    public double OnMercury()
    {
        double planetSecPerYear = 31557600 * 0.2408467;
        return (Convert.ToDouble(sec) / planetSecPerYear);
    }

    public double OnVenus()
    {
        double planetSecPerYear = 31557600 * 0.61519726;
        return (Convert.ToDouble(sec) / planetSecPerYear);
    }

    public double OnMars()
    {
        double planetSecPerYear = 31557600 * 1.8808158;
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnJupiter()
    {
        double planetSecPerYear = 31557600 * 11.862615;
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnSaturn()
    {
        double planetSecPerYear = 31557600 * 29.447498;
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnUranus()
    {
        double planetSecPerYear = 31557600 * 84.016846;
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnNeptune()
    {
        double planetSecPerYear = 31557600 * 164.79132 ;
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }
}