using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("The strand lengths entered are not the same.");
        }
        else
        {
            int HammingCount = 0;
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    HammingCount++;
                }
            }

            return (HammingCount);
        }
    }
}