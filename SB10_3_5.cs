using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, Q, k;
		N = Convert.ToInt32(Console.ReadLine()); // Number of Cores
		Q = Convert.ToInt32(Console.ReadLine()); // threshold
		k = 0; // number of safe divisions
		do
		{
			N *= 3;
			k++;
			Console.WriteLine(N);
		}
		while (N < Q);
		Console.Write("number of safe divisions:" + " " + (k - 1));
	}
}