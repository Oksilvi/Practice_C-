using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, M, i;
		double sum;
		sum = 0;
		N = Convert.ToInt32(Console.ReadLine());
		M = Convert.ToInt32(Console.ReadLine());
		for( i = N; i >= N && i <= M; i = i + 1 )
			sum = sum + i;
		Console.WriteLine("Summa" + " " + sum + " " + "Mean" + " " + sum / (M - N + 1) );
	}
}