using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N;
		N = Convert.ToInt32(Console.ReadLine());
		int [] array = new int[N];
		int [] array2 = new int[2 * N];
		Random rand = new Random();
		for( int i = 0; i < N; i ++ )
		{
			array[i] = rand.Next(25) + 1;
			Console.WriteLine(array[i]);
			if( i == N - 1 )
			{
				for( int k = i; k < 2 * i + 1; k ++ )
				{
			             array2[k] = array[k - i];	
			             Console.WriteLine(array2[k]);
				}
			}
		}
	}
}