using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, k;
		N = Convert.ToInt32(Console.ReadLine());
		k = 0; // number of iterations
		while( N != 1 )
		{
			k ++;
			if( N % 2 == 0 ) N /= 2; else
			N = (N * 3) + 1;
			Console.WriteLine(N);
		}	
		Console.WriteLine( "number of iterations:" + " " + k);
	}
}