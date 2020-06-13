using System;

static class Constants
{
    public const double earthOrbitalPeriod = 31557600; // This is 365.25 days in seconds
    // The following numbers are in Earth years i.e. mercuryOrbitalPeriod = 0.2408467 Earth years
    public const double mercuryOrbitalPeriod = 0.2408467; 
    public const double venusOrbitalPeriod = 0.61519726;
    public const double marsOrbitalPeriod = 1.8808158;
    public const double jupiterOrbitalPeriod = 11.862615;
    public const double saturnOrbitalPeriod = 29.447498;
    public const double uranusOrbitalPeriod = 84.016846;
    public const double neptuneOrbitalPeriod = 164.79132;
}
 
public class SpaceAge
{
    private int seconds {get; set;}
    
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return this.seconds / Constants.earthOrbitalPeriod;
    }

    public double OnMercury()
    {
        return this.OnEarth() / Constants.mercuryOrbitalPeriod;
    }

    public double OnVenus()
    {
        return this.OnEarth() / Constants.venusOrbitalPeriod;
    }

    public double OnMars()
    {
        return this.OnEarth() / Constants.marsOrbitalPeriod;
    }

    public double OnJupiter()
    {
        return this.OnEarth() / Constants.jupiterOrbitalPeriod;
    }

    public double OnSaturn()
    {
        return this.OnEarth() / Constants.saturnOrbitalPeriod;
    }

    public double OnUranus()
    {
        return this.OnEarth() / Constants.uranusOrbitalPeriod;
    }

    public double OnNeptune()
    {
        return this.OnEarth() / Constants.neptuneOrbitalPeriod;
    }
}