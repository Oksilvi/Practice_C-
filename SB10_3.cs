using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, k;
		N = Convert.ToInt32(Console.ReadLine());
		k = 0;
		while( N > 0 ) 
		{
			if( N % 2 == 1 ) k ++;
			N /= 2;
			Console.WriteLine(N);
		}
		Console.Write("units" + " " + k);
	}
}