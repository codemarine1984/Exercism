using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        //TimeSpan gigasecond = new TimeSpan(0,0,1000000000); // This is an alternate method of doing this.
        DateTime answer = moment.Add(new TimeSpan(0,0,1000000000)); // This is "in-lining" a variable
        return answer;
    }
}