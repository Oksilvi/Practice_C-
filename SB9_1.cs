using System;
					
public class Program
{
	public static void Main()
	{
		int N, i;
		for( N = 1; N <= 9; N ++ )
		{
			for( i = 1; i <= N; i ++ )
				if( N > 5 ) break; else
			    Console.Write( " * " );	
			    if( N > 5 ) 
				for( i = 10 - N; i >= 1; i -- )
					Console.Write( " * " );	
			Console.WriteLine("");
		}
	}
}