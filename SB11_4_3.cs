using System;

public class Program
{
	public static void Main()
	{
		int S = Convert.ToInt32(Console.ReadLine()); // array size
		int[] array = new int[S];
		Random rand = new Random();
		array[0] = rand.Next(30) + 1;
		int max = array[0], min = array[0];
		for( int i = 0; i < S; i++ )
		{
			array[i] = rand.Next(30) + 1;
			Console.WriteLine(array[i]);
		}
		for( int i = 0; i < S; i++ )
		{
			if( array[i] > max )
				max = array[i];
			if( array[i] < min )
				min = array[i];
		}
		Console.WriteLine("Min:" + " " + min + " " + "Max:" + " " + max);
	}
}