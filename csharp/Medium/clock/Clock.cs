using System;

public struct Clock
{
    private int _minutes;

    public Clock(int hours, int minutes)
    {
        const int minutesPerDay = 24 * 60;

        _minutes = (hours * 60 + minutes) % minutesPerDay;

        if (_minutes < 0)
            _minutes += minutesPerDay;
    }

    public int Hours => _minutes / 60 % 24;
    public int Minutes => _minutes % 60;

    public Clock Add(int minutesToAdd) =>
        new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) =>
        new Clock(Hours, Minutes - minutesToSubtract);

    public override string ToString() => $"{Hours:00}:{Minutes:00}";
}