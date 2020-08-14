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
			N /= 2; 
			if( N % 2 == 1 ) k ++;
			Console.WriteLine(N);
		}
		Console.Write("units" + " " + k);
	}
}