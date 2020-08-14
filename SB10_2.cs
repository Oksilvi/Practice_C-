using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N;
		N = Convert.ToInt32(Console.ReadLine());
		while (N > 1)
		{
			N--;
			Console.WriteLine(N);
		}
	}
}