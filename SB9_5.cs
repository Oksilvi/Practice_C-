using System;
					
public class Program
{
	public static void Main()
	{
		int i, N;
		for( i = 1; i <= 15; i ++)
		{
			for( N = 1; N <= 17; N ++ )
			{
				if( i >= 4 && i <= 6 || i >= 10 && i <= 12 ) continue;
			        Console.Write("o");
			}
			    if( i >= 4 && i <= 6 )
			{
				    for( N = 1; N <= 4; N ++ )
					     Console.Write("o");
			}
			    if( i >= 10 && i <= 12 )
			{
				    for( N = 1; N <= 17; N ++ )
					     if( N <= 13 ) Console.Write(" "); else
				             Console.Write("o");    
			}
			Console.WriteLine("");
		}
	}
}