using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int S = Convert.ToInt32(Console.ReadLine()); // array size
		int [] array = new int[S];
		Random rand = new Random();
		for( int i = 0; i < S; i ++ )
		{
			array[i] = rand.Next(25) + 1;
			Console.WriteLine(array[i]);
		}
		Console.WriteLine("Mirror:");
		for( int i = S - 1; i >= 0; i -- )
		{
			Console.WriteLine(array[i]);
		}
	}
}