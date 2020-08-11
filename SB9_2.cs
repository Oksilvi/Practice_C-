using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Number:");
		int i, N;
		N = 0;
		for( i = 100; i <= 400; i ++ )
			if( i % 7 == 0 ) 
			N ++;
		Console.WriteLine(N);
	}
}