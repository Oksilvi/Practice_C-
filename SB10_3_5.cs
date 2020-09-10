using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, k;
		N = Convert.ToInt32(Console.ReadLine()); // Number of Cores
		k = 0; // number of safe divisions
		while( N < 50 )
		{
			N *= 3;
		    k ++;
			Console.WriteLine( N );
		}
		Console.Write( "number of safe divisions:" + " " + (k - 1) );
	}
}