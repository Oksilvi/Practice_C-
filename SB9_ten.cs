using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int i, N, k, a, b, c, d;
		a = 0;
		b = 0;
		c = 0;
		d = 0;
		N = Convert.ToInt32(Console.ReadLine()); // number of ratings
		for( i = 1; i <= N; i ++ )
		{
			k = Convert.ToInt32(Console.ReadLine());
			if( k % 5 == 0 ) a += 1; else
			if( k % 2 == 0 ) b += 1; else
			if( k % 3 == 0 ) c += 1; else 
			if( k % 13 == 0 ) d += 1;
		}
		Console.WriteLine("Five: " + a + " " + "Four: " + b + " " + "Three: " + c + " " + "Two: " + d);
	}
}