using System;
using System.Collections.Generic;

public static class NucleotideCount
{
	public static IDictionary<char, int> DnaCharacter = new Dictionary<char, int>();
	
    public static IDictionary<char, int> Count(string sequence)
    {
		DnaCharacter['A'] = 0;
		DnaCharacter['C'] = 0;
		DnaCharacter['G'] = 0;
		DnaCharacter['T'] = 0;
		
		foreach(char character in sequence)
		{
			if(character != 'A' && character != 'C' && character != 'G' && character != 'T')
			{
				throw new ArgumentException();
			}
			++DnaCharacter[character];
		}
		
		return DnaCharacter;				
    }
}