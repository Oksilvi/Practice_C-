using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int N = Convert.ToInt32(Console.ReadLine()); // number to find
		int M = Convert.ToInt32(Console.ReadLine()); // array size
		int k = -1;
		int [] array = new int[M];
		Random rand = new Random();
		for( int i = 0; i < M; i ++ )
		{
			array[i] = rand.Next(10) + 1;
		}
		for( int i = 0; i < M; i ++ )
		{
			Console.WriteLine(array[i]);
			if( N == array[i] )
			{
				k = i;
				break;
			}
		}
		 if( k != - 1 ) Console.WriteLine("Index:" + " " + k); else
		 Console.WriteLine("No values");
	}
}