using System;
using System.Collections.Generic;

public class SpaceAge
{
    private long sec;
    private const double _earthSecPerYear = 31557600;
    private readonly Dictionary<string, double> _dict = new Dictionary<string, double>()
    {
        { "Earth", 1 },
        { "Mercury", 0.2408467 },
        { "Venus", 0.61519726 },
        { "Mars", 1.8808158 },
        { "Jupiter", 11.862615 },
        { "Saturn",  29.447498 },
        { "Uranus",  84.016846 },
        { "Neptune", 164.79132 }
    };
    public SpaceAge(long seconds)
    {
        sec = seconds;
    }

    public double OnEarth()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Earth"];
        return (Convert.ToDouble(sec) / planetSecPerYear);
    }

    public double OnMercury()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Mercury"];
        return (Convert.ToDouble(sec) / planetSecPerYear);
    }

    public double OnVenus()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Venus"];
        return (Convert.ToDouble(sec) / planetSecPerYear);
    }

    public double OnMars()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Mars"];
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnJupiter()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Jupiter"];
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnSaturn()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Saturn"];
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnUranus()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Uranus"];
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }

    public double OnNeptune()
    {
        double planetSecPerYear = _earthSecPerYear * _dict["Neptune"];
        return (Convert.ToDouble(sec) / planetSecPerYear); 
    }
}