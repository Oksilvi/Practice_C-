using System;
					
public class Program
{
	public static void Main()
	{
		string s1 = "count the number of spaces in a line";
		char [] sy = s1.ToCharArray();
		int k = 0;
		for( int i = 0; i < s1.Length; i ++ )
		{
			if( sy [i] == ' ' )
			   k ++;  
		}
		Console.WriteLine("Number: " + k);
	}
}