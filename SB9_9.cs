using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int i, N, sum, sum2;
		sum = 0;
		sum2 = 0;
		for( i = 1; i <= 3; i ++ )
		{
			N = Convert.ToInt32(Console.ReadLine());
			sum += N;
		}
		Console.WriteLine("Input 2:");
		for( i = 1; i <= 3; i++ )
		{
			N = Convert.ToInt32(Console.ReadLine());
			sum2 += N;
		}
		if( sum == sum2 ) Console.WriteLine("lucky ticket"); else
		 Console.WriteLine("Unlucky ticket");	
	}
}