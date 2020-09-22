using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input:");
		int S = Convert.ToInt32(Console.ReadLine());
		int [] array1 = new int[S];
		int [] array2 = new int[S];
		Random rand = new Random();
		Console.WriteLine("Array1:");
		for( int i = 0; i < S; i ++ )
		{
		     array1[i] = rand.Next(25) + 1;
		     Console.WriteLine(array1[i]);
		}
		Console.WriteLine("Array2:");
		for( int i = 0; i < S; i ++ )
		{
		     array2[i] = rand.Next(25) + 1;
		}
		Console.WriteLine("Copy:");
		for( int i = 0; i < S; i ++ )
		{
	             array2[i] = array1[i];
		     Console.WriteLine(array2[i]);
		}
	}
}