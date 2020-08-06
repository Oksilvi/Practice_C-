using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, i, X, Y, k;
		N = Convert.ToInt32(Console.ReadLine()); // day
		X = Convert.ToInt32(Console.ReadLine()); // volume
		Y = Convert.ToInt32(Console.ReadLine()); // eat
		k = X;
		for( i = 2; i <= N; i = i + 1 )
		{
			if( X <= Y ) 
			{
				X = 0; Console.WriteLine("Day:" + " " + i);
			}
			else
			X = X - Y;
			k = k + X;
		}
		Console.WriteLine("Volume:" + " " + k);
	}
}