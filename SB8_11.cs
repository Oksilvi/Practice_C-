using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, Q, i;
		N = Convert.ToInt32(Console.ReadLine());
		Q = 1;
		for( i = 1; i <= N; i = i + 1 )
			Q = Q * i;
		    Console.WriteLine(Q);
	}
}