using System;
using System.Collections.Generic;

public class SpaceAge
{
    private long _sec;
    private const double _earthSecPerYear = 31557600;
    private static readonly Dictionary<string, double> _dict = new Dictionary<string, double>()
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
        _sec = seconds;
    }

    public double OnEarth()
    {
        return CalculateAge("Earth");
    }

    public double OnMercury()
    {
        return CalculateAge("Mercury");
    }

    public double OnVenus()
    {
        return CalculateAge("Venus");
    }

    public double OnMars()
    {
        return CalculateAge("Mars");
    }

    public double OnJupiter()
    {
        return CalculateAge("Jupiter");
    }

    public double OnSaturn()
    {
        return CalculateAge("Saturn");
    }

    public double OnUranus()
    {
        return CalculateAge("Uranus");
    }

    public double OnNeptune()
    {
        return CalculateAge("Neptune");
    }

    private double CalculateAge(string planet)
    {
        return _sec / (_earthSecPerYear * _dict[planet]);
    }
}