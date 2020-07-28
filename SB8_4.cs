using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, i, sum;
		N = Convert.ToInt32(Console.ReadLine());
		sum = 0;
		for( i = 0; i <= N; )
		{
			sum = sum + i;
			if( i > 0 ) i = i + 2; else
			i = i + 1;
		}
		Console.WriteLine(sum);
	}
}