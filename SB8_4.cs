using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N, i, sum;
		N = Convert.ToInt32(Console.ReadLine());
		sum = 0;
		for( i = 0; i <= N; i = i + 1 )
		{
			if (i > 0) i = i + 2;
			sum = sum + i;	
		}
		Console.WriteLine(sum);
	}
}