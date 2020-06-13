using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
        {
            return false;
        }
        
        if (year % 2 == 0 && year % 4 != 0)
        {
            return false;
        }
        
        if (year % 100 == 0 && year % 400 != 0)
        {
            return false;
        }

        if (year % 400 == 0 )
        {
            return true;
        }
        
        if (year % 100 == 0 && year % 3 != 0)
        {
            return false;
        }

        if (year % 200 == 0 && year % 400 != 0)
        {
            return false;
        }
        
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        
        if (year % 4 == 0 && year % 5 == 0)
        {
            return true;
        }
        
        if (year % 400 == 0 && year % 125 != 0 )
        {
            return true;
        }
        return true;
    }
}