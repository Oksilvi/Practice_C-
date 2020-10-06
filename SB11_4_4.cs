using System;

public class Program
{
	public static void Main()
	{
		int S = Convert.ToInt32(Console.ReadLine()); // array size
		int [] array = new int[S];
		Random rand = new Random();
		int max = 0, max2 = 0;
		for( int i = 0; i < S; i ++ )
		{
			array[i] = rand.Next(30) + 1;
			Console.WriteLine(array[i]);
		}
		for( int i = 0; i < S; i ++ )
		{
			if( array[i] > max )
			{
				max2 = max;
				max = array[i];
			}
			else
			if( array[i] <= max && array[i] > max2 )
				max2 = array[i];
		}
		Console.WriteLine("Max:" + " " + max + " " + "Max2:" + " " + max2);
	}
}