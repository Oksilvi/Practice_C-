using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int S = Convert.ToInt32(Console.ReadLine());
		int [] array = new int[S];
		int [] array2 = new int[2 * S];
		Random rand = new Random();
		for( int i = 0; i < S; i ++ )
		{
			array[i] = rand.Next(25) + 1;
			Console.WriteLine(array[i]);
		}
		Console.WriteLine("Copy:");
		for( int i = 0; i < S; i ++ )
		{
			if( i == S - 1 )
			{
				for( int k = i; k < 2 * S - 1; k ++ )
				{
					array2[k] = array[k - i];
					Console.WriteLine(array2[k]);
				}
			}
		}
	}
}