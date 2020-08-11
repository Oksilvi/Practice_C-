using System;
					
public class Program
{
	public static void Main()
	{
		int i, N;
		for( N = 1; N <= 7; N ++ )
		{
			for( i = 1; i <= 4; i ++ ) 
			    if( N == 1 || N == 7 ) Console.Write("*");
			    if( N == 4 )
				   for( i = 1; i <= 4; i ++ )
				       Console.Write("*");	
			    else Console.Write("*");	
		Console.WriteLine("");
		}
	}
}