using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, i, sum;
		sum = 0;
		N = Convert.ToInt32(Console.ReadLine());
		for( i = 1; i <= N; i = i + 1 )
			sum = sum + i * i;
		Console.WriteLine(sum);
	}
}